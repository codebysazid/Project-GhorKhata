namespace GhorKhata
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
