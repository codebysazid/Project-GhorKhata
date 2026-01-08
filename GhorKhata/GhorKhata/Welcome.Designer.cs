namespace GhorKhata
{
    partial class Welcome
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
            label_Welcome = new Label();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // label_Welcome
            // 
            label_Welcome.Anchor = AnchorStyles.None;
            label_Welcome.AutoSize = true;
            label_Welcome.Font = new Font("Arial Rounded MT Bold", 54F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Welcome.ForeColor = Color.FromArgb(235, 235, 235);
            label_Welcome.Location = new Point(341, 64);
            label_Welcome.Name = "label_Welcome";
            label_Welcome.Size = new Size(865, 83);
            label_Welcome.TabIndex = 0;
            label_Welcome.Text = "Welcome To GhorKhata";
            label_Welcome.Click += label1_Click;
            // 
            // btnEnter
            // 
            btnEnter.Anchor = AnchorStyles.None;
            btnEnter.BackColor = Color.FromArgb(40, 167, 69);
            btnEnter.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.FromArgb(235, 235, 235);
            btnEnter.Location = new Point(653, 487);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(240, 60);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1546, 684);
            Controls.Add(btnEnter);
            Controls.Add(label_Welcome);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GhorKhata";
            WindowState = FormWindowState.Maximized;
            Click += btnEnter_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Welcome;
        private Button btnEnter;
    }
}
