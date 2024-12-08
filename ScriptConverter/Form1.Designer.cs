namespace ScriptConverter
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.grpPlatform = new System.Windows.Forms.GroupBox();
            this.rdo32bits = new System.Windows.Forms.RadioButton();
            this.rdo64bits = new System.Windows.Forms.RadioButton();
            this.rdoVbs = new System.Windows.Forms.RadioButton();
            this.rdoBat = new System.Windows.Forms.RadioButton();
            this.grpLanguage = new System.Windows.Forms.GroupBox();
            this.rdoPowershell = new System.Windows.Forms.RadioButton();
            this.chkRequestAdminPrivileges = new System.Windows.Forms.CheckBox();
            this.chkHideConsole = new System.Windows.Forms.CheckBox();
            this.chkDeleteAfterRun = new System.Windows.Forms.CheckBox();
            this.grpSecurity = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkEncryption = new System.Windows.Forms.CheckBox();
            this.chkAskForPassword = new System.Windows.Forms.CheckBox();
            this.grpFileInformation = new System.Windows.Forms.GroupBox();
            this.pnlFileInformation = new System.Windows.Forms.Panel();
            this.chkIcon = new System.Windows.Forms.CheckBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.btnIcon = new System.Windows.Forms.Button();
            this.chkTitle = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.chkDescription = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkFileVersion = new System.Windows.Forms.CheckBox();
            this.txtFileVersion = new System.Windows.Forms.TextBox();
            this.chkProductVersion = new System.Windows.Forms.CheckBox();
            this.txtProductVersion = new System.Windows.Forms.TextBox();
            this.chkProductName = new System.Windows.Forms.CheckBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.chkCompany = new System.Windows.Forms.CheckBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.chkCopyright = new System.Windows.Forms.CheckBox();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.chkTrademark = new System.Windows.Forms.CheckBox();
            this.txtTrademark = new System.Windows.Forms.TextBox();
            this.grpMiscellaneous = new System.Windows.Forms.GroupBox();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.btnOutputFile = new System.Windows.Forms.Button();
            this.grpPlatform.SuspendLayout();
            this.grpLanguage.SuspendLayout();
            this.grpSecurity.SuspendLayout();
            this.grpFileInformation.SuspendLayout();
            this.pnlFileInformation.SuspendLayout();
            this.grpMiscellaneous.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.AllowDrop = true;
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCode.Location = new System.Drawing.Point(260, 14);
            this.txtCode.Margin = new System.Windows.Forms.Padding(5);
            this.txtCode.MaxLength = 2147483647;
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(699, 469);
            this.txtCode.TabIndex = 0;
            this.txtCode.Text = "@echo off\r\n";
            this.txtCode.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtCode_DragDrop);
            this.txtCode.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtCode_DragEnter);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConvert.Location = new System.Drawing.Point(786, 487);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(5);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(173, 49);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // grpPlatform
            // 
            this.grpPlatform.Controls.Add(this.rdo32bits);
            this.grpPlatform.Controls.Add(this.rdo64bits);
            this.grpPlatform.ForeColor = System.Drawing.SystemColors.Control;
            this.grpPlatform.Location = new System.Drawing.Point(132, 14);
            this.grpPlatform.Name = "grpPlatform";
            this.grpPlatform.Size = new System.Drawing.Size(124, 121);
            this.grpPlatform.TabIndex = 43;
            this.grpPlatform.TabStop = false;
            this.grpPlatform.Text = "Platform";
            // 
            // rdo32bits
            // 
            this.rdo32bits.AutoSize = true;
            this.rdo32bits.Location = new System.Drawing.Point(11, 55);
            this.rdo32bits.Name = "rdo32bits";
            this.rdo32bits.Size = new System.Drawing.Size(75, 25);
            this.rdo32bits.TabIndex = 8;
            this.rdo32bits.TabStop = true;
            this.rdo32bits.Text = "32 bits";
            this.rdo32bits.UseVisualStyleBackColor = true;
            // 
            // rdo64bits
            // 
            this.rdo64bits.AutoSize = true;
            this.rdo64bits.Checked = true;
            this.rdo64bits.Location = new System.Drawing.Point(11, 24);
            this.rdo64bits.Name = "rdo64bits";
            this.rdo64bits.Size = new System.Drawing.Size(75, 25);
            this.rdo64bits.TabIndex = 7;
            this.rdo64bits.TabStop = true;
            this.rdo64bits.Text = "64 bits";
            this.rdo64bits.UseVisualStyleBackColor = true;
            // 
            // rdoVbs
            // 
            this.rdoVbs.AutoSize = true;
            this.rdoVbs.Location = new System.Drawing.Point(11, 55);
            this.rdoVbs.Name = "rdoVbs";
            this.rdoVbs.Size = new System.Drawing.Size(56, 25);
            this.rdoVbs.TabIndex = 5;
            this.rdoVbs.Text = "VBS";
            this.rdoVbs.UseVisualStyleBackColor = true;
            // 
            // rdoBat
            // 
            this.rdoBat.AutoSize = true;
            this.rdoBat.Checked = true;
            this.rdoBat.Location = new System.Drawing.Point(11, 24);
            this.rdoBat.Name = "rdoBat";
            this.rdoBat.Size = new System.Drawing.Size(50, 25);
            this.rdoBat.TabIndex = 4;
            this.rdoBat.TabStop = true;
            this.rdoBat.Text = "Bat";
            this.rdoBat.UseVisualStyleBackColor = true;
            // 
            // grpLanguage
            // 
            this.grpLanguage.Controls.Add(this.rdoPowershell);
            this.grpLanguage.Controls.Add(this.rdoVbs);
            this.grpLanguage.Controls.Add(this.rdoBat);
            this.grpLanguage.ForeColor = System.Drawing.SystemColors.Control;
            this.grpLanguage.Location = new System.Drawing.Point(4, 14);
            this.grpLanguage.Name = "grpLanguage";
            this.grpLanguage.Size = new System.Drawing.Size(125, 121);
            this.grpLanguage.TabIndex = 42;
            this.grpLanguage.TabStop = false;
            this.grpLanguage.Text = "Language";
            // 
            // rdoPowershell
            // 
            this.rdoPowershell.AutoSize = true;
            this.rdoPowershell.Location = new System.Drawing.Point(11, 86);
            this.rdoPowershell.Name = "rdoPowershell";
            this.rdoPowershell.Size = new System.Drawing.Size(103, 25);
            this.rdoPowershell.TabIndex = 6;
            this.rdoPowershell.Text = "Powershell";
            this.rdoPowershell.UseVisualStyleBackColor = true;
            // 
            // chkRequestAdminPrivileges
            // 
            this.chkRequestAdminPrivileges.AutoSize = true;
            this.chkRequestAdminPrivileges.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRequestAdminPrivileges.Location = new System.Drawing.Point(9, 28);
            this.chkRequestAdminPrivileges.Name = "chkRequestAdminPrivileges";
            this.chkRequestAdminPrivileges.Size = new System.Drawing.Size(206, 25);
            this.chkRequestAdminPrivileges.TabIndex = 9;
            this.chkRequestAdminPrivileges.Text = "Request Admin Privileges";
            this.chkRequestAdminPrivileges.UseVisualStyleBackColor = true;
            // 
            // chkHideConsole
            // 
            this.chkHideConsole.AutoSize = true;
            this.chkHideConsole.ForeColor = System.Drawing.SystemColors.Control;
            this.chkHideConsole.Location = new System.Drawing.Point(9, 59);
            this.chkHideConsole.Name = "chkHideConsole";
            this.chkHideConsole.Size = new System.Drawing.Size(118, 25);
            this.chkHideConsole.TabIndex = 10;
            this.chkHideConsole.Text = "Hide console";
            this.chkHideConsole.UseVisualStyleBackColor = true;
            // 
            // chkDeleteAfterRun
            // 
            this.chkDeleteAfterRun.AutoSize = true;
            this.chkDeleteAfterRun.ForeColor = System.Drawing.SystemColors.Control;
            this.chkDeleteAfterRun.Location = new System.Drawing.Point(9, 89);
            this.chkDeleteAfterRun.Name = "chkDeleteAfterRun";
            this.chkDeleteAfterRun.Size = new System.Drawing.Size(137, 25);
            this.chkDeleteAfterRun.TabIndex = 11;
            this.chkDeleteAfterRun.Text = "Delete after run";
            this.chkDeleteAfterRun.UseVisualStyleBackColor = true;
            // 
            // grpSecurity
            // 
            this.grpSecurity.Controls.Add(this.txtPassword);
            this.grpSecurity.Controls.Add(this.chkEncryption);
            this.grpSecurity.Controls.Add(this.chkAskForPassword);
            this.grpSecurity.ForeColor = System.Drawing.SystemColors.Control;
            this.grpSecurity.Location = new System.Drawing.Point(4, 267);
            this.grpSecurity.Name = "grpSecurity";
            this.grpSecurity.Size = new System.Drawing.Size(252, 115);
            this.grpSecurity.TabIndex = 45;
            this.grpSecurity.TabStop = false;
            this.grpSecurity.Text = "Security";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPassword.Location = new System.Drawing.Point(31, 59);
            this.txtPassword.MaxLength = 64;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(129, 22);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Text = "default";
            // 
            // chkEncryption
            // 
            this.chkEncryption.AutoSize = true;
            this.chkEncryption.Location = new System.Drawing.Point(11, 87);
            this.chkEncryption.Name = "chkEncryption";
            this.chkEncryption.Size = new System.Drawing.Size(153, 25);
            this.chkEncryption.TabIndex = 14;
            this.chkEncryption.Text = "Enable encryption";
            this.chkEncryption.UseVisualStyleBackColor = true;
            // 
            // chkAskForPassword
            // 
            this.chkAskForPassword.AutoSize = true;
            this.chkAskForPassword.Location = new System.Drawing.Point(11, 28);
            this.chkAskForPassword.Name = "chkAskForPassword";
            this.chkAskForPassword.Size = new System.Drawing.Size(149, 25);
            this.chkAskForPassword.TabIndex = 12;
            this.chkAskForPassword.Text = "Ask for password";
            this.chkAskForPassword.UseVisualStyleBackColor = true;
            // 
            // grpFileInformation
            // 
            this.grpFileInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpFileInformation.Controls.Add(this.pnlFileInformation);
            this.grpFileInformation.ForeColor = System.Drawing.SystemColors.Control;
            this.grpFileInformation.Location = new System.Drawing.Point(4, 388);
            this.grpFileInformation.Name = "grpFileInformation";
            this.grpFileInformation.Size = new System.Drawing.Size(252, 148);
            this.grpFileInformation.TabIndex = 46;
            this.grpFileInformation.TabStop = false;
            this.grpFileInformation.Text = "File Information";
            // 
            // pnlFileInformation
            // 
            this.pnlFileInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFileInformation.AutoScroll = true;
            this.pnlFileInformation.Controls.Add(this.chkIcon);
            this.pnlFileInformation.Controls.Add(this.txtIcon);
            this.pnlFileInformation.Controls.Add(this.btnIcon);
            this.pnlFileInformation.Controls.Add(this.chkTitle);
            this.pnlFileInformation.Controls.Add(this.txtTitle);
            this.pnlFileInformation.Controls.Add(this.chkDescription);
            this.pnlFileInformation.Controls.Add(this.txtDescription);
            this.pnlFileInformation.Controls.Add(this.chkFileVersion);
            this.pnlFileInformation.Controls.Add(this.txtFileVersion);
            this.pnlFileInformation.Controls.Add(this.chkProductVersion);
            this.pnlFileInformation.Controls.Add(this.txtProductVersion);
            this.pnlFileInformation.Controls.Add(this.chkProductName);
            this.pnlFileInformation.Controls.Add(this.txtProductName);
            this.pnlFileInformation.Controls.Add(this.chkCompany);
            this.pnlFileInformation.Controls.Add(this.txtCompany);
            this.pnlFileInformation.Controls.Add(this.chkCopyright);
            this.pnlFileInformation.Controls.Add(this.txtCopyright);
            this.pnlFileInformation.Controls.Add(this.chkTrademark);
            this.pnlFileInformation.Controls.Add(this.txtTrademark);
            this.pnlFileInformation.Location = new System.Drawing.Point(7, 21);
            this.pnlFileInformation.Name = "pnlFileInformation";
            this.pnlFileInformation.Size = new System.Drawing.Size(241, 121);
            this.pnlFileInformation.TabIndex = 0;
            // 
            // chkIcon
            // 
            this.chkIcon.AutoSize = true;
            this.chkIcon.Location = new System.Drawing.Point(4, 3);
            this.chkIcon.Name = "chkIcon";
            this.chkIcon.Size = new System.Drawing.Size(58, 25);
            this.chkIcon.TabIndex = 15;
            this.chkIcon.Text = "Icon";
            this.chkIcon.UseVisualStyleBackColor = true;
            // 
            // txtIcon
            // 
            this.txtIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtIcon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIcon.ForeColor = System.Drawing.SystemColors.Control;
            this.txtIcon.Location = new System.Drawing.Point(143, 5);
            this.txtIcon.MaxLength = 1024;
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(52, 22);
            this.txtIcon.TabIndex = 16;
            // 
            // btnIcon
            // 
            this.btnIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnIcon.FlatAppearance.BorderSize = 0;
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIcon.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIcon.Location = new System.Drawing.Point(197, 5);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(24, 22);
            this.btnIcon.TabIndex = 17;
            this.btnIcon.Text = "...";
            this.btnIcon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIcon.UseVisualStyleBackColor = false;
            this.btnIcon.Click += new System.EventHandler(this.BtnIcon_Click);
            // 
            // chkTitle
            // 
            this.chkTitle.AutoSize = true;
            this.chkTitle.Location = new System.Drawing.Point(4, 33);
            this.chkTitle.Name = "chkTitle";
            this.chkTitle.Size = new System.Drawing.Size(108, 25);
            this.chkTitle.TabIndex = 18;
            this.chkTitle.Text = "Description";
            this.chkTitle.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTitle.Location = new System.Drawing.Point(143, 35);
            this.txtTitle.MaxLength = 1024;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(78, 22);
            this.txtTitle.TabIndex = 19;
            // 
            // chkDescription
            // 
            this.chkDescription.AutoSize = true;
            this.chkDescription.Location = new System.Drawing.Point(4, 63);
            this.chkDescription.Name = "chkDescription";
            this.chkDescription.Size = new System.Drawing.Size(105, 25);
            this.chkDescription.TabIndex = 20;
            this.chkDescription.Text = "Comments";
            this.chkDescription.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDescription.Location = new System.Drawing.Point(143, 65);
            this.txtDescription.MaxLength = 1024;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(78, 22);
            this.txtDescription.TabIndex = 21;
            // 
            // chkFileVersion
            // 
            this.chkFileVersion.AutoSize = true;
            this.chkFileVersion.Location = new System.Drawing.Point(4, 93);
            this.chkFileVersion.Name = "chkFileVersion";
            this.chkFileVersion.Size = new System.Drawing.Size(109, 25);
            this.chkFileVersion.TabIndex = 22;
            this.chkFileVersion.Text = "File Version";
            this.chkFileVersion.UseVisualStyleBackColor = true;
            // 
            // txtFileVersion
            // 
            this.txtFileVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtFileVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileVersion.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFileVersion.Location = new System.Drawing.Point(143, 95);
            this.txtFileVersion.MaxLength = 1024;
            this.txtFileVersion.Name = "txtFileVersion";
            this.txtFileVersion.Size = new System.Drawing.Size(78, 22);
            this.txtFileVersion.TabIndex = 23;
            this.txtFileVersion.Text = "1.0.0.0";
            // 
            // chkProductVersion
            // 
            this.chkProductVersion.AutoSize = true;
            this.chkProductVersion.Location = new System.Drawing.Point(4, 123);
            this.chkProductVersion.Name = "chkProductVersion";
            this.chkProductVersion.Size = new System.Drawing.Size(139, 25);
            this.chkProductVersion.TabIndex = 24;
            this.chkProductVersion.Text = "Product Version";
            this.chkProductVersion.UseVisualStyleBackColor = true;
            // 
            // txtProductVersion
            // 
            this.txtProductVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtProductVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductVersion.ForeColor = System.Drawing.SystemColors.Control;
            this.txtProductVersion.Location = new System.Drawing.Point(143, 125);
            this.txtProductVersion.MaxLength = 1024;
            this.txtProductVersion.Name = "txtProductVersion";
            this.txtProductVersion.Size = new System.Drawing.Size(78, 22);
            this.txtProductVersion.TabIndex = 25;
            this.txtProductVersion.Text = "1.0.0.0";
            // 
            // chkProductName
            // 
            this.chkProductName.AutoSize = true;
            this.chkProductName.Location = new System.Drawing.Point(4, 153);
            this.chkProductName.Name = "chkProductName";
            this.chkProductName.Size = new System.Drawing.Size(129, 25);
            this.chkProductName.TabIndex = 26;
            this.chkProductName.Text = "Product Name";
            this.chkProductName.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtProductName.Location = new System.Drawing.Point(143, 155);
            this.txtProductName.MaxLength = 1024;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(78, 22);
            this.txtProductName.TabIndex = 27;
            // 
            // chkCompany
            // 
            this.chkCompany.AutoSize = true;
            this.chkCompany.Location = new System.Drawing.Point(4, 183);
            this.chkCompany.Name = "chkCompany";
            this.chkCompany.Size = new System.Drawing.Size(96, 25);
            this.chkCompany.TabIndex = 28;
            this.chkCompany.Text = "Company";
            this.chkCompany.UseVisualStyleBackColor = true;
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompany.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCompany.Location = new System.Drawing.Point(143, 185);
            this.txtCompany.MaxLength = 1024;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(78, 22);
            this.txtCompany.TabIndex = 29;
            // 
            // chkCopyright
            // 
            this.chkCopyright.AutoSize = true;
            this.chkCopyright.Location = new System.Drawing.Point(4, 213);
            this.chkCopyright.Name = "chkCopyright";
            this.chkCopyright.Size = new System.Drawing.Size(98, 25);
            this.chkCopyright.TabIndex = 30;
            this.chkCopyright.Text = "Copyright";
            this.chkCopyright.UseVisualStyleBackColor = true;
            // 
            // txtCopyright
            // 
            this.txtCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCopyright.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCopyright.Location = new System.Drawing.Point(143, 215);
            this.txtCopyright.MaxLength = 1024;
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(78, 22);
            this.txtCopyright.TabIndex = 31;
            // 
            // chkTrademark
            // 
            this.chkTrademark.AutoSize = true;
            this.chkTrademark.Location = new System.Drawing.Point(4, 243);
            this.chkTrademark.Name = "chkTrademark";
            this.chkTrademark.Size = new System.Drawing.Size(103, 25);
            this.chkTrademark.TabIndex = 32;
            this.chkTrademark.Text = "Trademark";
            this.chkTrademark.UseVisualStyleBackColor = true;
            // 
            // txtTrademark
            // 
            this.txtTrademark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtTrademark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrademark.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTrademark.Location = new System.Drawing.Point(143, 245);
            this.txtTrademark.MaxLength = 1024;
            this.txtTrademark.Name = "txtTrademark";
            this.txtTrademark.Size = new System.Drawing.Size(78, 22);
            this.txtTrademark.TabIndex = 33;
            // 
            // grpMiscellaneous
            // 
            this.grpMiscellaneous.Controls.Add(this.chkRequestAdminPrivileges);
            this.grpMiscellaneous.Controls.Add(this.chkHideConsole);
            this.grpMiscellaneous.Controls.Add(this.chkDeleteAfterRun);
            this.grpMiscellaneous.ForeColor = System.Drawing.SystemColors.Control;
            this.grpMiscellaneous.Location = new System.Drawing.Point(4, 141);
            this.grpMiscellaneous.Name = "grpMiscellaneous";
            this.grpMiscellaneous.Size = new System.Drawing.Size(252, 120);
            this.grpMiscellaneous.TabIndex = 44;
            this.grpMiscellaneous.TabStop = false;
            this.grpMiscellaneous.Text = "Miscellaneous";
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOutputFile.Location = new System.Drawing.Point(269, 514);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(90, 21);
            this.lblOutputFile.TabIndex = 47;
            this.lblOutputFile.Text = "Output File:";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOutputFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtOutputFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutputFile.ForeColor = System.Drawing.SystemColors.Control;
            this.txtOutputFile.Location = new System.Drawing.Point(371, 514);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(350, 22);
            this.txtOutputFile.TabIndex = 2;
            // 
            // btnOutputFile
            // 
            this.btnOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOutputFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnOutputFile.FlatAppearance.BorderSize = 0;
            this.btnOutputFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutputFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOutputFile.Location = new System.Drawing.Point(727, 514);
            this.btnOutputFile.Name = "btnOutputFile";
            this.btnOutputFile.Size = new System.Drawing.Size(24, 22);
            this.btnOutputFile.TabIndex = 3;
            this.btnOutputFile.Text = "...";
            this.btnOutputFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOutputFile.UseVisualStyleBackColor = false;
            this.btnOutputFile.Click += new System.EventHandler(this.BtnOutputFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(965, 542);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.btnOutputFile);
            this.Controls.Add(this.grpLanguage);
            this.Controls.Add(this.grpPlatform);
            this.Controls.Add(this.grpMiscellaneous);
            this.Controls.Add(this.grpSecurity);
            this.Controls.Add(this.grpFileInformation);
            this.Controls.Add(this.lblOutputFile);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(943, 179);
            this.Name = "Form1";
            this.Text = "Script Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPlatform.ResumeLayout(false);
            this.grpPlatform.PerformLayout();
            this.grpLanguage.ResumeLayout(false);
            this.grpLanguage.PerformLayout();
            this.grpSecurity.ResumeLayout(false);
            this.grpSecurity.PerformLayout();
            this.grpFileInformation.ResumeLayout(false);
            this.pnlFileInformation.ResumeLayout(false);
            this.pnlFileInformation.PerformLayout();
            this.grpMiscellaneous.ResumeLayout(false);
            this.grpMiscellaneous.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox grpPlatform;
        private System.Windows.Forms.RadioButton rdo32bits;
        private System.Windows.Forms.RadioButton rdo64bits;
        private System.Windows.Forms.RadioButton rdoVbs;
        private System.Windows.Forms.RadioButton rdoBat;
        private System.Windows.Forms.GroupBox grpLanguage;
        private System.Windows.Forms.RadioButton rdoPowershell;
        private System.Windows.Forms.CheckBox chkRequestAdminPrivileges;
        private System.Windows.Forms.CheckBox chkHideConsole;
        private System.Windows.Forms.CheckBox chkDeleteAfterRun;
        private System.Windows.Forms.GroupBox grpSecurity;
        private System.Windows.Forms.CheckBox chkAskForPassword;
        private System.Windows.Forms.CheckBox chkEncryption;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox grpFileInformation;
        private System.Windows.Forms.CheckBox chkIcon;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.GroupBox grpMiscellaneous;
        private System.Windows.Forms.CheckBox chkTitle;
        private System.Windows.Forms.CheckBox chkProductName;
        private System.Windows.Forms.CheckBox chkFileVersion;
        private System.Windows.Forms.CheckBox chkDescription;
        private System.Windows.Forms.CheckBox chkCompany;
        private System.Windows.Forms.CheckBox chkTrademark;
        private System.Windows.Forms.CheckBox chkCopyright;
        private System.Windows.Forms.TextBox txtTrademark;
        private System.Windows.Forms.TextBox txtCopyright;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtFileVersion;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.TextBox txtProductVersion;
        private System.Windows.Forms.CheckBox chkProductVersion;
        private System.Windows.Forms.Panel pnlFileInformation;
        private System.Windows.Forms.Label lblOutputFile;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Button btnOutputFile;
    }
}

