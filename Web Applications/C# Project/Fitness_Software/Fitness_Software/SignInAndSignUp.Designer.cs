namespace Fitness_Software
{
    partial class SignInAndSignUp
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
            this.components = new System.ComponentModel.Container();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.lblErrortxt = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkHide = new System.Windows.Forms.LinkLabel();
            this.lnkShow = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtReGoal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lnkConHide = new System.Windows.Forms.LinkLabel();
            this.lnkConShow = new System.Windows.Forms.LinkLabel();
            this.txtReConPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkReShow = new System.Windows.Forms.LinkLabel();
            this.lnkReHide = new System.Windows.Forms.LinkLabel();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtReUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SignInPanel.SuspendLayout();
            this.SignUpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.LightBlue;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignIn.Location = new System.Drawing.Point(1, 1);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(227, 59);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // SignInPanel
            // 
            this.SignInPanel.Controls.Add(this.lblErrortxt);
            this.SignInPanel.Controls.Add(this.btnLogin);
            this.SignInPanel.Controls.Add(this.lnkHide);
            this.SignInPanel.Controls.Add(this.lnkShow);
            this.SignInPanel.Controls.Add(this.txtPassword);
            this.SignInPanel.Controls.Add(this.txtUsername);
            this.SignInPanel.Controls.Add(this.label3);
            this.SignInPanel.Controls.Add(this.label2);
            this.SignInPanel.Location = new System.Drawing.Point(1, 65);
            this.SignInPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(460, 362);
            this.SignInPanel.TabIndex = 9;
            // 
            // lblErrortxt
            // 
            this.lblErrortxt.AutoSize = true;
            this.lblErrortxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblErrortxt.Location = new System.Drawing.Point(60, 209);
            this.lblErrortxt.Name = "lblErrortxt";
            this.lblErrortxt.Size = new System.Drawing.Size(362, 29);
            this.lblErrortxt.TabIndex = 27;
            this.lblErrortxt.Text = "You have to wait 30 seconds ";
            this.lblErrortxt.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Coral;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Navy;
            this.btnLogin.Location = new System.Drawing.Point(37, 268);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(370, 55);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkHide
            // 
            this.lnkHide.AutoSize = true;
            this.lnkHide.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHide.Location = new System.Drawing.Point(367, 144);
            this.lnkHide.Name = "lnkHide";
            this.lnkHide.Size = new System.Drawing.Size(51, 22);
            this.lnkHide.TabIndex = 14;
            this.lnkHide.TabStop = true;
            this.lnkHide.Text = "Hide";
            this.lnkHide.Visible = false;
            this.lnkHide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHide_LinkClicked);
            // 
            // lnkShow
            // 
            this.lnkShow.AutoSize = true;
            this.lnkShow.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkShow.Location = new System.Drawing.Point(366, 144);
            this.lnkShow.Name = "lnkShow";
            this.lnkShow.Size = new System.Drawing.Size(59, 22);
            this.lnkShow.TabIndex = 13;
            this.lnkShow.TabStop = true;
            this.lnkShow.Text = "Show";
            this.lnkShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShow_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPassword.Location = new System.Drawing.Point(178, 134);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 34);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LightGray;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtUsername.Location = new System.Drawing.Point(178, 50);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 34);
            this.txtUsername.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(51, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(41, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.LightBlue;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignUp.Location = new System.Drawing.Point(234, 1);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(227, 59);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.Controls.Add(this.btnRegister);
            this.SignUpPanel.Controls.Add(this.txtReGoal);
            this.SignUpPanel.Controls.Add(this.label6);
            this.SignUpPanel.Controls.Add(this.lnkConHide);
            this.SignUpPanel.Controls.Add(this.lnkConShow);
            this.SignUpPanel.Controls.Add(this.txtReConPassword);
            this.SignUpPanel.Controls.Add(this.label5);
            this.SignUpPanel.Controls.Add(this.lnkReShow);
            this.SignUpPanel.Controls.Add(this.lnkReHide);
            this.SignUpPanel.Controls.Add(this.txtRePassword);
            this.SignUpPanel.Controls.Add(this.txtReUsername);
            this.SignUpPanel.Controls.Add(this.label1);
            this.SignUpPanel.Controls.Add(this.label4);
            this.SignUpPanel.Location = new System.Drawing.Point(1, 61);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(460, 366);
            this.SignUpPanel.TabIndex = 16;
            this.SignUpPanel.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Coral;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.Navy;
            this.btnRegister.Location = new System.Drawing.Point(29, 272);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(370, 55);
            this.btnRegister.TabIndex = 27;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtReGoal
            // 
            this.txtReGoal.BackColor = System.Drawing.Color.LightGray;
            this.txtReGoal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReGoal.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReGoal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtReGoal.Location = new System.Drawing.Point(229, 198);
            this.txtReGoal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReGoal.Name = "txtReGoal";
            this.txtReGoal.Size = new System.Drawing.Size(182, 34);
            this.txtReGoal.TabIndex = 26;
            this.txtReGoal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReGoal_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(23, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 34);
            this.label6.TabIndex = 25;
            this.label6.Text = "Set Fitness Goal";
            // 
            // lnkConHide
            // 
            this.lnkConHide.AutoSize = true;
            this.lnkConHide.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConHide.Location = new System.Drawing.Point(413, 151);
            this.lnkConHide.Name = "lnkConHide";
            this.lnkConHide.Size = new System.Drawing.Size(51, 22);
            this.lnkConHide.TabIndex = 24;
            this.lnkConHide.TabStop = true;
            this.lnkConHide.Text = "Hide";
            this.lnkConHide.Visible = false;
            this.lnkConHide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConHide_LinkClicked);
            // 
            // lnkConShow
            // 
            this.lnkConShow.AutoSize = true;
            this.lnkConShow.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConShow.Location = new System.Drawing.Point(410, 151);
            this.lnkConShow.Name = "lnkConShow";
            this.lnkConShow.Size = new System.Drawing.Size(59, 22);
            this.lnkConShow.TabIndex = 23;
            this.lnkConShow.TabStop = true;
            this.lnkConShow.Text = "Show";
            this.lnkConShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConShow_LinkClicked);
            // 
            // txtReConPassword
            // 
            this.txtReConPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtReConPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReConPassword.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReConPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtReConPassword.Location = new System.Drawing.Point(225, 141);
            this.txtReConPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReConPassword.Name = "txtReConPassword";
            this.txtReConPassword.Size = new System.Drawing.Size(182, 34);
            this.txtReConPassword.TabIndex = 22;
            this.txtReConPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(4, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 34);
            this.label5.TabIndex = 21;
            this.label5.Text = "Confirm Password";
            // 
            // lnkReShow
            // 
            this.lnkReShow.AutoSize = true;
            this.lnkReShow.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReShow.Location = new System.Drawing.Point(413, 91);
            this.lnkReShow.Name = "lnkReShow";
            this.lnkReShow.Size = new System.Drawing.Size(59, 22);
            this.lnkReShow.TabIndex = 20;
            this.lnkReShow.TabStop = true;
            this.lnkReShow.Text = "Show";
            this.lnkReShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReShow_LinkClicked);
            // 
            // lnkReHide
            // 
            this.lnkReHide.AutoSize = true;
            this.lnkReHide.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReHide.Location = new System.Drawing.Point(415, 89);
            this.lnkReHide.Name = "lnkReHide";
            this.lnkReHide.Size = new System.Drawing.Size(51, 22);
            this.lnkReHide.TabIndex = 19;
            this.lnkReHide.TabStop = true;
            this.lnkReHide.Text = "Hide";
            this.lnkReHide.Visible = false;
            this.lnkReHide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReHide_LinkClicked);
            // 
            // txtRePassword
            // 
            this.txtRePassword.BackColor = System.Drawing.Color.LightGray;
            this.txtRePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRePassword.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtRePassword.Location = new System.Drawing.Point(227, 81);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(182, 34);
            this.txtRePassword.TabIndex = 18;
            this.txtRePassword.UseSystemPasswordChar = true;
            // 
            // txtReUsername
            // 
            this.txtReUsername.BackColor = System.Drawing.Color.LightGray;
            this.txtReUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReUsername.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReUsername.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtReUsername.Location = new System.Drawing.Point(226, 28);
            this.txtReUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReUsername.Name = "txtReUsername";
            this.txtReUsername.Size = new System.Drawing.Size(182, 34);
            this.txtReUsername.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(72, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(62, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "Username";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SignInAndSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(462, 438);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.SignUpPanel);
            this.Controls.Add(this.SignInPanel);
            this.Controls.Add(this.btnSignIn);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SignInAndSignUp";
            this.Text = "Sign In And Sign Up";
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Panel SignInPanel;
        private System.Windows.Forms.LinkLabel lnkShow;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkHide;
        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.TextBox txtReGoal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lnkConHide;
        private System.Windows.Forms.LinkLabel lnkConShow;
        private System.Windows.Forms.TextBox txtReConPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkReShow;
        private System.Windows.Forms.LinkLabel lnkReHide;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtReUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrortxt;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Timer timer1;
    }
}

