using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MailClient
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }

        MailAccount account;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            account = new MailAccount(txtUsername.Text, txtPassword.Text,
                txtPop3Add.Text, Convert.ToInt32(txtPop3Port.Text),
                txtSmtpAdd.Text, Convert.ToInt32(txtSmtpPort.Text));
            this.Close();
        }

        public MailAccount getAccount()
        {
            return account;
        }
    }
}
