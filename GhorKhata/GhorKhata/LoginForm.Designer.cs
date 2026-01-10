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
            lblLogin = new Label();
            lblLoginUser = new Label();
            lblLoginPass = new Label();
            txtLoginUser = new TextBox();
            txtLoginPass = new TextBox();
            btnLogin = new Button();
            lblNewtoGhorKhata = new Label();
            btnBack = new Button();
            lbkCreate = new LinkLabel();
            chkRemember = new CheckBox();
            pnlLogin = new Panel();
            lnkForget = new LinkLabel();
            pnlRegistration = new Panel();
            lblGenderStatus = new Label();
            lblDOBStatus = new Label();
            lblEmailStatus = new Label();
            lblRegUserStatus = new Label();
            lblNameStatus = new Label();
            lblConPassStatus = new Label();
            lblPassStatus = new Label();
            lnkLogin = new LinkLabel();
            lblAlreadyhave = new Label();
            lnkTerms = new LinkLabel();
            chkTerms = new CheckBox();
            btnCreate = new Button();
            txtRegPass = new TextBox();
            txtRegConPass = new TextBox();
            lblRegPass = new Label();
            lblRegConPass = new Label();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblDOB = new Label();
            dtpDOB = new DateTimePicker();
            txtRegEmail = new TextBox();
            lblEmail = new Label();
            txtRegUser = new TextBox();
            lblRegUser = new Label();
            txtRegName = new TextBox();
            lblRegName = new Label();
            lblRegistration = new Label();
            pnlLogin.SuspendLayout();
            pnlRegistration.SuspendLayout();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(235, 235, 235);
            lblLogin.Location = new Point(163, 13);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(154, 55);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            lblLogin.Click += labelUserLogin_Click;
            // 
            // lblLoginUser
            // 
            lblLoginUser.Anchor = AnchorStyles.None;
            lblLoginUser.AutoSize = true;
            lblLoginUser.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginUser.ForeColor = Color.White;
            lblLoginUser.Location = new Point(90, 475);
            lblLoginUser.Name = "lblLoginUser";
            lblLoginUser.Size = new Size(90, 18);
            lblLoginUser.TabIndex = 1;
            lblLoginUser.Text = "Username";
            // 
            // lblLoginPass
            // 
            lblLoginPass.Anchor = AnchorStyles.None;
            lblLoginPass.AutoSize = true;
            lblLoginPass.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginPass.ForeColor = Color.White;
            lblLoginPass.Location = new Point(90, 538);
            lblLoginPass.Name = "lblLoginPass";
            lblLoginPass.Size = new Size(87, 18);
            lblLoginPass.TabIndex = 2;
            lblLoginPass.Text = "Password";
            lblLoginPass.Click += labelPassword_Click;
            // 
            // txtLoginUser
            // 
            txtLoginUser.Anchor = AnchorStyles.None;
            txtLoginUser.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoginUser.Location = new Point(90, 496);
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.Size = new Size(300, 29);
            txtLoginUser.TabIndex = 3;
            txtLoginUser.TextChanged += txtUser_TextChanged;
            // 
            // txtLoginPass
            // 
            txtLoginPass.Anchor = AnchorStyles.None;
            txtLoginPass.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoginPass.Location = new Point(90, 559);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.PasswordChar = '*';
            txtLoginPass.Size = new Size(300, 29);
            txtLoginPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(235, 235, 235);
            btnLogin.Location = new Point(120, 630);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(240, 60);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblNewtoGhorKhata
            // 
            lblNewtoGhorKhata.Anchor = AnchorStyles.None;
            lblNewtoGhorKhata.AutoSize = true;
            lblNewtoGhorKhata.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewtoGhorKhata.ForeColor = Color.White;
            lblNewtoGhorKhata.Location = new Point(73, 724);
            lblNewtoGhorKhata.Name = "lblNewtoGhorKhata";
            lblNewtoGhorKhata.Size = new Size(334, 22);
            lblNewtoGhorKhata.TabIndex = 7;
            lblNewtoGhorKhata.Text = "New to GhorKhata?              Account\r\n";
            lblNewtoGhorKhata.Click += labelNewToGhorKhata_Click;
            // 
            // btnBack
            // 
            btnBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBack.BackColor = Color.FromArgb(60, 63, 65);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(235, 235, 235);
            btnBack.Location = new Point(30, 30);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.RightToLeft = RightToLeft.Yes;
            btnBack.Size = new Size(50, 30);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lbkCreate
            // 
            lbkCreate.ActiveLinkColor = Color.White;
            lbkCreate.Anchor = AnchorStyles.None;
            lbkCreate.AutoSize = true;
            lbkCreate.BackColor = Color.Transparent;
            lbkCreate.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbkCreate.LinkBehavior = LinkBehavior.HoverUnderline;
            lbkCreate.LinkColor = Color.FromArgb(40, 167, 69);
            lbkCreate.Location = new Point(254, 724);
            lbkCreate.Name = "lbkCreate";
            lbkCreate.Size = new Size(72, 22);
            lbkCreate.TabIndex = 10;
            lbkCreate.TabStop = true;
            lbkCreate.Text = "Create\r\n";
            lbkCreate.LinkClicked += linkLabelCreate_LinkClicked;
            // 
            // chkRemember
            // 
            chkRemember.Anchor = AnchorStyles.None;
            chkRemember.AutoSize = true;
            chkRemember.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRemember.ForeColor = Color.FromArgb(235, 235, 235);
            chkRemember.Location = new Point(90, 596);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(173, 18);
            chkRemember.TabIndex = 11;
            chkRemember.Text = "Remember me for 7 days";
            chkRemember.UseVisualStyleBackColor = true;
            chkRemember.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.None;
            pnlLogin.BackColor = Color.FromArgb(60, 63, 65);
            pnlLogin.Controls.Add(lnkForget);
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Controls.Add(lbkCreate);
            pnlLogin.Controls.Add(chkRemember);
            pnlLogin.Controls.Add(lblLoginUser);
            pnlLogin.Controls.Add(lblNewtoGhorKhata);
            pnlLogin.Controls.Add(txtLoginUser);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(lblLoginPass);
            pnlLogin.Controls.Add(txtLoginPass);
            pnlLogin.Location = new Point(310, 30);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(480, 800);
            pnlLogin.TabIndex = 12;
            pnlLogin.Paint += panel1_Paint;
            // 
            // lnkForget
            // 
            lnkForget.ActiveLinkColor = Color.White;
            lnkForget.Anchor = AnchorStyles.None;
            lnkForget.AutoSize = true;
            lnkForget.BackColor = Color.Transparent;
            lnkForget.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lnkForget.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkForget.LinkColor = Color.FromArgb(235, 235, 235);
            lnkForget.Location = new Point(276, 596);
            lnkForget.Name = "lnkForget";
            lnkForget.Size = new Size(114, 14);
            lnkForget.TabIndex = 12;
            lnkForget.TabStop = true;
            lnkForget.Text = "Forget Password?";
            // 
            // pnlRegistration
            // 
            pnlRegistration.Anchor = AnchorStyles.None;
            pnlRegistration.BackColor = Color.FromArgb(60, 63, 65);
            pnlRegistration.Controls.Add(lblGenderStatus);
            pnlRegistration.Controls.Add(lblDOBStatus);
            pnlRegistration.Controls.Add(lblEmailStatus);
            pnlRegistration.Controls.Add(lblRegUserStatus);
            pnlRegistration.Controls.Add(lblNameStatus);
            pnlRegistration.Controls.Add(lblConPassStatus);
            pnlRegistration.Controls.Add(lblPassStatus);
            pnlRegistration.Controls.Add(lnkLogin);
            pnlRegistration.Controls.Add(lblAlreadyhave);
            pnlRegistration.Controls.Add(lnkTerms);
            pnlRegistration.Controls.Add(chkTerms);
            pnlRegistration.Controls.Add(btnCreate);
            pnlRegistration.Controls.Add(txtRegPass);
            pnlRegistration.Controls.Add(txtRegConPass);
            pnlRegistration.Controls.Add(lblRegPass);
            pnlRegistration.Controls.Add(lblRegConPass);
            pnlRegistration.Controls.Add(lblGender);
            pnlRegistration.Controls.Add(cmbGender);
            pnlRegistration.Controls.Add(lblDOB);
            pnlRegistration.Controls.Add(dtpDOB);
            pnlRegistration.Controls.Add(txtRegEmail);
            pnlRegistration.Controls.Add(lblEmail);
            pnlRegistration.Controls.Add(txtRegUser);
            pnlRegistration.Controls.Add(lblRegUser);
            pnlRegistration.Controls.Add(txtRegName);
            pnlRegistration.Controls.Add(lblRegName);
            pnlRegistration.Controls.Add(lblRegistration);
            pnlRegistration.Location = new Point(795, 30);
            pnlRegistration.Name = "pnlRegistration";
            pnlRegistration.Size = new Size(480, 800);
            pnlRegistration.TabIndex = 13;
            pnlRegistration.Paint += panel2_Paint;
            // 
            // lblGenderStatus
            // 
            lblGenderStatus.Anchor = AnchorStyles.None;
            lblGenderStatus.AutoSize = true;
            lblGenderStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenderStatus.ForeColor = Color.Red;
            lblGenderStatus.Location = new Point(169, 404);
            lblGenderStatus.Name = "lblGenderStatus";
            lblGenderStatus.Size = new Size(37, 14);
            lblGenderStatus.TabIndex = 28;
            lblGenderStatus.Text = "Error";
            // 
            // lblDOBStatus
            // 
            lblDOBStatus.Anchor = AnchorStyles.None;
            lblDOBStatus.AutoSize = true;
            lblDOBStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOBStatus.ForeColor = Color.Red;
            lblDOBStatus.Location = new Point(209, 337);
            lblDOBStatus.Name = "lblDOBStatus";
            lblDOBStatus.Size = new Size(0, 14);
            lblDOBStatus.TabIndex = 27;
            lblDOBStatus.Click += lblDOBStatus_Click;
            // 
            // lblEmailStatus
            // 
            lblEmailStatus.Anchor = AnchorStyles.None;
            lblEmailStatus.AutoSize = true;
            lblEmailStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailStatus.ForeColor = Color.Red;
            lblEmailStatus.Location = new Point(90, 270);
            lblEmailStatus.Name = "lblEmailStatus";
            lblEmailStatus.Size = new Size(37, 14);
            lblEmailStatus.TabIndex = 26;
            lblEmailStatus.Text = "Error";
            lblEmailStatus.Click += lblEmailStatus_Click;
            // 
            // lblRegUserStatus
            // 
            lblRegUserStatus.Anchor = AnchorStyles.None;
            lblRegUserStatus.AutoSize = true;
            lblRegUserStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegUserStatus.ForeColor = Color.Red;
            lblRegUserStatus.Location = new Point(90, 203);
            lblRegUserStatus.Name = "lblRegUserStatus";
            lblRegUserStatus.Size = new Size(37, 14);
            lblRegUserStatus.TabIndex = 25;
            lblRegUserStatus.Text = "Error";
            lblRegUserStatus.Click += lblRegUserStatus_Click;
            // 
            // lblNameStatus
            // 
            lblNameStatus.Anchor = AnchorStyles.None;
            lblNameStatus.AutoSize = true;
            lblNameStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameStatus.ForeColor = Color.Red;
            lblNameStatus.Location = new Point(90, 136);
            lblNameStatus.Name = "lblNameStatus";
            lblNameStatus.Size = new Size(37, 14);
            lblNameStatus.TabIndex = 24;
            lblNameStatus.Text = "Error";
            lblNameStatus.Click += lblNameStatus_Click;
            // 
            // lblConPassStatus
            // 
            lblConPassStatus.Anchor = AnchorStyles.None;
            lblConPassStatus.AutoSize = true;
            lblConPassStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConPassStatus.ForeColor = Color.Red;
            lblConPassStatus.Location = new Point(90, 538);
            lblConPassStatus.Name = "lblConPassStatus";
            lblConPassStatus.Size = new Size(0, 14);
            lblConPassStatus.TabIndex = 23;
            // 
            // lblPassStatus
            // 
            lblPassStatus.Anchor = AnchorStyles.None;
            lblPassStatus.AutoSize = true;
            lblPassStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassStatus.ForeColor = Color.Red;
            lblPassStatus.Location = new Point(90, 471);
            lblPassStatus.Name = "lblPassStatus";
            lblPassStatus.Size = new Size(0, 14);
            lblPassStatus.TabIndex = 22;
            // 
            // lnkLogin
            // 
            lnkLogin.ActiveLinkColor = Color.White;
            lnkLogin.Anchor = AnchorStyles.None;
            lnkLogin.AutoSize = true;
            lnkLogin.BackColor = Color.Transparent;
            lnkLogin.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkLogin.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkLogin.LinkColor = Color.FromArgb(0, 122, 204);
            lnkLogin.Location = new Point(329, 724);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(60, 22);
            lnkLogin.TabIndex = 21;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Login";
            // 
            // lblAlreadyhave
            // 
            lblAlreadyhave.Anchor = AnchorStyles.None;
            lblAlreadyhave.AutoSize = true;
            lblAlreadyhave.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlreadyhave.ForeColor = Color.White;
            lblAlreadyhave.Location = new Point(91, 724);
            lblAlreadyhave.Name = "lblAlreadyhave";
            lblAlreadyhave.Size = new Size(245, 22);
            lblAlreadyhave.TabIndex = 20;
            lblAlreadyhave.Text = "Already have an account?";
            // 
            // lnkTerms
            // 
            lnkTerms.ActiveLinkColor = Color.White;
            lnkTerms.Anchor = AnchorStyles.None;
            lnkTerms.AutoSize = true;
            lnkTerms.BackColor = Color.Transparent;
            lnkTerms.Font = new Font("Arial Rounded MT Bold", 9F);
            lnkTerms.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkTerms.LinkColor = Color.DodgerBlue;
            lnkTerms.Location = new Point(185, 553);
            lnkTerms.Name = "lnkTerms";
            lnkTerms.Size = new Size(132, 14);
            lnkTerms.TabIndex = 19;
            lnkTerms.TabStop = true;
            lnkTerms.Text = "Terms and Conditins.";
            lnkTerms.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // chkTerms
            // 
            chkTerms.Anchor = AnchorStyles.None;
            chkTerms.AutoSize = true;
            chkTerms.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTerms.ForeColor = Color.FromArgb(235, 235, 235);
            chkTerms.Location = new Point(90, 552);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new Size(102, 18);
            chkTerms.TabIndex = 18;
            chkTerms.Text = "I agree to the";
            chkTerms.UseVisualStyleBackColor = true;
            chkTerms.CheckedChanged += chkTerms_CheckedChanged_1;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.None;
            btnCreate.BackColor = Color.FromArgb(40, 167, 69);
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.FromArgb(235, 235, 235);
            btnCreate.Location = new Point(119, 630);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(240, 60);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // txtRegPass
            // 
            txtRegPass.Anchor = AnchorStyles.None;
            txtRegPass.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegPass.Location = new Point(90, 439);
            txtRegPass.Name = "txtRegPass";
            txtRegPass.PasswordChar = '*';
            txtRegPass.Size = new Size(300, 29);
            txtRegPass.TabIndex = 16;
            txtRegPass.TextChanged += txtRegPass_TextChanged;
            // 
            // txtRegConPass
            // 
            txtRegConPass.Anchor = AnchorStyles.None;
            txtRegConPass.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegConPass.Location = new Point(90, 506);
            txtRegConPass.Name = "txtRegConPass";
            txtRegConPass.PasswordChar = '*';
            txtRegConPass.Size = new Size(300, 29);
            txtRegConPass.TabIndex = 15;
            txtRegConPass.TextChanged += txtRegConPass_TextChanged;
            // 
            // lblRegPass
            // 
            lblRegPass.Anchor = AnchorStyles.None;
            lblRegPass.AutoSize = true;
            lblRegPass.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegPass.ForeColor = Color.White;
            lblRegPass.Location = new Point(90, 418);
            lblRegPass.Name = "lblRegPass";
            lblRegPass.Size = new Size(87, 18);
            lblRegPass.TabIndex = 14;
            lblRegPass.Text = "Password";
            // 
            // lblRegConPass
            // 
            lblRegConPass.Anchor = AnchorStyles.None;
            lblRegConPass.AutoSize = true;
            lblRegConPass.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegConPass.ForeColor = Color.White;
            lblRegConPass.Location = new Point(90, 485);
            lblRegConPass.Name = "lblRegConPass";
            lblRegConPass.Size = new Size(153, 18);
            lblRegConPass.TabIndex = 13;
            lblRegConPass.Text = "Confirm Password";
            lblRegConPass.Click += lblRegConPass_Click;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.None;
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(90, 376);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(73, 18);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.Anchor = AnchorStyles.None;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(169, 372);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(221, 26);
            cmbGender.TabIndex = 11;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // lblDOB
            // 
            lblDOB.Anchor = AnchorStyles.None;
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.ForeColor = Color.White;
            lblDOB.Location = new Point(90, 311);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(113, 18);
            lblDOB.TabIndex = 10;
            lblDOB.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            dtpDOB.Anchor = AnchorStyles.None;
            dtpDOB.CustomFormat = "d MMM yyyy";
            dtpDOB.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.Location = new Point(209, 305);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(181, 26);
            dtpDOB.TabIndex = 9;
            dtpDOB.ValueChanged += dtpDob_ValueChanged;
            // 
            // txtRegEmail
            // 
            txtRegEmail.Anchor = AnchorStyles.None;
            txtRegEmail.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegEmail.Location = new Point(90, 238);
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.Size = new Size(300, 29);
            txtRegEmail.TabIndex = 8;
            txtRegEmail.TextChanged += txtRegEmail_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(90, 217);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 18);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtRegUser
            // 
            txtRegUser.Anchor = AnchorStyles.None;
            txtRegUser.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegUser.Location = new Point(90, 171);
            txtRegUser.Name = "txtRegUser";
            txtRegUser.Size = new Size(300, 29);
            txtRegUser.TabIndex = 6;
            txtRegUser.TextChanged += txtRegUser_TextChanged;
            // 
            // lblRegUser
            // 
            lblRegUser.Anchor = AnchorStyles.None;
            lblRegUser.AutoSize = true;
            lblRegUser.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegUser.ForeColor = Color.White;
            lblRegUser.Location = new Point(90, 150);
            lblRegUser.Name = "lblRegUser";
            lblRegUser.Size = new Size(90, 18);
            lblRegUser.TabIndex = 5;
            lblRegUser.Text = "Username";
            // 
            // txtRegName
            // 
            txtRegName.Anchor = AnchorStyles.None;
            txtRegName.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegName.Location = new Point(90, 104);
            txtRegName.Name = "txtRegName";
            txtRegName.Size = new Size(300, 29);
            txtRegName.TabIndex = 4;
            txtRegName.TextChanged += txtRegName_TextChanged;
            // 
            // lblRegName
            // 
            lblRegName.Anchor = AnchorStyles.None;
            lblRegName.AutoSize = true;
            lblRegName.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegName.ForeColor = Color.White;
            lblRegName.Location = new Point(90, 83);
            lblRegName.Name = "lblRegName";
            lblRegName.Size = new Size(54, 18);
            lblRegName.TabIndex = 2;
            lblRegName.Text = "Name";
            // 
            // lblRegistration
            // 
            lblRegistration.Anchor = AnchorStyles.Top;
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistration.ForeColor = Color.FromArgb(235, 235, 235);
            lblRegistration.Location = new Point(101, 13);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(295, 55);
            lblRegistration.TabIndex = 1;
            lblRegistration.Text = "Registraion";
            lblRegistration.Click += lblRegistration_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1584, 861);
            Controls.Add(pnlRegistration);
            Controls.Add(pnlLogin);
            Controls.Add(btnBack);
            Name = "LoginForm";
            Padding = new Padding(3, 0, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlRegistration.ResumeLayout(false);
            pnlRegistration.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblLoginUser;
        private Label labelLogin;
        private Label lblLoginPass;
        private TextBox txtLoginUser;
        private TextBox txtLoginPass;
        private Button btnLogin;
        private Label lblNewtoGhorKhata;
        private Button btnBack;
        private LinkLabel lbkCreate;
        private CheckBox chkRemember;
        private Panel pnlLogin;
        private Panel pnlRegistration;
        private Label lblRegUser;
        private TextBox txtRegName;
        private Label lblRegName;
        private Label lblConPassStatus;
        private DateTimePicker dtpDOB;
        private TextBox txtRegEmail;
        private Label lblEmail;
        private TextBox txtRegUser;
        private Label lblDOB;
        private ComboBox cmbGender;
        private Label lblGender;
        private TextBox txtRegPass;
        private TextBox txtRegConPass;
        private Label lblRegPass;
        private Label lblRegConPass;
        private Button btnCreate;
        private CheckBox chkTerms;
        private LinkLabel lnkTerms;
        private Label lblAlreadyhave;
        private LinkLabel lnkLogin;
        private LinkLabel linkLabel3;
        private LinkLabel lnkForget;
        private Label lblLogin;
        private Label lblRegistration;
        private Label lblPassStatus;
        private Label lblRegUserStatus;
        private Label lblNameStatus;
        private Label lblDOBStatus;
        private Label lblEmailStatus;
        private Label lblGenderStatus;
    }
}