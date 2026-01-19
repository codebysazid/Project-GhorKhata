namespace GhorKhata
{
    partial class AuthForm
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
            components = new System.ComponentModel.Container();
            lblLogin = new Label();
            lblLoginUser = new Label();
            lblLoginPass = new Label();
            txtLoginUser = new TextBox();
            txtLoginPass = new TextBox();
            btnLogin = new Button();
            lblNewtoGhorKhata = new Label();
            lbkCreate = new LinkLabel();
            chkRemember = new CheckBox();
            pnlLogin = new Panel();
            label1 = new Label();
            lblLogPassStatus = new Label();
            lblLogUserStatus = new Label();
            lnkForget = new LinkLabel();
            pnlRegistration = new Panel();
            lblTermsStatus = new Label();
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
            pnlVarify = new Panel();
            btnVariX = new Button();
            btnVariSub = new Button();
            lnkResend = new LinkLabel();
            TxtCode = new TextBox();
            lnlMail = new Label();
            lnkvariChange = new LinkLabel();
            lblCodeSend = new Label();
            lblVari = new Label();
            pnlForget = new Panel();
            btnForgX = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtForPass = new TextBox();
            txtForConPass = new TextBox();
            lblForPass = new Label();
            lblForConPass = new Label();
            btnNext = new Button();
            txtForMail = new TextBox();
            lbldontWorry = new Label();
            lblForget = new Label();
            WelcomeTimer = new System.Windows.Forms.Timer(components);
            pnlWelcome = new Panel();
            btnEnter = new Button();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            pnlLogin.SuspendLayout();
            pnlRegistration.SuspendLayout();
            pnlVarify.SuspendLayout();
            pnlForget.SuspendLayout();
            pnlWelcome.SuspendLayout();
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
            lblLoginUser.Location = new Point(90, 418);
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
            lblLoginPass.Location = new Point(90, 485);
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
            txtLoginUser.Location = new Point(90, 439);
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.Size = new Size(300, 29);
            txtLoginUser.TabIndex = 3;
            txtLoginUser.TextChanged += txtUser_TextChanged;
            // 
            // txtLoginPass
            // 
            txtLoginPass.Anchor = AnchorStyles.None;
            txtLoginPass.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoginPass.Location = new Point(90, 506);
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
            btnLogin.Click += btnLogin_Click;
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
            chkRemember.Location = new Point(90, 552);
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
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(lblLogPassStatus);
            pnlLogin.Controls.Add(lblLogUserStatus);
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
            pnlLogin.Location = new Point(1519, 733);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(480, 800);
            pnlLogin.TabIndex = 12;
            pnlLogin.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 184);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 25;
            label1.Text = "label1";
            // 
            // lblLogPassStatus
            // 
            lblLogPassStatus.Anchor = AnchorStyles.None;
            lblLogPassStatus.AutoSize = true;
            lblLogPassStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogPassStatus.ForeColor = Color.Red;
            lblLogPassStatus.Location = new Point(90, 538);
            lblLogPassStatus.Name = "lblLogPassStatus";
            lblLogPassStatus.Size = new Size(107, 14);
            lblLogPassStatus.TabIndex = 24;
            lblLogPassStatus.Text = "Wrong password";
            // 
            // lblLogUserStatus
            // 
            lblLogUserStatus.Anchor = AnchorStyles.None;
            lblLogUserStatus.AutoSize = true;
            lblLogUserStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogUserStatus.ForeColor = Color.Red;
            lblLogUserStatus.Location = new Point(90, 471);
            lblLogUserStatus.Name = "lblLogUserStatus";
            lblLogUserStatus.Size = new Size(142, 14);
            lblLogUserStatus.TabIndex = 23;
            lblLogUserStatus.Text = "Username didn't match";
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
            lnkForget.Location = new Point(274, 553);
            lnkForget.Name = "lnkForget";
            lnkForget.Size = new Size(114, 14);
            lnkForget.TabIndex = 12;
            lnkForget.TabStop = true;
            lnkForget.Text = "Forget Password?";
            lnkForget.LinkClicked += lnkForget_LinkClicked;
            // 
            // pnlRegistration
            // 
            pnlRegistration.Anchor = AnchorStyles.None;
            pnlRegistration.BackColor = Color.FromArgb(60, 63, 65);
            pnlRegistration.Controls.Add(lblTermsStatus);
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
            pnlRegistration.Location = new Point(1028, 30);
            pnlRegistration.Name = "pnlRegistration";
            pnlRegistration.Size = new Size(480, 800);
            pnlRegistration.TabIndex = 13;
            pnlRegistration.Paint += panel2_Paint;
            // 
            // lblTermsStatus
            // 
            lblTermsStatus.Anchor = AnchorStyles.None;
            lblTermsStatus.AutoSize = true;
            lblTermsStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTermsStatus.ForeColor = Color.Red;
            lblTermsStatus.Location = new Point(90, 618);
            lblTermsStatus.Name = "lblTermsStatus";
            lblTermsStatus.Size = new Size(0, 14);
            lblTermsStatus.TabIndex = 29;
            // 
            // lblGenderStatus
            // 
            lblGenderStatus.Anchor = AnchorStyles.None;
            lblGenderStatus.AutoSize = true;
            lblGenderStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenderStatus.ForeColor = Color.Red;
            lblGenderStatus.Location = new Point(169, 446);
            lblGenderStatus.Name = "lblGenderStatus";
            lblGenderStatus.Size = new Size(0, 14);
            lblGenderStatus.TabIndex = 28;
            // 
            // lblDOBStatus
            // 
            lblDOBStatus.Anchor = AnchorStyles.None;
            lblDOBStatus.AutoSize = true;
            lblDOBStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOBStatus.ForeColor = Color.Red;
            lblDOBStatus.Location = new Point(209, 379);
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
            lblEmailStatus.Location = new Point(90, 312);
            lblEmailStatus.Name = "lblEmailStatus";
            lblEmailStatus.Size = new Size(0, 14);
            lblEmailStatus.TabIndex = 26;
            lblEmailStatus.Click += lblEmailStatus_Click;
            // 
            // lblRegUserStatus
            // 
            lblRegUserStatus.Anchor = AnchorStyles.None;
            lblRegUserStatus.AutoSize = true;
            lblRegUserStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegUserStatus.ForeColor = Color.Red;
            lblRegUserStatus.Location = new Point(90, 245);
            lblRegUserStatus.Name = "lblRegUserStatus";
            lblRegUserStatus.Size = new Size(0, 14);
            lblRegUserStatus.TabIndex = 25;
            lblRegUserStatus.Click += lblRegUserStatus_Click;
            // 
            // lblNameStatus
            // 
            lblNameStatus.Anchor = AnchorStyles.None;
            lblNameStatus.AutoSize = true;
            lblNameStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameStatus.ForeColor = Color.Red;
            lblNameStatus.Location = new Point(90, 178);
            lblNameStatus.Name = "lblNameStatus";
            lblNameStatus.Size = new Size(0, 14);
            lblNameStatus.TabIndex = 24;
            lblNameStatus.Click += lblNameStatus_Click;
            // 
            // lblConPassStatus
            // 
            lblConPassStatus.Anchor = AnchorStyles.None;
            lblConPassStatus.AutoSize = true;
            lblConPassStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConPassStatus.ForeColor = Color.Red;
            lblConPassStatus.Location = new Point(90, 580);
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
            lblPassStatus.Location = new Point(90, 513);
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
            lnkLogin.LinkClicked += lnkLogin_LinkClicked;
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
            lnkTerms.Location = new Point(185, 595);
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
            chkTerms.Location = new Point(90, 594);
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
            txtRegPass.Location = new Point(90, 481);
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
            txtRegConPass.Location = new Point(90, 548);
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
            lblRegPass.Location = new Point(90, 460);
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
            lblRegConPass.Location = new Point(90, 527);
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
            lblGender.Location = new Point(90, 418);
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
            cmbGender.Location = new Point(169, 414);
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
            lblDOB.Location = new Point(90, 353);
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
            dtpDOB.Location = new Point(209, 347);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(181, 26);
            dtpDOB.TabIndex = 9;
            dtpDOB.ValueChanged += dtpDob_ValueChanged;
            // 
            // txtRegEmail
            // 
            txtRegEmail.Anchor = AnchorStyles.None;
            txtRegEmail.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegEmail.Location = new Point(90, 280);
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
            lblEmail.Location = new Point(90, 259);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 18);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtRegUser
            // 
            txtRegUser.Anchor = AnchorStyles.None;
            txtRegUser.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegUser.Location = new Point(90, 213);
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
            lblRegUser.Location = new Point(90, 192);
            lblRegUser.Name = "lblRegUser";
            lblRegUser.Size = new Size(90, 18);
            lblRegUser.TabIndex = 5;
            lblRegUser.Text = "Username";
            // 
            // txtRegName
            // 
            txtRegName.Anchor = AnchorStyles.None;
            txtRegName.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegName.Location = new Point(90, 146);
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
            lblRegName.Location = new Point(90, 125);
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
            lblRegistration.Location = new Point(101, 30);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(295, 55);
            lblRegistration.TabIndex = 1;
            lblRegistration.Text = "Registraion";
            lblRegistration.Click += lblRegistration_Click;
            // 
            // pnlVarify
            // 
            pnlVarify.Anchor = AnchorStyles.None;
            pnlVarify.BackColor = Color.FromArgb(100, 103, 105);
            pnlVarify.Controls.Add(btnVariX);
            pnlVarify.Controls.Add(btnVariSub);
            pnlVarify.Controls.Add(lnkResend);
            pnlVarify.Controls.Add(TxtCode);
            pnlVarify.Controls.Add(lnlMail);
            pnlVarify.Controls.Add(lnkvariChange);
            pnlVarify.Controls.Add(lblCodeSend);
            pnlVarify.Controls.Add(lblVari);
            pnlVarify.Location = new Point(1543, 754);
            pnlVarify.Name = "pnlVarify";
            pnlVarify.Size = new Size(417, 260);
            pnlVarify.TabIndex = 14;
            // 
            // btnVariX
            // 
            btnVariX.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVariX.BackColor = Color.FromArgb(192, 0, 0);
            btnVariX.FlatStyle = FlatStyle.Popup;
            btnVariX.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVariX.ForeColor = Color.FromArgb(235, 235, 235);
            btnVariX.Location = new Point(378, 5);
            btnVariX.Margin = new Padding(0);
            btnVariX.Name = "btnVariX";
            btnVariX.RightToLeft = RightToLeft.Yes;
            btnVariX.Size = new Size(35, 35);
            btnVariX.TabIndex = 16;
            btnVariX.Text = "X";
            btnVariX.UseVisualStyleBackColor = false;
            btnVariX.Click += button1_Click_1;
            // 
            // btnVariSub
            // 
            btnVariSub.Anchor = AnchorStyles.None;
            btnVariSub.BackColor = Color.FromArgb(0, 122, 204);
            btnVariSub.FlatStyle = FlatStyle.Popup;
            btnVariSub.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVariSub.ForeColor = Color.FromArgb(235, 235, 235);
            btnVariSub.Location = new Point(124, 203);
            btnVariSub.Name = "btnVariSub";
            btnVariSub.Size = new Size(168, 42);
            btnVariSub.TabIndex = 5;
            btnVariSub.Text = "Submit";
            btnVariSub.UseVisualStyleBackColor = false;
            // 
            // lnkResend
            // 
            lnkResend.ActiveLinkColor = Color.White;
            lnkResend.Anchor = AnchorStyles.None;
            lnkResend.AutoSize = true;
            lnkResend.BackColor = Color.Transparent;
            lnkResend.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lnkResend.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkResend.LinkColor = Color.FromArgb(235, 235, 235);
            lnkResend.Location = new Point(162, 167);
            lnkResend.Name = "lnkResend";
            lnkResend.Size = new Size(93, 14);
            lnkResend.TabIndex = 13;
            lnkResend.TabStop = true;
            lnkResend.Text = "Resend Code?";
            // 
            // TxtCode
            // 
            TxtCode.Anchor = AnchorStyles.None;
            TxtCode.Font = new Font("Arial Rounded MT Bold", 14.25F);
            TxtCode.Location = new Point(144, 126);
            TxtCode.Name = "TxtCode";
            TxtCode.Size = new Size(129, 29);
            TxtCode.TabIndex = 13;
            // 
            // lnlMail
            // 
            lnlMail.Anchor = AnchorStyles.None;
            lnlMail.AutoSize = true;
            lnlMail.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnlMail.ForeColor = Color.White;
            lnlMail.Location = new Point(90, 72);
            lnlMail.Name = "lnlMail";
            lnlMail.Size = new Size(159, 18);
            lnlMail.TabIndex = 31;
            lnlMail.Text = "google@gmail.com";
            lnlMail.TextAlign = ContentAlignment.TopCenter;
            // 
            // lnkvariChange
            // 
            lnkvariChange.ActiveLinkColor = Color.White;
            lnkvariChange.Anchor = AnchorStyles.None;
            lnkvariChange.AutoSize = true;
            lnkvariChange.BackColor = Color.Transparent;
            lnkvariChange.Font = new Font("Arial Rounded MT Bold", 12F);
            lnkvariChange.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkvariChange.LinkColor = Color.FromArgb(0, 122, 204);
            lnkvariChange.Location = new Point(245, 72);
            lnkvariChange.Name = "lnkvariChange";
            lnkvariChange.Size = new Size(82, 18);
            lnkvariChange.TabIndex = 30;
            lnkvariChange.TabStop = true;
            lnkvariChange.Text = "(Change)";
            lnkvariChange.LinkClicked += linkLabel1_LinkClicked_2;
            // 
            // lblCodeSend
            // 
            lblCodeSend.Anchor = AnchorStyles.None;
            lblCodeSend.AutoSize = true;
            lblCodeSend.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodeSend.ForeColor = Color.White;
            lblCodeSend.Location = new Point(78, 54);
            lblCodeSend.Name = "lblCodeSend";
            lblCodeSend.Size = new Size(273, 54);
            lblCodeSend.TabIndex = 30;
            lblCodeSend.Text = "We've sent a 6-digit code to\r\n\r\nPlease enter it below to continue.";
            lblCodeSend.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblVari
            // 
            lblVari.Anchor = AnchorStyles.None;
            lblVari.AutoSize = true;
            lblVari.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVari.ForeColor = Color.White;
            lblVari.Location = new Point(151, 8);
            lblVari.Name = "lblVari";
            lblVari.Size = new Size(114, 22);
            lblVari.TabIndex = 30;
            lblVari.Text = "Varification";
            lblVari.Click += lblVari_Click;
            // 
            // pnlForget
            // 
            pnlForget.Anchor = AnchorStyles.None;
            pnlForget.BackColor = Color.FromArgb(80, 83, 85);
            pnlForget.Controls.Add(btnForgX);
            pnlForget.Controls.Add(label3);
            pnlForget.Controls.Add(label4);
            pnlForget.Controls.Add(label5);
            pnlForget.Controls.Add(txtForPass);
            pnlForget.Controls.Add(txtForConPass);
            pnlForget.Controls.Add(lblForPass);
            pnlForget.Controls.Add(lblForConPass);
            pnlForget.Controls.Add(btnNext);
            pnlForget.Controls.Add(txtForMail);
            pnlForget.Controls.Add(lbldontWorry);
            pnlForget.Controls.Add(lblForget);
            pnlForget.Location = new Point(1547, 754);
            pnlForget.Name = "pnlForget";
            pnlForget.Size = new Size(417, 530);
            pnlForget.TabIndex = 15;
            pnlForget.Paint += pnlForget_Paint;
            // 
            // btnForgX
            // 
            btnForgX.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnForgX.BackColor = Color.FromArgb(192, 0, 0);
            btnForgX.FlatStyle = FlatStyle.Popup;
            btnForgX.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnForgX.ForeColor = Color.FromArgb(235, 235, 235);
            btnForgX.Location = new Point(378, 5);
            btnForgX.Margin = new Padding(0);
            btnForgX.Name = "btnForgX";
            btnForgX.RightToLeft = RightToLeft.Yes;
            btnForgX.Size = new Size(35, 35);
            btnForgX.TabIndex = 42;
            btnForgX.Text = "X";
            btnForgX.UseVisualStyleBackColor = false;
            btnForgX.Click += BtnBack_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(137, 263);
            label3.Name = "label3";
            label3.Size = new Size(0, 14);
            label3.TabIndex = 41;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(58, 397);
            label4.Name = "label4";
            label4.Size = new Size(0, 14);
            label4.TabIndex = 40;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(58, 330);
            label5.Name = "label5";
            label5.Size = new Size(0, 14);
            label5.TabIndex = 39;
            // 
            // txtForPass
            // 
            txtForPass.Anchor = AnchorStyles.None;
            txtForPass.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtForPass.Location = new Point(58, 298);
            txtForPass.Name = "txtForPass";
            txtForPass.PasswordChar = '*';
            txtForPass.Size = new Size(300, 29);
            txtForPass.TabIndex = 38;
            // 
            // txtForConPass
            // 
            txtForConPass.Anchor = AnchorStyles.None;
            txtForConPass.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtForConPass.Location = new Point(58, 365);
            txtForConPass.Name = "txtForConPass";
            txtForConPass.PasswordChar = '*';
            txtForConPass.Size = new Size(300, 29);
            txtForConPass.TabIndex = 37;
            // 
            // lblForPass
            // 
            lblForPass.Anchor = AnchorStyles.None;
            lblForPass.AutoSize = true;
            lblForPass.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForPass.ForeColor = Color.White;
            lblForPass.Location = new Point(58, 277);
            lblForPass.Name = "lblForPass";
            lblForPass.Size = new Size(87, 18);
            lblForPass.TabIndex = 36;
            lblForPass.Text = "Password";
            // 
            // lblForConPass
            // 
            lblForConPass.Anchor = AnchorStyles.None;
            lblForConPass.AutoSize = true;
            lblForConPass.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForConPass.ForeColor = Color.White;
            lblForConPass.Location = new Point(58, 344);
            lblForConPass.Name = "lblForConPass";
            lblForConPass.Size = new Size(153, 18);
            lblForConPass.TabIndex = 35;
            lblForConPass.Text = "Confirm Password";
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = Color.FromArgb(40, 167, 69);
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.FromArgb(235, 235, 235);
            btnNext.Location = new Point(124, 474);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(168, 42);
            btnNext.TabIndex = 34;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += button1_Click;
            // 
            // txtForMail
            // 
            txtForMail.Anchor = AnchorStyles.None;
            txtForMail.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtForMail.Location = new Point(58, 228);
            txtForMail.Name = "txtForMail";
            txtForMail.Size = new Size(300, 29);
            txtForMail.TabIndex = 33;
            // 
            // lbldontWorry
            // 
            lbldontWorry.Anchor = AnchorStyles.None;
            lbldontWorry.AutoSize = true;
            lbldontWorry.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldontWorry.ForeColor = Color.White;
            lbldontWorry.Location = new Point(16, 161);
            lbldontWorry.Name = "lbldontWorry";
            lbldontWorry.Size = new Size(385, 54);
            lbldontWorry.TabIndex = 32;
            lbldontWorry.Text = "Don't worry! We'll help you reset your password\r\n\r\nEnter your email address";
            lbldontWorry.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblForget
            // 
            lblForget.Anchor = AnchorStyles.None;
            lblForget.AutoSize = true;
            lblForget.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForget.ForeColor = Color.White;
            lblForget.Location = new Point(126, 8);
            lblForget.Name = "lblForget";
            lblForget.Size = new Size(165, 22);
            lblForget.TabIndex = 31;
            lblForget.Text = "Forget Password";
            // 
            // WelcomeTimer
            // 
            WelcomeTimer.Interval = 10;
            WelcomeTimer.Tick += WelcomeTimer_Tick;
            // 
            // pnlWelcome
            // 
            pnlWelcome.Anchor = AnchorStyles.None;
            pnlWelcome.BackColor = Color.FromArgb(60, 63, 65);
            pnlWelcome.Controls.Add(btnEnter);
            pnlWelcome.Controls.Add(label7);
            pnlWelcome.Controls.Add(label6);
            pnlWelcome.Controls.Add(label2);
            pnlWelcome.Location = new Point(107, 30);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(900, 800);
            pnlWelcome.TabIndex = 16;
            // 
            // btnEnter
            // 
            btnEnter.Anchor = AnchorStyles.None;
            btnEnter.BackColor = Color.FromArgb(40, 167, 69);
            btnEnter.FlatStyle = FlatStyle.Popup;
            btnEnter.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.FromArgb(235, 235, 235);
            btnEnter.Location = new Point(330, 630);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(240, 60);
            btnEnter.TabIndex = 18;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(235, 235, 235);
            label7.Location = new Point(179, 438);
            label7.Name = "label7";
            label7.Size = new Size(542, 140);
            label7.TabIndex = 4;
            label7.Text = "Your complete household financial companion\r\nEasily track expenses\r\nManage meals\r\n Keep everyone in sync\r\nAll in one simple application";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(235, 235, 235);
            label6.Location = new Point(290, 97);
            label6.Name = "label6";
            label6.Size = new Size(320, 22);
            label6.TabIndex = 3;
            label6.Text = "Smart Household, Smart Finances";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(235, 235, 235);
            label2.Location = new Point(160, 30);
            label2.Name = "label2";
            label2.Size = new Size(580, 55);
            label2.TabIndex = 2;
            label2.Text = "Welcome To GhorKhata";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1584, 861);
            Controls.Add(pnlWelcome);
            Controls.Add(pnlForget);
            Controls.Add(pnlVarify);
            Controls.Add(pnlRegistration);
            Controls.Add(pnlLogin);
            Name = "AuthForm";
            Padding = new Padding(3, 0, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlRegistration.ResumeLayout(false);
            pnlRegistration.PerformLayout();
            pnlVarify.ResumeLayout(false);
            pnlVarify.PerformLayout();
            pnlForget.ResumeLayout(false);
            pnlForget.PerformLayout();
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
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
        private Label lblTermsStatus;
        private Panel pnlVarify;
        private Panel pnlForget;
        private Label lblVari;
        private Label lblCodeSend;
        private Label lnlMail;
        private LinkLabel lnkvariChange;
        private LinkLabel lnkResend;
        private TextBox TxtCode;
        private Button btnVariSub;
        private Label lbldontWorry;
        private Label lblForget;
        private Button btnNext;
        private TextBox txtForMail;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtForPass;
        private TextBox txtForConPass;
        private Label lblForPass;
        private Label lblForConPass;
        private Label lblLogPassStatus;
        private Label lblLogUserStatus;
        private Button btnVariX;
        private Button btnForgX;
        private System.Windows.Forms.Timer WelcomeTimer;
        private Label label1;
        private Panel pnlWelcome;
        private Label label2;
        private Label label7;
        private Label label6;
        private Button btnEnter;
    }
}