namespace GhorKhata
{
    partial class SignupForm
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
            btnBack = new Button();
            labelUserLogin = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBack.BackColor = Color.FromArgb(60, 60, 65);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(235, 235, 235);
            btnBack.Location = new Point(8, 8);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.RightToLeft = RightToLeft.Yes;
            btnBack.Size = new Size(50, 30);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // labelUserLogin
            // 
            labelUserLogin.Anchor = AnchorStyles.Top;
            labelUserLogin.AutoSize = true;
            labelUserLogin.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserLogin.ForeColor = Color.FromArgb(235, 235, 235);
            labelUserLogin.Location = new Point(617, 75);
            labelUserLogin.Name = "labelUserLogin";
            labelUserLogin.Size = new Size(312, 55);
            labelUserLogin.TabIndex = 2;
            labelUserLogin.Text = "Registration";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(1546, 684);
            Controls.Add(labelUserLogin);
            Controls.Add(btnBack);
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label labelUserLogin;
    }
}