using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhorKhata
{
    public partial class LoginForm : Form
    {
        int speed = 40;
        bool movingLeft = false;
        public LoginForm()
        {
            InitializeComponent();

            pnlLogin.Location = new Point((this.ClientSize.Width - pnlLogin.Width) / 2, (this.Height - pnlLogin.Height) / 2);

            pnlRegistration.Location = new Point(this.Width + 180, pnlLogin.Top);

            pnlForget.Visible = false;

            pnlVarify.Visible = false;

        }

        public void CheckRegistrationRules()
        {
            string name = txtRegName.Text.Trim();
            string user = txtRegUser.Text.Trim();
            string email = txtRegEmail.Text.Trim();
            DateTime dob = dtpDOB.Value;
            string gender = cmbGender.SelectedItem?.ToString() ?? "";
            string pass = txtRegPass.Text;
            string confirm = txtRegConPass.Text;
            bool termsAccepted = chkTerms.Checked;


            // Name validation
            bool isNameValid = !string.IsNullOrWhiteSpace(name) && name.Length >= 3;
            if (!isNameValid)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    lblNameStatus.Text = "⚠️ Name cannot be empty";
                }
                else
                {
                    lblNameStatus.Text = "⚠️ Name must be at least 3 characters";
                }

                lblNameStatus.ForeColor = ThemeColor.StatusError;
            }
            else
            {
                lblNameStatus.Text = "";
            }


            // Username validation
            bool isUsernameValid = user.Length >= 3 &&
                                  user.All(c => (c >= 'a' && c <= 'z') ||
                                               (c >= '0' && c <= '9'));
            if (user.Length < 3)
            {
                lblRegUserStatus.Text = "⚠️ Username too short (3+)";
                lblRegUserStatus.ForeColor = ThemeColor.StatusError;
            }
            else if (!user.All(x => (x >= 'a' && x <= 'z') ||
                                   (x >= '0' && x <= '9')))
            {
                lblRegUserStatus.Text = "⚠️ Only letters(a-z) and numbers(0-9) allowed";
                lblRegUserStatus.ForeColor = ThemeColor.StatusError;
            }
            else if (string.IsNullOrEmpty(user))
            {
                lblRegUserStatus.Text = "⚠️ Username cannot be empty";
                lblRegUserStatus.ForeColor = ThemeColor.StatusError;
            }
            else
            {
                lblRegUserStatus.Text = "";
            }


            // Email validation feedback
            bool isValidEmail = !string.IsNullOrEmpty(email) &&
                               email.Contains("@") &&
                               email.Contains(".");
            if (!string.IsNullOrEmpty(email) && !isValidEmail)
            {
                lblEmailStatus.Text = "⚠️ Invalid email format";
                lblEmailStatus.ForeColor = ThemeColor.StatusError;
            }
            else if (string.IsNullOrEmpty(email))
            {
                lblEmailStatus.Text = "⚠️ Email cannot be empty";
                lblEmailStatus.ForeColor = ThemeColor.StatusError;
            }
            else
            {
                lblEmailStatus.Text = "";
            }


            // Age validation feedback
            bool isOfAge = dob.Date <= DateTime.Today.AddYears(-13);
            if (!isOfAge)
            {
                lblDOBStatus.Text = "⚠️ You must be 13+";
                lblDOBStatus.ForeColor = ThemeColor.StatusError;
            }
            else
            {
                lblDOBStatus.Text = "";
            }


            // Gender validation
            bool isGenderSelected = cmbGender.SelectedIndex != -1;
            if (!isGenderSelected)
            {
                lblGenderStatus.Text = "⚠️ Please select a gender";
                lblGenderStatus.ForeColor = ThemeColor.StatusError;
            }
            else
            {
                lblGenderStatus.Text = "";
            }


            // Password validation
            bool isSafePassword = pass.Length >= 6 &&
                                  pass.Any(char.IsLetter) &&
                                  pass.Any(char.IsDigit);
            if (!string.IsNullOrEmpty(pass))
            {
                if (!isSafePassword)
                {
                    lblPassStatus.ForeColor = ThemeColor.StatusError;
                    lblPassStatus.Text = "⚠️ Use 6+ charecters with Letters and Numbers";
                }
                else
                {
                    lblPassStatus.ForeColor = ThemeColor.StatusSuccess;
                    lblPassStatus.Text = "✔️ Strong Password";
                }
            }
            else
            {
                lblPassStatus.Text = "";
            }


            // Confirm password
            bool isMatch = (pass == confirm && !string.IsNullOrEmpty(pass));
            if (!string.IsNullOrEmpty(confirm))
            {
                if (isMatch)
                {
                    lblConPassStatus.Text = "✔️ Matched";
                    lblConPassStatus.ForeColor = ThemeColor.StatusSuccess;
                }
                else
                {
                    lblConPassStatus.Text = "⚠️ Not Matched";
                    lblConPassStatus.ForeColor = ThemeColor.StatusError;
                }
            }
            else
            {
                lblConPassStatus.Text = "";
            }


            //Terms Validation
            if (!termsAccepted)
            {
                lblTermsStatus.Text = "⚠️ You must accept terms";
                lblTermsStatus.ForeColor = ThemeColor.StatusError;
            }
            else
            {
                lblTermsStatus.Text = "";
            }


            // Enable/disable create button
            bool allConditionsMet = isNameValid && isUsernameValid && isValidEmail && isGenderSelected &&
                                    isOfAge && isSafePassword && isMatch && termsAccepted;

            btnCreate.Enabled = allConditionsMet;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Close();
        }

        private void linkLabelCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            movingLeft = true;
            pnlRegistration.Top = pnlLogin.Top;
            timerSlide.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelUserLogin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNewToGhorKhata_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {
            CheckRegistrationRules();
        }

        private void chkTerms_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblRegistration_Click(object sender, EventArgs e)
        {

        }

        private void txtRegConPass_TextChanged(object sender, EventArgs e)
        {
            CheckRegistrationRules();
        }

        private void lblRegConPass_Click(object sender, EventArgs e)
        {

        }

        private void lblNameStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblRegUserStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblEmailStatus_Click(object sender, EventArgs e)
        {

        }

        private void txtRegName_TextChanged(object sender, EventArgs e)
        {
            CheckRegistrationRules();
        }

        private void txtRegUser_TextChanged(object sender, EventArgs e)
        {
            CheckRegistrationRules();
        }

        private void txtRegEmail_TextChanged(object sender, EventArgs e)
        {
            CheckRegistrationRules();
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckRegistrationRules();
        }

        private void txtRegPass_TextChanged(object sender, EventArgs e)
        {
            CheckRegistrationRules();
        }

        private void chkTerms_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckRegistrationRules();
        }

        private void lblDOBStatus_Click(object sender, EventArgs e)
        {
            CheckRegistrationRules();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void pnlForget_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblVari_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void timerSlide_Tick(object sender, EventArgs e)
        {
            if (movingLeft)
            {
                pnlLogin.Left -= speed;
                pnlRegistration.Left -= speed;
                int centerX = (this.Width - pnlRegistration.Width) / 2;

                if (pnlRegistration.Left <= centerX)
                {
                    timerSlide.Stop();
                    pnlRegistration.Left = centerX;
                }
            }
            else
            {
                pnlLogin.Left += speed;
                pnlRegistration.Left += speed;
                int centerX = (this.Width - pnlLogin.Width) / 2;

                if (pnlLogin.Left >= centerX)
                {
                    pnlLogin.Left = centerX;
                    timerSlide.Stop();
                }
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            movingLeft = false;
            timerSlide.Start();
        }

        private void lnkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlForget.Visible = true;
        }

        private void btnForgX_Click(object sender, EventArgs e)
        {
            pnlForget.Visible = false;
        }
    }
}