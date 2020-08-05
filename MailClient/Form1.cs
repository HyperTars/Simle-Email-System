using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MailClient
{
    public partial class FrmMain : Form
    {
        ArrayList mails;
        POP3 pop3 = null;
        SMTP smtp = null;
        FormAccount formAccount;
        Dictionary<string, MailAccount> accounts;

        int selectId = -1;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e) {}

        private void FrmMain_Load(object sender, EventArgs e)
        {
            formAccount = new FormAccount();
            accounts = new Dictionary<string, MailAccount>();
        }

        private void btnTest_Click(object sender, EventArgs e){}

        private void tFresh_Tick(object sender, EventArgs e)
        {
            
            this.Text = "收取邮件中";
            string info = pop3.getInfo();
            if (info == "")
                return;

            tFresh.Enabled = false;
            if (info != pop3.suc)
                this.Text = "收取失败";

            mails = pop3.getMails();

            foreach (Mail m in mails)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.From;
                lvi.SubItems.Add(m.Subject);
                lvi.SubItems.Add(m.Date);
                lvi.SubItems.Add(m.Id.ToString());
                lvMailBox.Items.Add(lvi);
            }
            this.Text = "收取完成";
        }

        private void lvMailBox_DoubleClick(object sender, EventArgs e)
        {
            if (lvMailBox.SelectedItems.Count == 0)
                return;
            ListViewItem lvi = lvMailBox.SelectedItems[0];
            selectId = Convert.ToInt32(lvi.SubItems[3].Text);
            tabcMain.SelectedTab = tbpMail;
            Mail mail = (Mail)mails[selectId];
            gbMailHeader.Text = mail.Subject;
            lbFrom.Text = mail.From;
            lbDate.Text = mail.Date;
            txtContentRO.Text = mail.Content;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectId != -1 && !tFresh.Enabled)
            {
                if (tscbAccount.SelectedItem != null)
                    pop3 = new POP3(accounts[tscbAccount.SelectedItem.ToString()]);
                else
                    return;
                pop3.remove(selectId + 1);

                lbFrom.Text = "";
                gbMailHeader.Text = "";
                lbDate.Text = "";
                txtContentRO.Text = "";

                lvMailBox.Items.Clear();            
                tabcMain.SelectedTab = tbpMailbox;
                selectId = -1;

                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                收取ToolStripMenuItem_Click(this, null);
                
            }
        }

        private void 收取ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tscbAccount.SelectedItem != null && !tFresh.Enabled)
                pop3 = new POP3(accounts[tscbAccount.SelectedItem.ToString()]);
            else
                return;
            lvMailBox.Items.Clear();
            pop3.threadingRetrieve();

            tFresh.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tscbAccount.SelectedItem != null)
                smtp = new SMTP(accounts[tscbAccount.SelectedItem.ToString()]);
            else
                return;
            Mail mail = new Mail(txtRecv.Text, txtSubject.Text, txtContent.Text);
            smtp.sendmail(mail);

            txtRecv.Text = "";
            txtSubject.Text = "";
            txtContent.Text = "";

            if (smtp.getInfo() == SMTP.suc)
                MessageBox.Show("发送成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(smtp.getInfo());
        }

        void accountUpdate()
        {
            tscbAccount.Items.Clear();
            foreach (string key in accounts.Keys)
                tscbAccount.Items.Add(key);
            if (tscbAccount.Items.Count > 0)
                tscbAccount.SelectedItem = tscbAccount.Items[0];
        }

        private void 新建账户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAccount.ShowDialog();
            MailAccount account = formAccount.getAccount();
            if (accounts.ContainsKey(account.Username))
                return;
            accounts.Add(account.Username, account);
            accountUpdate();
        }

        private void 删除账户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tscbAccount.SelectedItem != null)
            {
                accounts.Remove(tscbAccount.SelectedItem.ToString());
                tscbAccount.Items.Remove(tscbAccount.SelectedItem);
                tscbAccount.Text = "";
            }
        }

        private void 账户ToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void tscbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectId = -1;
            lvMailBox.Items.Clear();
        }
    }
}
