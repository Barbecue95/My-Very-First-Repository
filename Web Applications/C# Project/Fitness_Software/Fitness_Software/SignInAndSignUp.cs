using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Fitness_Software
{
    public partial class SignInAndSignUp : Form
    {
        public SignInAndSignUp()
        {
            InitializeComponent();
        }

        //switch sign up panel to sign in panel
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignUpPanel.Visible = false;
            SignInPanel.Visible = true;
        }
        //switch sign in panel to sign up panel
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpPanel.Visible = true;
            SignInPanel.Visible = false;
        }

        int fail = 0;
        tblUser user = new tblUser();
        // login panel code
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter Username and Password !!");
                return;
            }
            else
            {
                if (user.CheckCredentials(username, password))
                {
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    MainForm app = new MainForm();
                    app.Closed += (s, args) => Close();
                    app.Show();
                }
                else
                {
                    MessageBox.Show("The entered username or password is incorrect.");
                    fail++;
                    if (fail == 3)
                    {
                        MessageBox.Show("You have to wait 30 second.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        timer1.Interval = 30000; // (30 * 1000); // 30 second
                        timer1.Tick += timer1_Tick;
                        timer1.Start();

                        //disable input after 3 attempts
                        txtUsername.ReadOnly = true;
                        txtPassword.ReadOnly = true;
                        btnLogin.Enabled = false;
                        btnSignIn.Enabled = false;
                        btnSignUp.Enabled = false;
                    }
                }
            }
        }

        private void lnkHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            lnkHide.Visible = false;
            lnkShow.Visible = true;
        }

        private void lnkShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            lnkHide.Visible = true;
            lnkShow.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            btnLogin.Enabled = true;
            btnSignIn.Enabled = true;
            btnSignUp.Enabled = true;
            fail = 0;
        }










        //Register panel code
        private void lnkReHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtRePassword.UseSystemPasswordChar = true;
            lnkReHide.Visible = false;
            lnkReShow.Visible = true;
        }

        private void lnkReShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtRePassword.UseSystemPasswordChar = false;
            lnkReHide.Visible = true;
            lnkReShow.Visible = false;
        }

        private void lnkConHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtReConPassword.UseSystemPasswordChar = true;
            lnkConHide.Visible = false;
            lnkConShow.Visible = true;
        }

        private void lnkConShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtReConPassword.UseSystemPasswordChar = false;
            lnkConHide.Visible = true;
            lnkConShow.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string reName , rePassword, reConPassword;
            decimal reSetGoal;
            reName = txtReUsername.Text;
            rePassword = txtRePassword.Text;
            reConPassword = txtReConPassword.Text;
            

            if (!IsValidUsername(reName))
            {
                MessageBox.Show("Username can only contain letters and numbers.");
                return;
            }
            else if (!IsValidPassword(rePassword))
            {
                MessageBox.Show("Password must be 12 characters long and contain at least one lowercase and one uppercase letter.");
                return;
            }
            else if (rePassword != reConPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }else if (txtReGoal.Text == "")
            {
                MessageBox.Show("Input goal.");
                return;
            }
            else
            {
                reSetGoal = Convert.ToDecimal(txtReGoal.Text);
                bool check = user.userValid(reName); //checking existing username in the database
                if (check)
                {
                    MessageBox.Show("Username already exist. Change your username");
                }
                else
                {
                    user.UserRegister(reName,rePassword,reSetGoal);
                    MessageBox.Show("Account Created");
                    txtReUsername.Text = string.Empty;
                    txtRePassword.Text = string.Empty;
                    txtReConPassword.Text = string.Empty;
                    txtReGoal.Text = string.Empty;
                }
            }

        }

        private bool IsValidUsername(string username)
        {
            foreach (char c in username)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsValidPassword(string password) 
        {
            if (password.Length != 12)
            {
                return false;
            }

            bool hasLowercase = false;
            bool hasUppercase = false;

            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    hasLowercase = true;
                }
                else if (char.IsUpper(c))
                {
                    hasUppercase = true;
                }
            }

            return hasLowercase && hasUppercase;
        }

        private void txtReGoal_KeyPress(object sender, KeyPressEventArgs e)  //invaliding character
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
