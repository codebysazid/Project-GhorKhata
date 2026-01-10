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
        public LoginForm()
        {
            InitializeComponent();
        }
        public void CheckRegistrationRules()
        {
 
            string name = txtRegName.Text.Trim();
            string user = txtRegUser.Text.Trim();
            string email = txtRegEmail.Text.Trim();
            DateTime dob = dtpDOB.Value;
            string pass = txtRegPass.Text;
            string confirm = txtRegConPass.Text;
            bool termsAccepted = chkTerms.Checked;

      
            bool hasLength = pass.Length >= 6;
            bool hasLetter = pass.Any(char.IsLetter);
            bool hasDigit = pass.Any(char.IsDigit);
            bool isSafePassword = hasLength && hasLetter && hasDigit;

   
            bool isValidEmail = !string.IsNullOrEmpty(email) &&
                               email.Contains("@") &&
                               email.Contains(".");

       
            bool isMatch = (pass == confirm && !string.IsNullOrEmpty(pass));
            bool isOfAge = dob.Date <= DateTime.Today.AddYears(-13);
            bool isUsernameValid = !string.IsNullOrWhiteSpace(user) && user.Length >= 3;
            bool isNameValid = !string.IsNullOrWhiteSpace(name);

 
            bool allConditionsMet = isUsernameValid &&
                                   isValidEmail &&
                                   cmbGender.SelectedIndex != -1 &&
                                   isNameValid &&
                                   isOfAge &&
                                   isSafePassword &&
                                   isMatch &&
                                   termsAccepted;

      
            if (!isOfAge)
            {
                lblDOBStatus.Text = "⚠️ You must be 13+";
                lblDOBStatus.ForeColor = ThemeColor.StatusError;
            }
            else
            {
                lblDOBStatus.Text = "";
            }

        
            if (!string.IsNullOrEmpty(pass))
            {
                if (!isSafePassword)
                {
                    txtRegPass.BackColor = ThemeColor.InputError;
                    lblPassStatus.ForeColor = ThemeColor.StatusError;

                    if (!hasLength) lblPassStatus.Text = "⚠️ Too Short (Need 6+)";
                    else if (!hasLetter) lblPassStatus.Text = "⚠️ Need a Letter (A-Z)";
                    else if (!hasDigit) lblPassStatus.Text = "⚠️ Need a Digit (0-9)";
                }
                else
                {
                    txtRegPass.BackColor = ThemeColor.InputSuccess;
                    lblPassStatus.ForeColor = ThemeColor.StatusSuccess;
                    lblPassStatus.Text = "✔️ Strong Password";
                }
            }
            else
            {
                txtRegPass.BackColor = ThemeColor.InputBg;
                lblPassStatus.Text = "";
            }


            if (!string.IsNullOrEmpty(confirm))
            {
                if (isMatch)
                {
                    txtRegConPass.BackColor = ThemeColor.InputSuccess;
                    lblConPassStatus.Text = "✔️ Matched";
                    lblConPassStatus.ForeColor = ThemeColor.StatusSuccess;
                }
                else
                {
                    txtRegConPass.BackColor = ThemeColor.InputError;
                    lblConPassStatus.Text = "⚠️ Not Matched";
                    lblConPassStatus.ForeColor = ThemeColor.StatusError;
                }
            }
            else
            {
                txtRegConPass.BackColor = ThemeColor.InputBg;
                lblConPassStatus.Text = "";
            }

            // Email validation feedback (add this if you have a label for it)
            if (!string.IsNullOrEmpty(email) && !isValidEmail)
            {
                // Assuming you have lblEmailStatus
                lblEmailStatus.Text = "⚠️ Invalid email format";
                lblEmailStatus.ForeColor = ThemeColor.StatusError;
            }
            else if (!string.IsNullOrEmpty(email))
            {
                lblEmailStatus.Text = "";
            }

            // Enable/disable create button
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
            Welcome welcomeForm = new Welcome();
            welcomeForm.Show();
            this.Close();
        }

        private void linkLabelCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
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
    }
}
