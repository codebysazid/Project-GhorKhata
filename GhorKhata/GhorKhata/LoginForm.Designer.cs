namespace GhorKhata
{
    partial class LoginForm
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
            labelUserLogin = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            labelNewToGhorKhata = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // labelUserLogin
            // 
            labelUserLogin.Anchor = AnchorStyles.None;
            labelUserLogin.AutoSize = true;
            labelUserLogin.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserLogin.ForeColor = Color.FromArgb(235, 235, 235);
            labelUserLogin.Location = new Point(635, 75);
            labelUserLogin.Name = "labelUserLogin";
            labelUserLogin.Size = new Size(278, 55);
            labelUserLogin.TabIndex = 0;
            labelUserLogin.Text = "User Login";
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.None;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(624, 216);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(90, 18);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.None;
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(624, 327);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(87, 18);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            labelPassword.Click += labelPassword_Click;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.None;
            txtUser.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(624, 247);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(300, 29);
            txtUser.TabIndex = 3;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.None;
            txtPass.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(624, 358);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(300, 29);
            txtPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLogin.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(654, 446);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(240, 60);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(40, 167, 69);
            linkLabel1.Location = new Point(698, 587);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(153, 22);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Account\r\n";
            // 
            // labelNewToGhorKhata
            // 
            labelNewToGhorKhata.Anchor = AnchorStyles.None;
            labelNewToGhorKhata.AutoSize = true;
            labelNewToGhorKhata.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewToGhorKhata.ForeColor = Color.White;
            labelNewToGhorKhata.Location = new Point(680, 539);
            labelNewToGhorKhata.Name = "labelNewToGhorKhata";
            labelNewToGhorKhata.Size = new Size(188, 22);
            labelNewToGhorKhata.TabIndex = 7;
            labelNewToGhorKhata.Text = "New to GhorKhata?";
            // 
            // btnBack
            // 
            btnBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBack.BackColor = Color.FromArgb(108, 117, 125);
            btnBack.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(8, 8);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.RightToLeft = RightToLeft.No;
            btnBack.Size = new Size(50, 50);
            btnBack.TabIndex = 8;
            btnBack.Text = "◀";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1546, 684);
            Controls.Add(btnBack);
            Controls.Add(labelNewToGhorKhata);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelUserLogin);
            Name = "LoginForm";
            Padding = new Padding(3, 0, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Label labelUserLogin;
        private Label labelPassword;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private LinkLabel linkLabel1;
        private Label labelNewToGhorKhata;
        private Button btnBack;
    }
}