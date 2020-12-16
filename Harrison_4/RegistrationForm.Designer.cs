namespace Harrison_4
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.theaterPictureBox = new System.Windows.Forms.PictureBox();
            this.hopkinsLabel = new System.Windows.Forms.Label();
            this.registrationDateLabel = new System.Windows.Forms.Label();
            this.registrationDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.registrantGroupBox = new System.Windows.Forms.GroupBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dateOfBirthMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.registrationGroupBox = new System.Windows.Forms.GroupBox();
            this.totalRegistrationPriceLabel = new System.Windows.Forms.Label();
            this.totalRegistrationPriceDescriptionLabel = new System.Windows.Forms.Label();
            this.dividerGroupBox = new System.Windows.Forms.GroupBox();
            this.pricePerClassLabel = new System.Windows.Forms.Label();
            this.pricePerClassDescriptionLabel = new System.Windows.Forms.Label();
            this.numberOfClassesLabel = new System.Windows.Forms.Label();
            this.numberOfClassesDescriptionLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.classesLabel = new System.Windows.Forms.Label();
            this.animationRadioButton = new System.Windows.Forms.RadioButton();
            this.liveActionRadioButton = new System.Windows.Forms.RadioButton();
            this.classLabel = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.emailReceiptCheckBox = new System.Windows.Forms.CheckBox();
            this.registrationFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationFormMenuItemToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.theaterPictureBox)).BeginInit();
            this.registrantGroupBox.SuspendLayout();
            this.registrationGroupBox.SuspendLayout();
            this.registrationFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // theaterPictureBox
            // 
            this.theaterPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.theaterPictureBox.Image = global::Harrison_4.Properties.Resources.theater;
            this.theaterPictureBox.Location = new System.Drawing.Point(107, 44);
            this.theaterPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.theaterPictureBox.Name = "theaterPictureBox";
            this.theaterPictureBox.Size = new System.Drawing.Size(178, 105);
            this.theaterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.theaterPictureBox.TabIndex = 0;
            this.theaterPictureBox.TabStop = false;
            // 
            // hopkinsLabel
            // 
            this.hopkinsLabel.BackColor = System.Drawing.Color.White;
            this.hopkinsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hopkinsLabel.Font = new System.Drawing.Font("Broadway", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopkinsLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.hopkinsLabel.Location = new System.Drawing.Point(347, 86);
            this.hopkinsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hopkinsLabel.Name = "hopkinsLabel";
            this.hopkinsLabel.Size = new System.Drawing.Size(246, 64);
            this.hopkinsLabel.TabIndex = 1;
            this.hopkinsLabel.Text = "Hopkins Film School";
            this.hopkinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registrationDateLabel
            // 
            this.registrationDateLabel.Location = new System.Drawing.Point(213, 182);
            this.registrationDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registrationDateLabel.Name = "registrationDateLabel";
            this.registrationDateLabel.Size = new System.Drawing.Size(125, 20);
            this.registrationDateLabel.TabIndex = 2;
            this.registrationDateLabel.Text = "Registration Date:";
            this.registrationDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // registrationDateMaskedTextBox
            // 
            this.registrationDateMaskedTextBox.AllowDrop = true;
            this.registrationDateMaskedTextBox.Location = new System.Drawing.Point(347, 181);
            this.registrationDateMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.registrationDateMaskedTextBox.Mask = "00/00/0000";
            this.registrationDateMaskedTextBox.Name = "registrationDateMaskedTextBox";
            this.registrationDateMaskedTextBox.Size = new System.Drawing.Size(91, 22);
            this.registrationDateMaskedTextBox.TabIndex = 3;
            this.registrationDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // registrantGroupBox
            // 
            this.registrantGroupBox.Controls.Add(this.statusComboBox);
            this.registrantGroupBox.Controls.Add(this.statusLabel);
            this.registrantGroupBox.Controls.Add(this.dateOfBirthMaskedTextBox);
            this.registrantGroupBox.Controls.Add(this.dateOfBirthLabel);
            this.registrantGroupBox.Controls.Add(this.emailTextBox);
            this.registrantGroupBox.Controls.Add(this.emailLabel);
            this.registrantGroupBox.Controls.Add(this.lastNameTextBox);
            this.registrantGroupBox.Controls.Add(this.lastNameLabel);
            this.registrantGroupBox.Controls.Add(this.firstNameTextBox);
            this.registrantGroupBox.Controls.Add(this.firstNameLabel);
            this.registrantGroupBox.Location = new System.Drawing.Point(16, 220);
            this.registrantGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.registrantGroupBox.Name = "registrantGroupBox";
            this.registrantGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.registrantGroupBox.Size = new System.Drawing.Size(636, 186);
            this.registrantGroupBox.TabIndex = 4;
            this.registrantGroupBox.TabStop = false;
            this.registrantGroupBox.Text = "Registrant Information";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(444, 31);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(145, 24);
            this.statusComboBox.TabIndex = 9;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(308, 32);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(127, 20);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Registrant Status:";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateOfBirthMaskedTextBox
            // 
            this.dateOfBirthMaskedTextBox.Location = new System.Drawing.Point(124, 149);
            this.dateOfBirthMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateOfBirthMaskedTextBox.Mask = "00/00/0000";
            this.dateOfBirthMaskedTextBox.Name = "dateOfBirthMaskedTextBox";
            this.dateOfBirthMaskedTextBox.Size = new System.Drawing.Size(91, 22);
            this.dateOfBirthMaskedTextBox.TabIndex = 7;
            this.dateOfBirthMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.Location = new System.Drawing.Point(8, 150);
            this.dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(108, 20);
            this.dateOfBirthLabel.TabIndex = 6;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            this.dateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(124, 110);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(197, 22);
            this.emailTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(65, 111);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 20);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(124, 70);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(167, 22);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(29, 71);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(87, 20);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(124, 31);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(144, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(25, 32);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(91, 20);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // registrationGroupBox
            // 
            this.registrationGroupBox.Controls.Add(this.totalRegistrationPriceLabel);
            this.registrationGroupBox.Controls.Add(this.totalRegistrationPriceDescriptionLabel);
            this.registrationGroupBox.Controls.Add(this.dividerGroupBox);
            this.registrationGroupBox.Controls.Add(this.pricePerClassLabel);
            this.registrationGroupBox.Controls.Add(this.pricePerClassDescriptionLabel);
            this.registrationGroupBox.Controls.Add(this.numberOfClassesLabel);
            this.registrationGroupBox.Controls.Add(this.numberOfClassesDescriptionLabel);
            this.registrationGroupBox.Controls.Add(this.noteLabel);
            this.registrationGroupBox.Controls.Add(this.classesListBox);
            this.registrationGroupBox.Controls.Add(this.classesLabel);
            this.registrationGroupBox.Controls.Add(this.animationRadioButton);
            this.registrationGroupBox.Controls.Add(this.liveActionRadioButton);
            this.registrationGroupBox.Controls.Add(this.classLabel);
            this.registrationGroupBox.Location = new System.Drawing.Point(16, 414);
            this.registrationGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.registrationGroupBox.Name = "registrationGroupBox";
            this.registrationGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.registrationGroupBox.Size = new System.Drawing.Size(636, 315);
            this.registrationGroupBox.TabIndex = 5;
            this.registrationGroupBox.TabStop = false;
            this.registrationGroupBox.Text = "Registration Information";
            // 
            // totalRegistrationPriceLabel
            // 
            this.totalRegistrationPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRegistrationPriceLabel.Location = new System.Drawing.Point(444, 273);
            this.totalRegistrationPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalRegistrationPriceLabel.Name = "totalRegistrationPriceLabel";
            this.totalRegistrationPriceLabel.Size = new System.Drawing.Size(110, 28);
            this.totalRegistrationPriceLabel.TabIndex = 12;
            this.totalRegistrationPriceLabel.Text = "PRICE";
            this.totalRegistrationPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalRegistrationPriceDescriptionLabel
            // 
            this.totalRegistrationPriceDescriptionLabel.Location = new System.Drawing.Point(271, 277);
            this.totalRegistrationPriceDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalRegistrationPriceDescriptionLabel.Name = "totalRegistrationPriceDescriptionLabel";
            this.totalRegistrationPriceDescriptionLabel.Size = new System.Drawing.Size(161, 20);
            this.totalRegistrationPriceDescriptionLabel.TabIndex = 11;
            this.totalRegistrationPriceDescriptionLabel.Text = "Total Registration Price:";
            this.totalRegistrationPriceDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dividerGroupBox
            // 
            this.dividerGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dividerGroupBox.Location = new System.Drawing.Point(444, 255);
            this.dividerGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.dividerGroupBox.Name = "dividerGroupBox";
            this.dividerGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.dividerGroupBox.Size = new System.Drawing.Size(111, 4);
            this.dividerGroupBox.TabIndex = 10;
            this.dividerGroupBox.TabStop = false;
            // 
            // pricePerClassLabel
            // 
            this.pricePerClassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricePerClassLabel.Location = new System.Drawing.Point(444, 210);
            this.pricePerClassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pricePerClassLabel.Name = "pricePerClassLabel";
            this.pricePerClassLabel.Size = new System.Drawing.Size(110, 28);
            this.pricePerClassLabel.TabIndex = 9;
            this.pricePerClassLabel.Text = "PRICE";
            this.pricePerClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pricePerClassDescriptionLabel
            // 
            this.pricePerClassDescriptionLabel.Location = new System.Drawing.Point(325, 214);
            this.pricePerClassDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pricePerClassDescriptionLabel.Name = "pricePerClassDescriptionLabel";
            this.pricePerClassDescriptionLabel.Size = new System.Drawing.Size(107, 20);
            this.pricePerClassDescriptionLabel.TabIndex = 8;
            this.pricePerClassDescriptionLabel.Text = "Price per Class:";
            this.pricePerClassDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberOfClassesLabel
            // 
            this.numberOfClassesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfClassesLabel.Location = new System.Drawing.Point(444, 170);
            this.numberOfClassesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberOfClassesLabel.Name = "numberOfClassesLabel";
            this.numberOfClassesLabel.Size = new System.Drawing.Size(110, 28);
            this.numberOfClassesLabel.TabIndex = 7;
            this.numberOfClassesLabel.Text = "NUMBER";
            this.numberOfClassesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberOfClassesDescriptionLabel
            // 
            this.numberOfClassesDescriptionLabel.Location = new System.Drawing.Point(233, 174);
            this.numberOfClassesDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberOfClassesDescriptionLabel.Name = "numberOfClassesDescriptionLabel";
            this.numberOfClassesDescriptionLabel.Size = new System.Drawing.Size(199, 20);
            this.numberOfClassesDescriptionLabel.TabIndex = 6;
            this.numberOfClassesDescriptionLabel.Text = "Number of Selected Classes:";
            this.numberOfClassesDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // noteLabel
            // 
            this.noteLabel.Location = new System.Drawing.Point(340, 53);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(92, 20);
            this.noteLabel.TabIndex = 5;
            this.noteLabel.Text = "NOTE";
            this.noteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // classesListBox
            // 
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.ItemHeight = 16;
            this.classesListBox.Location = new System.Drawing.Point(444, 33);
            this.classesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.Size = new System.Drawing.Size(145, 116);
            this.classesListBox.TabIndex = 4;
            this.classesListBox.SelectedIndexChanged += new System.EventHandler(this.classesListBox_SelectedIndexChanged);
            // 
            // classesLabel
            // 
            this.classesLabel.Location = new System.Drawing.Point(371, 33);
            this.classesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classesLabel.Name = "classesLabel";
            this.classesLabel.Size = new System.Drawing.Size(61, 20);
            this.classesLabel.TabIndex = 3;
            this.classesLabel.Text = "Classes:";
            this.classesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // animationRadioButton
            // 
            this.animationRadioButton.AutoSize = true;
            this.animationRadioButton.Location = new System.Drawing.Point(124, 69);
            this.animationRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.animationRadioButton.Name = "animationRadioButton";
            this.animationRadioButton.Size = new System.Drawing.Size(91, 21);
            this.animationRadioButton.TabIndex = 2;
            this.animationRadioButton.Text = "Animation";
            this.animationRadioButton.UseVisualStyleBackColor = true;
            this.animationRadioButton.CheckedChanged += new System.EventHandler(this.animationRadioButton_CheckedChanged);
            // 
            // liveActionRadioButton
            // 
            this.liveActionRadioButton.AutoSize = true;
            this.liveActionRadioButton.Checked = true;
            this.liveActionRadioButton.Location = new System.Drawing.Point(124, 33);
            this.liveActionRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.liveActionRadioButton.Name = "liveActionRadioButton";
            this.liveActionRadioButton.Size = new System.Drawing.Size(98, 21);
            this.liveActionRadioButton.TabIndex = 1;
            this.liveActionRadioButton.TabStop = true;
            this.liveActionRadioButton.Text = "Live Action";
            this.liveActionRadioButton.UseVisualStyleBackColor = true;
            // 
            // classLabel
            // 
            this.classLabel.Location = new System.Drawing.Point(69, 33);
            this.classLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(47, 20);
            this.classLabel.TabIndex = 0;
            this.classLabel.Text = "Class:";
            this.classLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.Location = new System.Drawing.Point(335, 747);
            this.paymentTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(108, 20);
            this.paymentTypeLabel.TabIndex = 6;
            this.paymentTypeLabel.Text = "Payment Type:";
            this.paymentTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Checked = true;
            this.cashRadioButton.Location = new System.Drawing.Point(460, 747);
            this.cashRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(61, 21);
            this.cashRadioButton.TabIndex = 7;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Location = new System.Drawing.Point(460, 783);
            this.checkRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(68, 21);
            this.checkRadioButton.TabIndex = 8;
            this.checkRadioButton.Text = "Check";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            this.checkRadioButton.CheckedChanged += new System.EventHandler(this.checkRadioButton_CheckedChanged);
            // 
            // emailReceiptCheckBox
            // 
            this.emailReceiptCheckBox.AutoSize = true;
            this.emailReceiptCheckBox.Location = new System.Drawing.Point(460, 822);
            this.emailReceiptCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailReceiptCheckBox.Name = "emailReceiptCheckBox";
            this.emailReceiptCheckBox.Size = new System.Drawing.Size(189, 21);
            this.emailReceiptCheckBox.TabIndex = 9;
            this.emailReceiptCheckBox.Text = "Email Receipt Requested";
            this.emailReceiptCheckBox.UseVisualStyleBackColor = true;
            this.emailReceiptCheckBox.CheckedChanged += new System.EventHandler(this.emailReceiptCheckBox_CheckedChanged);
            // 
            // registrationFormMenuStrip
            // 
            this.registrationFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.registrationFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.registrationFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.registrationFormMenuStrip.Name = "registrationFormMenuStrip";
            this.registrationFormMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.registrationFormMenuStrip.Size = new System.Drawing.Size(668, 28);
            this.registrationFormMenuStrip.TabIndex = 0;
            this.registrationFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.ToolTipText = "Click to save registration ";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.clearToolStripMenuItem.Text = "Clea&r";
            this.clearToolStripMenuItem.ToolTipText = "Click to clear registration ";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.ToolTipText = "Click to exit registration";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.ToolTipText = "Click for application information";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 859);
            this.Controls.Add(this.emailReceiptCheckBox);
            this.Controls.Add(this.checkRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.registrationGroupBox);
            this.Controls.Add(this.registrantGroupBox);
            this.Controls.Add(this.registrationDateMaskedTextBox);
            this.Controls.Add(this.registrationDateLabel);
            this.Controls.Add(this.hopkinsLabel);
            this.Controls.Add(this.theaterPictureBox);
            this.Controls.Add(this.registrationFormMenuStrip);
            this.MainMenuStrip = this.registrationFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hopkins Film School Registration Entry";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theaterPictureBox)).EndInit();
            this.registrantGroupBox.ResumeLayout(false);
            this.registrantGroupBox.PerformLayout();
            this.registrationGroupBox.ResumeLayout(false);
            this.registrationGroupBox.PerformLayout();
            this.registrationFormMenuStrip.ResumeLayout(false);
            this.registrationFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox theaterPictureBox;
        private System.Windows.Forms.Label hopkinsLabel;
        private System.Windows.Forms.Label registrationDateLabel;
        private System.Windows.Forms.MaskedTextBox registrationDateMaskedTextBox;
        private System.Windows.Forms.GroupBox registrantGroupBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.MaskedTextBox dateOfBirthMaskedTextBox;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox registrationGroupBox;
        private System.Windows.Forms.GroupBox dividerGroupBox;
        private System.Windows.Forms.Label pricePerClassLabel;
        private System.Windows.Forms.Label pricePerClassDescriptionLabel;
        private System.Windows.Forms.Label numberOfClassesLabel;
        private System.Windows.Forms.Label numberOfClassesDescriptionLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.ListBox classesListBox;
        private System.Windows.Forms.Label classesLabel;
        private System.Windows.Forms.RadioButton animationRadioButton;
        private System.Windows.Forms.RadioButton liveActionRadioButton;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label totalRegistrationPriceLabel;
        private System.Windows.Forms.Label totalRegistrationPriceDescriptionLabel;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private System.Windows.Forms.CheckBox emailReceiptCheckBox;
        private System.Windows.Forms.MenuStrip registrationFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip registrationFormMenuItemToolTip;
    }
}

