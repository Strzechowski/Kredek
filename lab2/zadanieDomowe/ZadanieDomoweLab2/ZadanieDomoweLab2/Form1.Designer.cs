namespace ZadanieDomoweLab2
{
    partial class Form1
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
            this.buyEmployeeButton = new System.Windows.Forms.Button();
            this.mushroomPickersTable = new System.Windows.Forms.DataGridView();
            this.nameOfMushroomPickerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.howManyMushroomsPerHourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hairStyleOfMushroomPickerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustacheOfMushroomPickerColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cooksTable = new System.Windows.Forms.DataGridView();
            this.nameOfCookColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.howManyDumplingsPerHourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hairstyleOfCookColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityOfCookColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chefHatColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameOfEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.nameOfEmployeeLabel = new System.Windows.Forms.Label();
            this.NationalityLabel = new System.Windows.Forms.Label();
            this.hairstyleLabel = new System.Windows.Forms.Label();
            this.hairstyleOfEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.mustacheOrChefHatCheckBox = new System.Windows.Forms.CheckBox();
            this.NationalityTextBox = new System.Windows.Forms.TextBox();
            this.howManyResourcesPerHourLabel = new System.Windows.Forms.Label();
            this.typeOfEmployeeLabel = new System.Windows.Forms.Label();
            this.typeOfEmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.howMuchToThievesProgressBar = new System.Windows.Forms.ProgressBar();
            this.timeCounter = new System.Windows.Forms.Timer(this.components);
            this.employeeIntroductionTextBox = new System.Windows.Forms.TextBox();
            this.timeInGameTextBox = new System.Windows.Forms.TextBox();
            this.timeInGameLabel = new System.Windows.Forms.Label();
            this.mushroomLabel = new System.Windows.Forms.Label();
            this.dumplingsDoughLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.mushroomTextBox = new System.Windows.Forms.TextBox();
            this.dumplingDoughTextBox = new System.Windows.Forms.TextBox();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.sellDumplings = new System.Windows.Forms.Button();
            this.whoAttacksTextBox = new System.Windows.Forms.TextBox();
            this.whenWillThievesComeLabel = new System.Windows.Forms.Label();
            this.whoWillStealFromYouLabel = new System.Windows.Forms.Label();
            this.howManyResourcesPerHourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sellDumplingsTextBox = new System.Windows.Forms.TextBox();
            this.sellDumplingsLabel = new System.Windows.Forms.Label();
            this.howMuchWillBeStolenLabel = new System.Windows.Forms.Label();
            this.howMuchWillBeStolenTextBox = new System.Windows.Forms.TextBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.avarageAmmountOfMoneyLabel = new System.Windows.Forms.Label();
            this.avarageAmmountOfMoneyTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mushroomPickersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooksTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.howManyResourcesPerHourNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // buyEmployeeButton
            // 
            this.buyEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buyEmployeeButton.Location = new System.Drawing.Point(626, 25);
            this.buyEmployeeButton.Name = "buyEmployeeButton";
            this.buyEmployeeButton.Size = new System.Drawing.Size(184, 33);
            this.buyEmployeeButton.TabIndex = 1;
            this.buyEmployeeButton.Text = "Kup pracownika";
            this.buyEmployeeButton.UseVisualStyleBackColor = true;
            this.buyEmployeeButton.Click += new System.EventHandler(this.buyEmployeeButton_Click);
            // 
            // mushroomPickersTable
            // 
            this.mushroomPickersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mushroomPickersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameOfMushroomPickerColumn,
            this.howManyMushroomsPerHourColumn,
            this.hairStyleOfMushroomPickerColumn,
            this.mustacheOfMushroomPickerColumn});
            this.mushroomPickersTable.Location = new System.Drawing.Point(1083, 40);
            this.mushroomPickersTable.Name = "mushroomPickersTable";
            this.mushroomPickersTable.Size = new System.Drawing.Size(548, 220);
            this.mushroomPickersTable.TabIndex = 3;
            // 
            // nameOfMushroomPickerColumn
            // 
            this.nameOfMushroomPickerColumn.HeaderText = "Imię";
            this.nameOfMushroomPickerColumn.Name = "nameOfMushroomPickerColumn";
            this.nameOfMushroomPickerColumn.ReadOnly = true;
            // 
            // howManyMushroomsPerHourColumn
            // 
            this.howManyMushroomsPerHourColumn.HeaderText = "Ile grzbybów na godzine";
            this.howManyMushroomsPerHourColumn.Name = "howManyMushroomsPerHourColumn";
            this.howManyMushroomsPerHourColumn.ReadOnly = true;
            // 
            // hairStyleOfMushroomPickerColumn
            // 
            this.hairStyleOfMushroomPickerColumn.HeaderText = "Fryzura";
            this.hairStyleOfMushroomPickerColumn.Name = "hairStyleOfMushroomPickerColumn";
            this.hairStyleOfMushroomPickerColumn.ReadOnly = true;
            // 
            // mustacheOfMushroomPickerColumn
            // 
            this.mustacheOfMushroomPickerColumn.HeaderText = "Wąs";
            this.mustacheOfMushroomPickerColumn.Name = "mustacheOfMushroomPickerColumn";
            this.mustacheOfMushroomPickerColumn.ReadOnly = true;
            // 
            // cooksTable
            // 
            this.cooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cooksTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameOfCookColumn,
            this.howManyDumplingsPerHourColumn,
            this.hairstyleOfCookColumn,
            this.nationalityOfCookColumn,
            this.chefHatColumn});
            this.cooksTable.Location = new System.Drawing.Point(1083, 301);
            this.cooksTable.Name = "cooksTable";
            this.cooksTable.Size = new System.Drawing.Size(544, 220);
            this.cooksTable.TabIndex = 4;
            // 
            // nameOfCookColumn
            // 
            this.nameOfCookColumn.HeaderText = "Imię";
            this.nameOfCookColumn.Name = "nameOfCookColumn";
            this.nameOfCookColumn.ReadOnly = true;
            // 
            // howManyDumplingsPerHourColumn
            // 
            this.howManyDumplingsPerHourColumn.HeaderText = "Ile pierogów na godzinę";
            this.howManyDumplingsPerHourColumn.Name = "howManyDumplingsPerHourColumn";
            this.howManyDumplingsPerHourColumn.ReadOnly = true;
            // 
            // hairstyleOfCookColumn
            // 
            this.hairstyleOfCookColumn.HeaderText = "Fryzura";
            this.hairstyleOfCookColumn.Name = "hairstyleOfCookColumn";
            this.hairstyleOfCookColumn.ReadOnly = true;
            // 
            // nationalityOfCookColumn
            // 
            this.nationalityOfCookColumn.HeaderText = "Pochodzenie";
            this.nationalityOfCookColumn.Name = "nationalityOfCookColumn";
            this.nationalityOfCookColumn.ReadOnly = true;
            // 
            // chefHatColumn
            // 
            this.chefHatColumn.HeaderText = "Czapka szefa";
            this.chefHatColumn.Name = "chefHatColumn";
            this.chefHatColumn.ReadOnly = true;
            // 
            // nameOfEmployeeTextBox
            // 
            this.nameOfEmployeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nameOfEmployeeTextBox.Location = new System.Drawing.Point(97, 29);
            this.nameOfEmployeeTextBox.Name = "nameOfEmployeeTextBox";
            this.nameOfEmployeeTextBox.Size = new System.Drawing.Size(106, 26);
            this.nameOfEmployeeTextBox.TabIndex = 5;
            this.nameOfEmployeeTextBox.Text = "Czesio";
            // 
            // nameOfEmployeeLabel
            // 
            this.nameOfEmployeeLabel.AutoSize = true;
            this.nameOfEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nameOfEmployeeLabel.Location = new System.Drawing.Point(46, 29);
            this.nameOfEmployeeLabel.Name = "nameOfEmployeeLabel";
            this.nameOfEmployeeLabel.Size = new System.Drawing.Size(45, 24);
            this.nameOfEmployeeLabel.TabIndex = 6;
            this.nameOfEmployeeLabel.Text = "Imię";
            // 
            // NationalityLabel
            // 
            this.NationalityLabel.AutoSize = true;
            this.NationalityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NationalityLabel.Location = new System.Drawing.Point(228, 69);
            this.NationalityLabel.Name = "NationalityLabel";
            this.NationalityLabel.Size = new System.Drawing.Size(203, 24);
            this.NationalityLabel.TabIndex = 9;
            this.NationalityLabel.Text = "Pochodzenie kucharza";
            // 
            // hairstyleLabel
            // 
            this.hairstyleLabel.AutoSize = true;
            this.hairstyleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.hairstyleLabel.Location = new System.Drawing.Point(17, 69);
            this.hairstyleLabel.Name = "hairstyleLabel";
            this.hairstyleLabel.Size = new System.Drawing.Size(73, 24);
            this.hairstyleLabel.TabIndex = 10;
            this.hairstyleLabel.Text = "Fryzura";
            // 
            // hairstyleOfEmployeeTextBox
            // 
            this.hairstyleOfEmployeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.hairstyleOfEmployeeTextBox.Location = new System.Drawing.Point(97, 69);
            this.hairstyleOfEmployeeTextBox.Name = "hairstyleOfEmployeeTextBox";
            this.hairstyleOfEmployeeTextBox.Size = new System.Drawing.Size(106, 26);
            this.hairstyleOfEmployeeTextBox.TabIndex = 11;
            this.hairstyleOfEmployeeTextBox.Text = "Czeski piłkarz";
            // 
            // mustacheOrChefHatCheckBox
            // 
            this.mustacheOrChefHatCheckBox.AutoSize = true;
            this.mustacheOrChefHatCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.mustacheOrChefHatCheckBox.Location = new System.Drawing.Point(22, 111);
            this.mustacheOrChefHatCheckBox.Name = "mustacheOrChefHatCheckBox";
            this.mustacheOrChefHatCheckBox.Size = new System.Drawing.Size(181, 28);
            this.mustacheOrChefHatCheckBox.TabIndex = 14;
            this.mustacheOrChefHatCheckBox.Text = "Wąs/Czapka szefa";
            this.mustacheOrChefHatCheckBox.UseVisualStyleBackColor = true;
            // 
            // NationalityTextBox
            // 
            this.NationalityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NationalityTextBox.Location = new System.Drawing.Point(437, 69);
            this.NationalityTextBox.Name = "NationalityTextBox";
            this.NationalityTextBox.Size = new System.Drawing.Size(100, 26);
            this.NationalityTextBox.TabIndex = 15;
            this.NationalityTextBox.Text = "Polska";
            // 
            // howManyResourcesPerHourLabel
            // 
            this.howManyResourcesPerHourLabel.AutoSize = true;
            this.howManyResourcesPerHourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.howManyResourcesPerHourLabel.Location = new System.Drawing.Point(213, 29);
            this.howManyResourcesPerHourLabel.Name = "howManyResourcesPerHourLabel";
            this.howManyResourcesPerHourLabel.Size = new System.Drawing.Size(218, 24);
            this.howManyResourcesPerHourLabel.TabIndex = 16;
            this.howManyResourcesPerHourLabel.Text = "Ile produkuje na godzinę";
            // 
            // typeOfEmployeeLabel
            // 
            this.typeOfEmployeeLabel.AutoSize = true;
            this.typeOfEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.typeOfEmployeeLabel.Location = new System.Drawing.Point(262, 111);
            this.typeOfEmployeeLabel.Name = "typeOfEmployeeLabel";
            this.typeOfEmployeeLabel.Size = new System.Drawing.Size(169, 24);
            this.typeOfEmployeeLabel.TabIndex = 17;
            this.typeOfEmployeeLabel.Text = "Rodzaj pracownika";
            // 
            // typeOfEmployeeComboBox
            // 
            this.typeOfEmployeeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.typeOfEmployeeComboBox.FormattingEnabled = true;
            this.typeOfEmployeeComboBox.Items.AddRange(new object[] {
            "Grzybiarz",
            "Kucharz"});
            this.typeOfEmployeeComboBox.Location = new System.Drawing.Point(437, 111);
            this.typeOfEmployeeComboBox.Name = "typeOfEmployeeComboBox";
            this.typeOfEmployeeComboBox.Size = new System.Drawing.Size(100, 28);
            this.typeOfEmployeeComboBox.TabIndex = 18;
            this.typeOfEmployeeComboBox.Text = "Grzybiarz";
            // 
            // howMuchToThievesProgressBar
            // 
            this.howMuchToThievesProgressBar.Location = new System.Drawing.Point(778, 347);
            this.howMuchToThievesProgressBar.Maximum = 10;
            this.howMuchToThievesProgressBar.Name = "howMuchToThievesProgressBar";
            this.howMuchToThievesProgressBar.Size = new System.Drawing.Size(128, 39);
            this.howMuchToThievesProgressBar.Step = 1;
            this.howMuchToThievesProgressBar.TabIndex = 19;
            // 
            // timeCounter
            // 
            this.timeCounter.Interval = 2000;
            this.timeCounter.Tick += new System.EventHandler(this.timeCounter_Tick);
            // 
            // employeeIntroductionTextBox
            // 
            this.employeeIntroductionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.employeeIntroductionTextBox.Location = new System.Drawing.Point(593, 64);
            this.employeeIntroductionTextBox.Multiline = true;
            this.employeeIntroductionTextBox.Name = "employeeIntroductionTextBox";
            this.employeeIntroductionTextBox.ReadOnly = true;
            this.employeeIntroductionTextBox.Size = new System.Drawing.Size(239, 94);
            this.employeeIntroductionTextBox.TabIndex = 21;
            // 
            // timeInGameTextBox
            // 
            this.timeInGameTextBox.Location = new System.Drawing.Point(1408, 549);
            this.timeInGameTextBox.Name = "timeInGameTextBox";
            this.timeInGameTextBox.ReadOnly = true;
            this.timeInGameTextBox.Size = new System.Drawing.Size(53, 20);
            this.timeInGameTextBox.TabIndex = 22;
            this.timeInGameTextBox.Text = "0";
            // 
            // timeInGameLabel
            // 
            this.timeInGameLabel.AutoSize = true;
            this.timeInGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.timeInGameLabel.Location = new System.Drawing.Point(1275, 549);
            this.timeInGameLabel.Name = "timeInGameLabel";
            this.timeInGameLabel.Size = new System.Drawing.Size(117, 24);
            this.timeInGameLabel.TabIndex = 23;
            this.timeInGameLabel.Text = "Czas w grze:";
            // 
            // mushroomLabel
            // 
            this.mushroomLabel.AutoSize = true;
            this.mushroomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.mushroomLabel.Location = new System.Drawing.Point(87, 612);
            this.mushroomLabel.Name = "mushroomLabel";
            this.mushroomLabel.Size = new System.Drawing.Size(73, 24);
            this.mushroomLabel.TabIndex = 24;
            this.mushroomLabel.Text = "Grzyby:";
            // 
            // dumplingsDoughLabel
            // 
            this.dumplingsDoughLabel.AutoSize = true;
            this.dumplingsDoughLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dumplingsDoughLabel.Location = new System.Drawing.Point(7, 579);
            this.dumplingsDoughLabel.Name = "dumplingsDoughLabel";
            this.dumplingsDoughLabel.Size = new System.Drawing.Size(154, 24);
            this.dumplingsDoughLabel.TabIndex = 25;
            this.dumplingsDoughLabel.Text = "Ciasta na pierogi:";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.moneyLabel.Location = new System.Drawing.Point(63, 544);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(98, 24);
            this.moneyLabel.TabIndex = 26;
            this.moneyLabel.Text = "Pieniądze:";
            // 
            // mushroomTextBox
            // 
            this.mushroomTextBox.Location = new System.Drawing.Point(177, 617);
            this.mushroomTextBox.Name = "mushroomTextBox";
            this.mushroomTextBox.ReadOnly = true;
            this.mushroomTextBox.Size = new System.Drawing.Size(53, 20);
            this.mushroomTextBox.TabIndex = 27;
            this.mushroomTextBox.Text = "0";
            // 
            // dumplingDoughTextBox
            // 
            this.dumplingDoughTextBox.Location = new System.Drawing.Point(177, 584);
            this.dumplingDoughTextBox.Name = "dumplingDoughTextBox";
            this.dumplingDoughTextBox.ReadOnly = true;
            this.dumplingDoughTextBox.Size = new System.Drawing.Size(53, 20);
            this.dumplingDoughTextBox.TabIndex = 28;
            this.dumplingDoughTextBox.Text = "0";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(177, 549);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.ReadOnly = true;
            this.moneyTextBox.Size = new System.Drawing.Size(53, 20);
            this.moneyTextBox.TabIndex = 29;
            this.moneyTextBox.Text = "0";
            // 
            // sellDumplings
            // 
            this.sellDumplings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.sellDumplings.Location = new System.Drawing.Point(263, 570);
            this.sellDumplings.Name = "sellDumplings";
            this.sellDumplings.Size = new System.Drawing.Size(184, 33);
            this.sellDumplings.TabIndex = 30;
            this.sellDumplings.Text = "Sprzedaj Pierogi";
            this.sellDumplings.UseVisualStyleBackColor = true;
            this.sellDumplings.Click += new System.EventHandler(this.sellDumplings_Click);
            // 
            // whoAttacksTextBox
            // 
            this.whoAttacksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.whoAttacksTextBox.Location = new System.Drawing.Point(778, 274);
            this.whoAttacksTextBox.Multiline = true;
            this.whoAttacksTextBox.Name = "whoAttacksTextBox";
            this.whoAttacksTextBox.ReadOnly = true;
            this.whoAttacksTextBox.Size = new System.Drawing.Size(128, 66);
            this.whoAttacksTextBox.TabIndex = 31;
            this.whoAttacksTextBox.Text = "Nikt";
            this.whoAttacksTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // whenWillThievesComeLabel
            // 
            this.whenWillThievesComeLabel.AutoSize = true;
            this.whenWillThievesComeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.whenWillThievesComeLabel.Location = new System.Drawing.Point(658, 347);
            this.whenWillThievesComeLabel.Name = "whenWillThievesComeLabel";
            this.whenWillThievesComeLabel.Size = new System.Drawing.Size(105, 38);
            this.whenWillThievesComeLabel.TabIndex = 32;
            this.whenWillThievesComeLabel.Text = "Za ile:";
            // 
            // whoWillStealFromYouLabel
            // 
            this.whoWillStealFromYouLabel.AutoSize = true;
            this.whoWillStealFromYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.whoWillStealFromYouLabel.Location = new System.Drawing.Point(503, 283);
            this.whoWillStealFromYouLabel.Name = "whoWillStealFromYouLabel";
            this.whoWillStealFromYouLabel.Size = new System.Drawing.Size(260, 38);
            this.whoWillStealFromYouLabel.TabIndex = 33;
            this.whoWillStealFromYouLabel.Text = "Kto cię okradnie:";
            // 
            // howManyResourcesPerHourNumericUpDown
            // 
            this.howManyResourcesPerHourNumericUpDown.Location = new System.Drawing.Point(437, 33);
            this.howManyResourcesPerHourNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.howManyResourcesPerHourNumericUpDown.Name = "howManyResourcesPerHourNumericUpDown";
            this.howManyResourcesPerHourNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.howManyResourcesPerHourNumericUpDown.TabIndex = 34;
            this.howManyResourcesPerHourNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sellDumplingsTextBox
            // 
            this.sellDumplingsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sellDumplingsTextBox.Location = new System.Drawing.Point(350, 617);
            this.sellDumplingsTextBox.Name = "sellDumplingsTextBox";
            this.sellDumplingsTextBox.Size = new System.Drawing.Size(60, 26);
            this.sellDumplingsTextBox.TabIndex = 35;
            // 
            // sellDumplingsLabel
            // 
            this.sellDumplingsLabel.AutoSize = true;
            this.sellDumplingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.sellDumplingsLabel.Location = new System.Drawing.Point(288, 614);
            this.sellDumplingsLabel.Name = "sellDumplingsLabel";
            this.sellDumplingsLabel.Size = new System.Drawing.Size(46, 29);
            this.sellDumplingsLabel.TabIndex = 36;
            this.sellDumplingsLabel.Text = "Ile:";
            // 
            // howMuchWillBeStolenLabel
            // 
            this.howMuchWillBeStolenLabel.AutoSize = true;
            this.howMuchWillBeStolenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.howMuchWillBeStolenLabel.Location = new System.Drawing.Point(571, 397);
            this.howMuchWillBeStolenLabel.Name = "howMuchWillBeStolenLabel";
            this.howMuchWillBeStolenLabel.Size = new System.Drawing.Size(192, 38);
            this.howMuchWillBeStolenLabel.TabIndex = 37;
            this.howMuchWillBeStolenLabel.Text = "Ile zabierze:";
            // 
            // howMuchWillBeStolenTextBox
            // 
            this.howMuchWillBeStolenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.howMuchWillBeStolenTextBox.Location = new System.Drawing.Point(793, 404);
            this.howMuchWillBeStolenTextBox.Name = "howMuchWillBeStolenTextBox";
            this.howMuchWillBeStolenTextBox.ReadOnly = true;
            this.howMuchWillBeStolenTextBox.Size = new System.Drawing.Size(100, 29);
            this.howMuchWillBeStolenTextBox.TabIndex = 38;
            this.howMuchWillBeStolenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.targetLabel.Location = new System.Drawing.Point(70, 253);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.targetLabel.Size = new System.Drawing.Size(75, 38);
            this.targetLabel.TabIndex = 39;
            this.targetLabel.Text = "Cel:";
            // 
            // targetTextBox
            // 
            this.targetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.targetTextBox.Location = new System.Drawing.Point(166, 215);
            this.targetTextBox.Multiline = true;
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.ReadOnly = true;
            this.targetTextBox.Size = new System.Drawing.Size(203, 183);
            this.targetTextBox.TabIndex = 40;
            this.targetTextBox.Text = "Przetrwaj 5 fal kradzieży i zarób 40 zł. UWAGA! Nie możesz zejść poniżej 0 grzybó" +
    "w lub ciast.";
            this.targetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // avarageAmmountOfMoneyLabel
            // 
            this.avarageAmmountOfMoneyLabel.AutoSize = true;
            this.avarageAmmountOfMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.avarageAmmountOfMoneyLabel.Location = new System.Drawing.Point(1076, 593);
            this.avarageAmmountOfMoneyLabel.Name = "avarageAmmountOfMoneyLabel";
            this.avarageAmmountOfMoneyLabel.Size = new System.Drawing.Size(316, 24);
            this.avarageAmmountOfMoneyLabel.TabIndex = 42;
            this.avarageAmmountOfMoneyLabel.Text = "Średnia ilość pieniędzy podczas gry:";
            // 
            // avarageAmmountOfMoneyTextBox
            // 
            this.avarageAmmountOfMoneyTextBox.Location = new System.Drawing.Point(1408, 597);
            this.avarageAmmountOfMoneyTextBox.Name = "avarageAmmountOfMoneyTextBox";
            this.avarageAmmountOfMoneyTextBox.ReadOnly = true;
            this.avarageAmmountOfMoneyTextBox.Size = new System.Drawing.Size(53, 20);
            this.avarageAmmountOfMoneyTextBox.TabIndex = 41;
            this.avarageAmmountOfMoneyTextBox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1639, 727);
            this.Controls.Add(this.avarageAmmountOfMoneyLabel);
            this.Controls.Add(this.avarageAmmountOfMoneyTextBox);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.howMuchWillBeStolenTextBox);
            this.Controls.Add(this.howMuchWillBeStolenLabel);
            this.Controls.Add(this.sellDumplingsLabel);
            this.Controls.Add(this.sellDumplingsTextBox);
            this.Controls.Add(this.howManyResourcesPerHourNumericUpDown);
            this.Controls.Add(this.whoWillStealFromYouLabel);
            this.Controls.Add(this.whenWillThievesComeLabel);
            this.Controls.Add(this.whoAttacksTextBox);
            this.Controls.Add(this.sellDumplings);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.dumplingDoughTextBox);
            this.Controls.Add(this.mushroomTextBox);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.dumplingsDoughLabel);
            this.Controls.Add(this.mushroomLabel);
            this.Controls.Add(this.timeInGameLabel);
            this.Controls.Add(this.timeInGameTextBox);
            this.Controls.Add(this.employeeIntroductionTextBox);
            this.Controls.Add(this.howMuchToThievesProgressBar);
            this.Controls.Add(this.typeOfEmployeeComboBox);
            this.Controls.Add(this.typeOfEmployeeLabel);
            this.Controls.Add(this.howManyResourcesPerHourLabel);
            this.Controls.Add(this.NationalityTextBox);
            this.Controls.Add(this.mustacheOrChefHatCheckBox);
            this.Controls.Add(this.hairstyleOfEmployeeTextBox);
            this.Controls.Add(this.hairstyleLabel);
            this.Controls.Add(this.NationalityLabel);
            this.Controls.Add(this.nameOfEmployeeLabel);
            this.Controls.Add(this.nameOfEmployeeTextBox);
            this.Controls.Add(this.cooksTable);
            this.Controls.Add(this.mushroomPickersTable);
            this.Controls.Add(this.buyEmployeeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mushroomPickersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooksTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.howManyResourcesPerHourNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buyEmployeeButton;
        private System.Windows.Forms.DataGridView mushroomPickersTable;
        private System.Windows.Forms.DataGridView cooksTable;
        private System.Windows.Forms.TextBox nameOfEmployeeTextBox;
        private System.Windows.Forms.Label nameOfEmployeeLabel;
        private System.Windows.Forms.Label NationalityLabel;
        private System.Windows.Forms.Label hairstyleLabel;
        private System.Windows.Forms.TextBox hairstyleOfEmployeeTextBox;
        private System.Windows.Forms.CheckBox mustacheOrChefHatCheckBox;
        private System.Windows.Forms.TextBox NationalityTextBox;
        private System.Windows.Forms.Label howManyResourcesPerHourLabel;
        private System.Windows.Forms.Label typeOfEmployeeLabel;
        private System.Windows.Forms.ComboBox typeOfEmployeeComboBox;
        private System.Windows.Forms.ProgressBar howMuchToThievesProgressBar;
        private System.Windows.Forms.Timer timeCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfCookColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn howManyDumplingsPerHourColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hairstyleOfCookColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityOfCookColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chefHatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfMushroomPickerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn howManyMushroomsPerHourColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hairStyleOfMushroomPickerColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mustacheOfMushroomPickerColumn;
        private System.Windows.Forms.TextBox employeeIntroductionTextBox;
        private System.Windows.Forms.TextBox timeInGameTextBox;
        private System.Windows.Forms.Label timeInGameLabel;
        private System.Windows.Forms.Label mushroomLabel;
        private System.Windows.Forms.Label dumplingsDoughLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TextBox mushroomTextBox;
        private System.Windows.Forms.TextBox dumplingDoughTextBox;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.Button sellDumplings;
        private System.Windows.Forms.TextBox whoAttacksTextBox;
        private System.Windows.Forms.Label whenWillThievesComeLabel;
        private System.Windows.Forms.Label whoWillStealFromYouLabel;
        private System.Windows.Forms.NumericUpDown howManyResourcesPerHourNumericUpDown;
        private System.Windows.Forms.TextBox sellDumplingsTextBox;
        private System.Windows.Forms.Label sellDumplingsLabel;
        private System.Windows.Forms.Label howMuchWillBeStolenLabel;
        private System.Windows.Forms.TextBox howMuchWillBeStolenTextBox;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Label avarageAmmountOfMoneyLabel;
        private System.Windows.Forms.TextBox avarageAmmountOfMoneyTextBox;
    }
}

