namespace GhorKhata
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEnter = new Button();
            panel1 = new Panel();
            lblWelcome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Anchor = AnchorStyles.None;
            btnEnter.BackColor = Color.FromArgb(40, 167, 69);
            btnEnter.FlatStyle = FlatStyle.Popup;
            btnEnter.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.FromArgb(235, 235, 235);
            btnEnter.Location = new Point(120, 630);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(240, 60);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(60, 63, 65);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(btnEnter);
            panel1.Location = new Point(552, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 800);
            panel1.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(235, 235, 235);
            lblWelcome.Location = new Point(100, 13);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(281, 165);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome\r\nTo\r\nGhorKhata";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1584, 861);
            Controls.Add(panel1);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GhorKhata";
            WindowState = FormWindowState.Maximized;
            Click += btnEnter_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEnter;
        private Panel panel1;
        private Label labelLogin;
        private Label lblWelcome;
    }
}
