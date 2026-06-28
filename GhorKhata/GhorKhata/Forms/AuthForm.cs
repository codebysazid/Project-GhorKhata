using GhorKhata.Logic.AuthForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhorKhata
{
    public partial class AuthForm : Form
    {

        private WelcomePanelSlider welcomeSlider;
        private LoginRegistrationSlider loginRegSlider;
        private RegistrationRules validator;


        public AuthForm()
        {
            InitializeComponent();

            LoginPanel.Location = new Point((this.ClientSize.Width - LoginPanel.Width) / 2, (this.Height - LoginPanel.Height) / 2);
            RegistrationPanel.Location = new Point(this.Width + 180, LoginPanel.Top);
            WelcomePanel.Location = new Point((this.ClientSize.Width - WelcomePanel.Width) / 2, (this.Height - WelcomePanel.Height) / 2);
            ForgetPanel.Location = new Point((this.ClientSize.Width - ForgetPanel.Width) / 2, (this.Height - ForgetPanel.Height) / 2);
            VarificationPanel.Location = new Point((this.ClientSize.Width - VarificationPanel.Width) / 2, (this.Height - VarificationPanel.Height) / 2);

            ForgetPanel.Visible = false;
            VarificationPanel.Visible = false;

            welcomeSlider = new WelcomePanelSlider(WelcomePanel, WelcomeTimer, speed: 30);
            loginRegSlider = new LoginRegistrationSlider(LoginPanel, RegistrationPanel, LoginRegTimer, speed: 40);


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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ForgetPanel.Visible = false;
        }

        private void linkLabelCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginRegSlider.StartSlidingLeft();
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
            
        }

        private void txtRegUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRegEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRegPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chkTerms_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void lblDOBStatus_Click(object sender, EventArgs e)
        {
            
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
            VarificationPanel.Visible = false;
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginRegSlider.StartSlidingRight();
        }

        private void lnkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPanel.Visible = true;
        }

        private void btnForgX_Click(object sender, EventArgs e)
        {
            ForgetPanel.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            welcomeSlider.StartSliding();
        }

        private void WelcomeTimer_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}