namespace RafalStrzechowskiLab2
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameOfHorseTextBox = new System.Windows.Forms.TextBox();
            this.numberOfLegsTextBox = new System.Windows.Forms.TextBox();
            this.colorOfSequinsTextBox = new System.Windows.Forms.TextBox();
            this.horseNameLabel = new System.Windows.Forms.Label();
            this.numberOfLegsLabel = new System.Windows.Forms.Label();
            this.colorOfSequinsLabel = new System.Windows.Forms.Label();
            this.UnicornTable = new System.Windows.Forms.DataGridView();
            this.unicornNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOflLegsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorOfSequinsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corenerColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.showHorsesButton = new System.Windows.Forms.Button();
            this.addHorseButton = new System.Windows.Forms.Button();
            this.howManyLegsPerHorseLabel = new System.Windows.Forms.Label();
            this.addUnicornButton = new System.Windows.Forms.Button();
            this.averageNumberOfLegsButton = new System.Windows.Forms.Button();
            this.deleteUnicornButton = new System.Windows.Forms.Button();
            this.horseTextBox = new System.Windows.Forms.TextBox();
            this.cornerCheckBox = new System.Windows.Forms.CheckBox();
            this.averageNumberOfLegsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UnicornTable)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(343, 44);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Rafał Strzechowski";
            // 
            // nameOfHorseTextBox
            // 
            this.nameOfHorseTextBox.Location = new System.Drawing.Point(196, 95);
            this.nameOfHorseTextBox.Name = "nameOfHorseTextBox";
            this.nameOfHorseTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameOfHorseTextBox.TabIndex = 1;
            // 
            // numberOfLegsTextBox
            // 
            this.numberOfLegsTextBox.Location = new System.Drawing.Point(196, 130);
            this.numberOfLegsTextBox.Name = "numberOfLegsTextBox";
            this.numberOfLegsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfLegsTextBox.TabIndex = 2;
            // 
            // colorOfSequinsTextBox
            // 
            this.colorOfSequinsTextBox.Location = new System.Drawing.Point(196, 166);
            this.colorOfSequinsTextBox.Name = "colorOfSequinsTextBox";
            this.colorOfSequinsTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorOfSequinsTextBox.TabIndex = 3;
            // 
            // horseNameLabel
            // 
            this.horseNameLabel.AutoSize = true;
            this.horseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.horseNameLabel.Location = new System.Drawing.Point(86, 98);
            this.horseNameLabel.Name = "horseNameLabel";
            this.horseNameLabel.Size = new System.Drawing.Size(86, 17);
            this.horseNameLabel.TabIndex = 4;
            this.horseNameLabel.Text = "nazwa konia";
            // 
            // numberOfLegsLabel
            // 
            this.numberOfLegsLabel.AutoSize = true;
            this.numberOfLegsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.numberOfLegsLabel.Location = new System.Drawing.Point(89, 133);
            this.numberOfLegsLabel.Name = "numberOfLegsLabel";
            this.numberOfLegsLabel.Size = new System.Drawing.Size(72, 17);
            this.numberOfLegsLabel.TabIndex = 5;
            this.numberOfLegsLabel.Text = "liczba nóg";
            // 
            // colorOfSequinsLabel
            // 
            this.colorOfSequinsLabel.AutoSize = true;
            this.colorOfSequinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.colorOfSequinsLabel.Location = new System.Drawing.Point(89, 169);
            this.colorOfSequinsLabel.Name = "colorOfSequinsLabel";
            this.colorOfSequinsLabel.Size = new System.Drawing.Size(93, 17);
            this.colorOfSequinsLabel.TabIndex = 6;
            this.colorOfSequinsLabel.Text = "kolor cekinów";
            // 
            // UnicornTable
            // 
            this.UnicornTable.AllowUserToAddRows = false;
            this.UnicornTable.AllowUserToDeleteRows = false;
            this.UnicornTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnicornTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unicornNameColumn,
            this.numberOflLegsColumn,
            this.colorOfSequinsColumn,
            this.corenerColumn});
            this.UnicornTable.Location = new System.Drawing.Point(577, 36);
            this.UnicornTable.Name = "UnicornTable";
            this.UnicornTable.ReadOnly = true;
            this.UnicornTable.Size = new System.Drawing.Size(444, 231);
            this.UnicornTable.TabIndex = 7;
            // 
            // unicornNameColumn
            // 
            this.unicornNameColumn.HeaderText = "Nazwa";
            this.unicornNameColumn.Name = "unicornNameColumn";
            // 
            // numberOflLegsColumn
            // 
            this.numberOflLegsColumn.HeaderText = "Liczba nóg";
            this.numberOflLegsColumn.Name = "numberOflLegsColumn";
            // 
            // colorOfSequinsColumn
            // 
            this.colorOfSequinsColumn.HeaderText = "Kolor Cekinów";
            this.colorOfSequinsColumn.Name = "colorOfSequinsColumn";
            // 
            // corenerColumn
            // 
            this.corenerColumn.HeaderText = "Róg";
            this.corenerColumn.Name = "corenerColumn";
            // 
            // showHorsesButton
            // 
            this.showHorsesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.showHorsesButton.Location = new System.Drawing.Point(196, 251);
            this.showHorsesButton.Name = "showHorsesButton";
            this.showHorsesButton.Size = new System.Drawing.Size(100, 66);
            this.showHorsesButton.TabIndex = 8;
            this.showHorsesButton.Text = "pokaż konie";
            this.showHorsesButton.UseVisualStyleBackColor = true;
            this.showHorsesButton.Click += new System.EventHandler(this.showHorsesButton_Click);
            // 
            // addHorseButton
            // 
            this.addHorseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.addHorseButton.Location = new System.Drawing.Point(64, 251);
            this.addHorseButton.Name = "addHorseButton";
            this.addHorseButton.Size = new System.Drawing.Size(113, 66);
            this.addHorseButton.TabIndex = 9;
            this.addHorseButton.Text = "Dodaj konia";
            this.addHorseButton.UseVisualStyleBackColor = true;
            this.addHorseButton.Click += new System.EventHandler(this.addHorseButton_Click);
            // 
            // howManyLegsPerHorseLabel
            // 
            this.howManyLegsPerHorseLabel.AutoSize = true;
            this.howManyLegsPerHorseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.howManyLegsPerHorseLabel.Location = new System.Drawing.Point(828, 338);
            this.howManyLegsPerHorseLabel.Name = "howManyLegsPerHorseLabel";
            this.howManyLegsPerHorseLabel.Size = new System.Drawing.Size(177, 17);
            this.howManyLegsPerHorseLabel.TabIndex = 10;
            this.howManyLegsPerHorseLabel.Text = "wyświetla średnią ilość nóg";
            // 
            // addUnicornButton
            // 
            this.addUnicornButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.addUnicornButton.Location = new System.Drawing.Point(577, 280);
            this.addUnicornButton.Name = "addUnicornButton";
            this.addUnicornButton.Size = new System.Drawing.Size(104, 55);
            this.addUnicornButton.TabIndex = 11;
            this.addUnicornButton.Text = "dodaj jednorożca";
            this.addUnicornButton.UseVisualStyleBackColor = true;
            this.addUnicornButton.Click += new System.EventHandler(this.addUnicornButton_Click);
            // 
            // averageNumberOfLegsButton
            // 
            this.averageNumberOfLegsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.averageNumberOfLegsButton.Location = new System.Drawing.Point(814, 280);
            this.averageNumberOfLegsButton.Name = "averageNumberOfLegsButton";
            this.averageNumberOfLegsButton.Size = new System.Drawing.Size(110, 55);
            this.averageNumberOfLegsButton.TabIndex = 12;
            this.averageNumberOfLegsButton.Text = "średnia ilość nóg";
            this.averageNumberOfLegsButton.UseVisualStyleBackColor = true;
            this.averageNumberOfLegsButton.Click += new System.EventHandler(this.averageNumberOfLegsButton_Click);
            // 
            // deleteUnicornButton
            // 
            this.deleteUnicornButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.deleteUnicornButton.Location = new System.Drawing.Point(687, 280);
            this.deleteUnicornButton.Name = "deleteUnicornButton";
            this.deleteUnicornButton.Size = new System.Drawing.Size(111, 55);
            this.deleteUnicornButton.TabIndex = 13;
            this.deleteUnicornButton.Text = "usuń jednorożca";
            this.deleteUnicornButton.UseVisualStyleBackColor = true;
            this.deleteUnicornButton.Click += new System.EventHandler(this.deleteUnicornButton_Click);
            // 
            // horseTextBox
            // 
            this.horseTextBox.Location = new System.Drawing.Point(336, 56);
            this.horseTextBox.Multiline = true;
            this.horseTextBox.Name = "horseTextBox";
            this.horseTextBox.Size = new System.Drawing.Size(182, 272);
            this.horseTextBox.TabIndex = 14;
            // 
            // cornerCheckBox
            // 
            this.cornerCheckBox.AutoSize = true;
            this.cornerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cornerCheckBox.Location = new System.Drawing.Point(89, 199);
            this.cornerCheckBox.Name = "cornerCheckBox";
            this.cornerCheckBox.Size = new System.Drawing.Size(48, 21);
            this.cornerCheckBox.TabIndex = 15;
            this.cornerCheckBox.Text = "róg";
            this.cornerCheckBox.UseVisualStyleBackColor = true;
            // 
            // averageNumberOfLegsTextBox
            // 
            this.averageNumberOfLegsTextBox.Location = new System.Drawing.Point(930, 299);
            this.averageNumberOfLegsTextBox.Name = "averageNumberOfLegsTextBox";
            this.averageNumberOfLegsTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageNumberOfLegsTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 600);
            this.Controls.Add(this.averageNumberOfLegsTextBox);
            this.Controls.Add(this.cornerCheckBox);
            this.Controls.Add(this.horseTextBox);
            this.Controls.Add(this.deleteUnicornButton);
            this.Controls.Add(this.averageNumberOfLegsButton);
            this.Controls.Add(this.addUnicornButton);
            this.Controls.Add(this.howManyLegsPerHorseLabel);
            this.Controls.Add(this.addHorseButton);
            this.Controls.Add(this.showHorsesButton);
            this.Controls.Add(this.UnicornTable);
            this.Controls.Add(this.colorOfSequinsLabel);
            this.Controls.Add(this.numberOfLegsLabel);
            this.Controls.Add(this.horseNameLabel);
            this.Controls.Add(this.colorOfSequinsTextBox);
            this.Controls.Add(this.numberOfLegsTextBox);
            this.Controls.Add(this.nameOfHorseTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UnicornTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameOfHorseTextBox;
        private System.Windows.Forms.TextBox numberOfLegsTextBox;
        private System.Windows.Forms.TextBox colorOfSequinsTextBox;
        private System.Windows.Forms.Label horseNameLabel;
        private System.Windows.Forms.Label numberOfLegsLabel;
        private System.Windows.Forms.Label colorOfSequinsLabel;
        private System.Windows.Forms.DataGridView UnicornTable;
        private System.Windows.Forms.Button showHorsesButton;
        private System.Windows.Forms.Button addHorseButton;
        private System.Windows.Forms.Label howManyLegsPerHorseLabel;
        private System.Windows.Forms.Button addUnicornButton;
        private System.Windows.Forms.Button averageNumberOfLegsButton;
        private System.Windows.Forms.Button deleteUnicornButton;
        private System.Windows.Forms.TextBox horseTextBox;
        private System.Windows.Forms.CheckBox cornerCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn unicornNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOflLegsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorOfSequinsColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn corenerColumn;
        private System.Windows.Forms.TextBox averageNumberOfLegsTextBox;
    }
}

