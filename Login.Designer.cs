namespace Library_Final_Project
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.linkLblCreateAccount = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolSForgot = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSFindPass = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSContact = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(265, 276);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(251, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // linkLblCreateAccount
            // 
            this.linkLblCreateAccount.AutoSize = true;
            this.linkLblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblCreateAccount.Location = new System.Drawing.Point(564, 387);
            this.linkLblCreateAccount.Name = "linkLblCreateAccount";
            this.linkLblCreateAccount.Size = new System.Drawing.Size(224, 17);
            this.linkLblCreateAccount.TabIndex = 5;
            this.linkLblCreateAccount.TabStop = true;
            this.linkLblCreateAccount.Text = "Haven\'t one? Create New Account";
            this.linkLblCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liLblCreate_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSForgot,
            this.toolSAboutUs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolSForgot
            // 
            this.toolSForgot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSFindPass,
            this.menuSResetPassword});
            this.toolSForgot.Name = "toolSForgot";
            this.toolSForgot.Size = new System.Drawing.Size(107, 20);
            this.toolSForgot.Text = "Forgot Password";
            this.toolSForgot.Click += new System.EventHandler(this.helloToolStripMenuItem_Click);
            // 
            // menuSFindPass
            // 
            this.menuSFindPass.Name = "menuSFindPass";
            this.menuSFindPass.Size = new System.Drawing.Size(192, 22);
            this.menuSFindPass.Text = "Find My Old Password";
            // 
            // menuSResetPassword
            // 
            this.menuSResetPassword.Name = "menuSResetPassword";
            this.menuSResetPassword.Size = new System.Drawing.Size(192, 22);
            this.menuSResetPassword.Text = "Reset My Password";
            this.menuSResetPassword.Click += new System.EventHandler(this.menuSResetPassword_Click);
            // 
            // toolSAboutUs
            // 
            this.toolSAboutUs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSInformation,
            this.menuSContact});
            this.toolSAboutUs.Name = "toolSAboutUs";
            this.toolSAboutUs.Size = new System.Drawing.Size(73, 20);
            this.toolSAboutUs.Text = "Aboust Us";
            // 
            // menuSInformation
            // 
            this.menuSInformation.Name = "menuSInformation";
            this.menuSInformation.Size = new System.Drawing.Size(180, 22);
            this.menuSInformation.Text = "Information";
            // 
            // menuSContact
            // 
            this.menuSContact.Name = "menuSContact";
            this.menuSContact.Size = new System.Drawing.Size(180, 22);
            this.menuSContact.Text = "Contact To Us";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(265, 183);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(251, 20);
            this.tbUsername.TabIndex = 3;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLblCreateAccount);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.LinkLabel linkLblCreateAccount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolSForgot;
        private System.Windows.Forms.ToolStripMenuItem menuSFindPass;
        private System.Windows.Forms.ToolStripMenuItem menuSResetPassword;
        private System.Windows.Forms.ToolStripMenuItem toolSAboutUs;
        private System.Windows.Forms.ToolStripMenuItem menuSInformation;
        private System.Windows.Forms.ToolStripMenuItem menuSContact;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbUsername;
    }
}

