namespace MailClient
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.收取ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbAccount = new System.Windows.Forms.ToolStripComboBox();
            this.tabcMain = new System.Windows.Forms.TabControl();
            this.tbpMailbox = new System.Windows.Forms.TabPage();
            this.lvMailBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpNewMail = new System.Windows.Forms.TabPage();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtRecv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpMail = new System.Windows.Forms.TabPage();
            this.txtContentRO = new System.Windows.Forms.TextBox();
            this.gbMailHeader = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tFresh = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabcMain.SuspendLayout();
            this.tbpMailbox.SuspendLayout();
            this.tbpNewMail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpMail.SuspendLayout();
            this.gbMailHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.收取ToolStripMenuItem,
            this.账户ToolStripMenuItem,
            this.tscbAccount});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 收取ToolStripMenuItem
            // 
            this.收取ToolStripMenuItem.Name = "收取ToolStripMenuItem";
            this.收取ToolStripMenuItem.Size = new System.Drawing.Size(51, 28);
            this.收取ToolStripMenuItem.Text = "收取";
            this.收取ToolStripMenuItem.Click += new System.EventHandler(this.收取ToolStripMenuItem_Click);
            // 
            // 账户ToolStripMenuItem
            // 
            this.账户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建账户ToolStripMenuItem,
            this.删除账户ToolStripMenuItem});
            this.账户ToolStripMenuItem.Name = "账户ToolStripMenuItem";
            this.账户ToolStripMenuItem.Size = new System.Drawing.Size(51, 28);
            this.账户ToolStripMenuItem.Text = "账户";
            this.账户ToolStripMenuItem.Click += new System.EventHandler(this.账户ToolStripMenuItem_Click);
            // 
            // 新建账户ToolStripMenuItem
            // 
            this.新建账户ToolStripMenuItem.Name = "新建账户ToolStripMenuItem";
            this.新建账户ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.新建账户ToolStripMenuItem.Text = "新建账户";
            this.新建账户ToolStripMenuItem.Click += new System.EventHandler(this.新建账户ToolStripMenuItem_Click);
            // 
            // 删除账户ToolStripMenuItem
            // 
            this.删除账户ToolStripMenuItem.Name = "删除账户ToolStripMenuItem";
            this.删除账户ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.删除账户ToolStripMenuItem.Text = "删除账户";
            this.删除账户ToolStripMenuItem.Click += new System.EventHandler(this.删除账户ToolStripMenuItem_Click);
            // 
            // tscbAccount
            // 
            this.tscbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbAccount.Name = "tscbAccount";
            this.tscbAccount.Size = new System.Drawing.Size(200, 28);
            this.tscbAccount.SelectedIndexChanged += new System.EventHandler(this.tscbAccount_SelectedIndexChanged);
            // 
            // tabcMain
            // 
            this.tabcMain.Controls.Add(this.tbpMailbox);
            this.tabcMain.Controls.Add(this.tbpNewMail);
            this.tabcMain.Controls.Add(this.tbpMail);
            this.tabcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcMain.Location = new System.Drawing.Point(0, 32);
            this.tabcMain.Name = "tabcMain";
            this.tabcMain.SelectedIndex = 0;
            this.tabcMain.Size = new System.Drawing.Size(782, 521);
            this.tabcMain.TabIndex = 1;
            // 
            // tbpMailbox
            // 
            this.tbpMailbox.Controls.Add(this.lvMailBox);
            this.tbpMailbox.Location = new System.Drawing.Point(4, 25);
            this.tbpMailbox.Name = "tbpMailbox";
            this.tbpMailbox.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMailbox.Size = new System.Drawing.Size(774, 492);
            this.tbpMailbox.TabIndex = 0;
            this.tbpMailbox.Text = "收件箱";
            this.tbpMailbox.UseVisualStyleBackColor = true;
            // 
            // lvMailBox
            // 
            this.lvMailBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMailBox.Location = new System.Drawing.Point(3, 3);
            this.lvMailBox.Name = "lvMailBox";
            this.lvMailBox.Size = new System.Drawing.Size(768, 486);
            this.lvMailBox.TabIndex = 0;
            this.lvMailBox.UseCompatibleStateImageBehavior = false;
            this.lvMailBox.View = System.Windows.Forms.View.Details;
            this.lvMailBox.DoubleClick += new System.EventHandler(this.lvMailBox_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "发件人";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "主题";
            this.columnHeader2.Width = 298;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "时间";
            this.columnHeader3.Width = 120;
            // 
            // tbpNewMail
            // 
            this.tbpNewMail.Controls.Add(this.txtContent);
            this.tbpNewMail.Controls.Add(this.groupBox1);
            this.tbpNewMail.Location = new System.Drawing.Point(4, 25);
            this.tbpNewMail.Name = "tbpNewMail";
            this.tbpNewMail.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNewMail.Size = new System.Drawing.Size(774, 492);
            this.tbpNewMail.TabIndex = 1;
            this.tbpNewMail.Text = "新邮件";
            this.tbpNewMail.UseVisualStyleBackColor = true;
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(3, 95);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(768, 394);
            this.txtContent.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Controls.Add(this.txtRecv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新邮件";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(687, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 75);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Location = new System.Drawing.Point(79, 56);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(602, 25);
            this.txtSubject.TabIndex = 3;
            // 
            // txtRecv
            // 
            this.txtRecv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecv.Location = new System.Drawing.Point(79, 20);
            this.txtRecv.Name = "txtRecv";
            this.txtRecv.Size = new System.Drawing.Size(602, 25);
            this.txtRecv.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "主题：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "收件人：";
            // 
            // tbpMail
            // 
            this.tbpMail.Controls.Add(this.txtContentRO);
            this.tbpMail.Controls.Add(this.gbMailHeader);
            this.tbpMail.Location = new System.Drawing.Point(4, 25);
            this.tbpMail.Name = "tbpMail";
            this.tbpMail.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMail.Size = new System.Drawing.Size(774, 492);
            this.tbpMail.TabIndex = 2;
            this.tbpMail.Text = "收件";
            this.tbpMail.UseVisualStyleBackColor = true;
            // 
            // txtContentRO
            // 
            this.txtContentRO.BackColor = System.Drawing.Color.White;
            this.txtContentRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContentRO.Location = new System.Drawing.Point(3, 95);
            this.txtContentRO.Multiline = true;
            this.txtContentRO.Name = "txtContentRO";
            this.txtContentRO.ReadOnly = true;
            this.txtContentRO.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContentRO.Size = new System.Drawing.Size(768, 394);
            this.txtContentRO.TabIndex = 1;
            // 
            // gbMailHeader
            // 
            this.gbMailHeader.Controls.Add(this.btnDelete);
            this.gbMailHeader.Controls.Add(this.lbDate);
            this.gbMailHeader.Controls.Add(this.lbFrom);
            this.gbMailHeader.Controls.Add(this.label2);
            this.gbMailHeader.Controls.Add(this.label1);
            this.gbMailHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMailHeader.Location = new System.Drawing.Point(3, 3);
            this.gbMailHeader.Name = "gbMailHeader";
            this.gbMailHeader.Size = new System.Drawing.Size(768, 92);
            this.gbMailHeader.TabIndex = 0;
            this.gbMailHeader.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(687, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 75);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(80, 58);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 15);
            this.lbDate.TabIndex = 3;
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(80, 30);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(0, 15);
            this.lbFrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "发件人：";
            // 
            // tFresh
            // 
            this.tFresh.Interval = 1000;
            this.tFresh.Tick += new System.EventHandler(this.tFresh_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabcMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FrmMain";
            this.Text = "邮件客户端";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabcMain.ResumeLayout(false);
            this.tbpMailbox.ResumeLayout(false);
            this.tbpNewMail.ResumeLayout(false);
            this.tbpNewMail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpMail.ResumeLayout(false);
            this.tbpMail.PerformLayout();
            this.gbMailHeader.ResumeLayout(false);
            this.gbMailHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 收取ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建账户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tscbAccount;
        private System.Windows.Forms.TabControl tabcMain;
        private System.Windows.Forms.TabPage tbpMailbox;
        private System.Windows.Forms.TabPage tbpNewMail;
        private System.Windows.Forms.ListView lvMailBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tbpMail;
        private System.Windows.Forms.GroupBox gbMailHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContentRO;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtRecv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Timer tFresh;
        private System.Windows.Forms.ToolStripMenuItem 删除账户ToolStripMenuItem;
    }
}

