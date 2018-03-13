namespace ZadanieDomoweLab1
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
            this.employesTable = new System.Windows.Forms.DataGridView();
            this.employeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whatEmployeInreasesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.howManyEmployesYouHaveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyEmployeColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.dumplingsTextBox = new System.Windows.Forms.TextBox();
            this.dumplingsLabel = new System.Windows.Forms.Label();
            this.mushroomLabel = new System.Windows.Forms.Label();
            this.mushroomTextBox = new System.Windows.Forms.TextBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.pancakeSell = new System.Windows.Forms.Button();
            this.dumplingSell = new System.Windows.Forms.Button();
            this.menuTable = new System.Windows.Forms.DataGridView();
            this.foodTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dumplingSellLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.truffleLabel = new System.Windows.Forms.Label();
            this.truffleTextBox = new System.Windows.Forms.TextBox();
            this.truffleCookButton = new System.Windows.Forms.Button();
            this.resourcesLabel = new System.Windows.Forms.Label();
            this.businessLabel = new System.Windows.Forms.Label();
            this.employesLabel = new System.Windows.Forms.Label();
            this.tittleLabel = new System.Windows.Forms.Label();
            this.mushroomPickersLoveScoreLabel = new System.Windows.Forms.Label();
            this.mushroomPickersLoveScoreTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuTable)).BeginInit();
            this.SuspendLayout();
            // 
            // employesTable
            // 
            this.employesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeNameColumn,
            this.employeCostColumn,
            this.whatEmployeInreasesColumn,
            this.howManyEmployesYouHaveColumn,
            this.buyEmployeColumn});
            this.employesTable.Location = new System.Drawing.Point(621, 129);
            this.employesTable.Name = "employesTable";
            this.employesTable.Size = new System.Drawing.Size(544, 204);
            this.employesTable.TabIndex = 0;
            this.employesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employesTable_CellClick);
            // 
            // employeNameColumn
            // 
            this.employeNameColumn.HeaderText = "Nazwa";
            this.employeNameColumn.Name = "employeNameColumn";
            // 
            // employeCostColumn
            // 
            this.employeCostColumn.HeaderText = "Koszt";
            this.employeCostColumn.Name = "employeCostColumn";
            // 
            // whatEmployeInreasesColumn
            // 
            this.whatEmployeInreasesColumn.HeaderText = "Po zakupie:";
            this.whatEmployeInreasesColumn.Name = "whatEmployeInreasesColumn";
            // 
            // howManyEmployesYouHaveColumn
            // 
            this.howManyEmployesYouHaveColumn.HeaderText = "Ilu posiadasz";
            this.howManyEmployesYouHaveColumn.Name = "howManyEmployesYouHaveColumn";
            // 
            // buyEmployeColumn
            // 
            this.buyEmployeColumn.HeaderText = "Zakup";
            this.buyEmployeColumn.Name = "buyEmployeColumn";
            this.buyEmployeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.buyEmployeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // dumplingsTextBox
            // 
            this.dumplingsTextBox.Location = new System.Drawing.Point(95, 129);
            this.dumplingsTextBox.Name = "dumplingsTextBox";
            this.dumplingsTextBox.Size = new System.Drawing.Size(46, 20);
            this.dumplingsTextBox.TabIndex = 1;
            // 
            // dumplingsLabel
            // 
            this.dumplingsLabel.AutoSize = true;
            this.dumplingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dumplingsLabel.Location = new System.Drawing.Point(38, 132);
            this.dumplingsLabel.Name = "dumplingsLabel";
            this.dumplingsLabel.Size = new System.Drawing.Size(51, 17);
            this.dumplingsLabel.TabIndex = 2;
            this.dumplingsLabel.Text = "Ciasta:";
            // 
            // mushroomLabel
            // 
            this.mushroomLabel.AutoSize = true;
            this.mushroomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mushroomLabel.Location = new System.Drawing.Point(32, 164);
            this.mushroomLabel.Name = "mushroomLabel";
            this.mushroomLabel.Size = new System.Drawing.Size(57, 17);
            this.mushroomLabel.TabIndex = 3;
            this.mushroomLabel.Text = "Grzyby:";
            // 
            // mushroomTextBox
            // 
            this.mushroomTextBox.Location = new System.Drawing.Point(95, 161);
            this.mushroomTextBox.Name = "mushroomTextBox";
            this.mushroomTextBox.Size = new System.Drawing.Size(46, 20);
            this.mushroomTextBox.TabIndex = 4;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.moneyLabel.Location = new System.Drawing.Point(15, 198);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(74, 17);
            this.moneyLabel.TabIndex = 5;
            this.moneyLabel.Text = "Pieniądze:";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(95, 195);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(46, 20);
            this.moneyTextBox.TabIndex = 6;
            this.moneyTextBox.Text = "0";
            // 
            // pancakeSell
            // 
            this.pancakeSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.pancakeSell.Location = new System.Drawing.Point(167, 451);
            this.pancakeSell.Name = "pancakeSell";
            this.pancakeSell.Size = new System.Drawing.Size(103, 26);
            this.pancakeSell.TabIndex = 7;
            this.pancakeSell.Text = "Sprzedaj";
            this.pancakeSell.UseVisualStyleBackColor = true;
            this.pancakeSell.Click += new System.EventHandler(this.pancakeSell_Click);
            // 
            // dumplingSell
            // 
            this.dumplingSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dumplingSell.Location = new System.Drawing.Point(167, 411);
            this.dumplingSell.Name = "dumplingSell";
            this.dumplingSell.Size = new System.Drawing.Size(103, 26);
            this.dumplingSell.TabIndex = 8;
            this.dumplingSell.Text = "Sprzedaj";
            this.dumplingSell.UseVisualStyleBackColor = true;
            this.dumplingSell.Click += new System.EventHandler(this.dumplingSell_Click);
            // 
            // menuTable
            // 
            this.menuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodTypeColumn,
            this.foodCostColumn,
            this.ingredientsColumn});
            this.menuTable.Location = new System.Drawing.Point(185, 129);
            this.menuTable.Name = "menuTable";
            this.menuTable.Size = new System.Drawing.Size(344, 141);
            this.menuTable.TabIndex = 9;
            // 
            // foodTypeColumn
            // 
            this.foodTypeColumn.HeaderText = "Menu";
            this.foodTypeColumn.Name = "foodTypeColumn";
            // 
            // foodCostColumn
            // 
            this.foodCostColumn.HeaderText = "Koszt";
            this.foodCostColumn.Name = "foodCostColumn";
            // 
            // ingredientsColumn
            // 
            this.ingredientsColumn.HeaderText = "Składniki";
            this.ingredientsColumn.Name = "ingredientsColumn";
            // 
            // dumplingSellLabel
            // 
            this.dumplingSellLabel.AutoSize = true;
            this.dumplingSellLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dumplingSellLabel.Location = new System.Drawing.Point(31, 417);
            this.dumplingSellLabel.Name = "dumplingSellLabel";
            this.dumplingSellLabel.Size = new System.Drawing.Size(130, 20);
            this.dumplingSellLabel.TabIndex = 10;
            this.dumplingSellLabel.Text = "Sprzedaj pierogi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(16, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sprzedaj naleśniki";
            // 
            // truffleLabel
            // 
            this.truffleLabel.AutoSize = true;
            this.truffleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.truffleLabel.Location = new System.Drawing.Point(40, 230);
            this.truffleLabel.Name = "truffleLabel";
            this.truffleLabel.Size = new System.Drawing.Size(49, 17);
            this.truffleLabel.TabIndex = 12;
            this.truffleLabel.Text = "Trufle:";
            // 
            // truffleTextBox
            // 
            this.truffleTextBox.Location = new System.Drawing.Point(95, 227);
            this.truffleTextBox.Name = "truffleTextBox";
            this.truffleTextBox.Size = new System.Drawing.Size(46, 20);
            this.truffleTextBox.TabIndex = 13;
            this.truffleTextBox.Text = "0";
            // 
            // truffleCookButton
            // 
            this.truffleCookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.truffleCookButton.Location = new System.Drawing.Point(318, 389);
            this.truffleCookButton.Name = "truffleCookButton";
            this.truffleCookButton.Size = new System.Drawing.Size(211, 108);
            this.truffleCookButton.TabIndex = 14;
            this.truffleCookButton.Text = "Upiecz truflowe pierogi!";
            this.truffleCookButton.UseVisualStyleBackColor = true;
            this.truffleCookButton.Click += new System.EventHandler(this.truffleCookButton_Click);
            // 
            // resourcesLabel
            // 
            this.resourcesLabel.AutoSize = true;
            this.resourcesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.resourcesLabel.Location = new System.Drawing.Point(180, 76);
            this.resourcesLabel.Name = "resourcesLabel";
            this.resourcesLabel.Size = new System.Drawing.Size(201, 29);
            this.resourcesLabel.TabIndex = 15;
            this.resourcesLabel.Text = "Zasoby i menu:";
            // 
            // businessLabel
            // 
            this.businessLabel.AutoSize = true;
            this.businessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.businessLabel.Location = new System.Drawing.Point(180, 335);
            this.businessLabel.Name = "businessLabel";
            this.businessLabel.Size = new System.Drawing.Size(104, 29);
            this.businessLabel.TabIndex = 16;
            this.businessLabel.Text = "Biznes:";
            // 
            // employesLabel
            // 
            this.employesLabel.AutoSize = true;
            this.employesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.employesLabel.Location = new System.Drawing.Point(832, 76);
            this.employesLabel.Name = "employesLabel";
            this.employesLabel.Size = new System.Drawing.Size(161, 29);
            this.employesLabel.TabIndex = 17;
            this.employesLabel.Text = "Pracownicy:";
            // 
            // tittleLabel
            // 
            this.tittleLabel.AutoSize = true;
            this.tittleLabel.Font = new System.Drawing.Font("Vivaldi", 30.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tittleLabel.Location = new System.Drawing.Point(333, 9);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(511, 49);
            this.tittleLabel.TabIndex = 18;
            this.tittleLabel.Text = "W poszukiwaniu truflowego pieroga";
            // 
            // mushroomPickersLoveScoreLabel
            // 
            this.mushroomPickersLoveScoreLabel.AutoSize = true;
            this.mushroomPickersLoveScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.mushroomPickersLoveScoreLabel.Location = new System.Drawing.Point(616, 434);
            this.mushroomPickersLoveScoreLabel.Name = "mushroomPickersLoveScoreLabel";
            this.mushroomPickersLoveScoreLabel.Size = new System.Drawing.Size(366, 25);
            this.mushroomPickersLoveScoreLabel.TabIndex = 19;
            this.mushroomPickersLoveScoreLabel.Text = "Jak bardzo kochasz grzybiarzy (0-5):";
            // 
            // mushroomPickersLoveScoreTextBox
            // 
            this.mushroomPickersLoveScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.mushroomPickersLoveScoreTextBox.Location = new System.Drawing.Point(1008, 431);
            this.mushroomPickersLoveScoreTextBox.Name = "mushroomPickersLoveScoreTextBox";
            this.mushroomPickersLoveScoreTextBox.Size = new System.Drawing.Size(46, 31);
            this.mushroomPickersLoveScoreTextBox.TabIndex = 20;
            this.mushroomPickersLoveScoreTextBox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ZadanieDomoweLab1.Properties.Resources.Truflle;
            this.ClientSize = new System.Drawing.Size(1196, 556);
            this.Controls.Add(this.mushroomPickersLoveScoreTextBox);
            this.Controls.Add(this.mushroomPickersLoveScoreLabel);
            this.Controls.Add(this.tittleLabel);
            this.Controls.Add(this.employesLabel);
            this.Controls.Add(this.businessLabel);
            this.Controls.Add(this.resourcesLabel);
            this.Controls.Add(this.truffleCookButton);
            this.Controls.Add(this.truffleTextBox);
            this.Controls.Add(this.truffleLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dumplingSellLabel);
            this.Controls.Add(this.menuTable);
            this.Controls.Add(this.dumplingSell);
            this.Controls.Add(this.pancakeSell);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.mushroomTextBox);
            this.Controls.Add(this.mushroomLabel);
            this.Controls.Add(this.dumplingsLabel);
            this.Controls.Add(this.dumplingsTextBox);
            this.Controls.Add(this.employesTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whatEmployeInreasesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn howManyEmployesYouHaveColumn;
        private System.Windows.Forms.DataGridViewButtonColumn buyEmployeColumn;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.TextBox dumplingsTextBox;
        private System.Windows.Forms.Label dumplingsLabel;
        private System.Windows.Forms.Label mushroomLabel;
        private System.Windows.Forms.TextBox mushroomTextBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.Button pancakeSell;
        private System.Windows.Forms.Button dumplingSell;
        private System.Windows.Forms.DataGridView menuTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientsColumn;
        private System.Windows.Forms.Label dumplingSellLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label truffleLabel;
        private System.Windows.Forms.TextBox truffleTextBox;
        private System.Windows.Forms.Button truffleCookButton;
        private System.Windows.Forms.Label resourcesLabel;
        private System.Windows.Forms.Label businessLabel;
        private System.Windows.Forms.Label employesLabel;
        private System.Windows.Forms.Label tittleLabel;
        private System.Windows.Forms.Label mushroomPickersLoveScoreLabel;
        private System.Windows.Forms.TextBox mushroomPickersLoveScoreTextBox;
    }
}

