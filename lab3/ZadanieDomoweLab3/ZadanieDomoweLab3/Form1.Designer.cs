namespace ZadanieDomoweLab3
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.dataGridViewAnimals = new System.Windows.Forms.DataGridView();
            this.dataGridViewForVisitors = new System.Windows.Forms.DataGridView();
            this.buttonForVisitors = new System.Windows.Forms.Button();
            this.comboBoxForVisitors = new System.Windows.Forms.ComboBox();
            this.buttonShowEmployees = new System.Windows.Forms.Button();
            this.textBoxEmployeesSurnameLike = new System.Windows.Forms.TextBox();
            this.buttonShowWorkSchedule = new System.Windows.Forms.Button();
            this.checkBoxFeedingInfo = new System.Windows.Forms.CheckBox();
            this.checkBoxAnimalsInfo = new System.Windows.Forms.CheckBox();
            this.buttonShowAnimals = new System.Windows.Forms.Button();
            this.groupBoxEmployees = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelShowWorkSchedule = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmployees = new System.Windows.Forms.Label();
            this.labelAnimals = new System.Windows.Forms.Label();
            this.labelForVisitors = new System.Windows.Forms.Label();
            this.labelZoo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForVisitors)).BeginInit();
            this.groupBoxEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(30, 138);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(527, 327);
            this.dataGridViewEmployees.TabIndex = 0;
            // 
            // dataGridViewAnimals
            // 
            this.dataGridViewAnimals.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dataGridViewAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimals.Location = new System.Drawing.Point(604, 138);
            this.dataGridViewAnimals.Name = "dataGridViewAnimals";
            this.dataGridViewAnimals.Size = new System.Drawing.Size(543, 327);
            this.dataGridViewAnimals.TabIndex = 1;
            // 
            // dataGridViewForVisitors
            // 
            this.dataGridViewForVisitors.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dataGridViewForVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForVisitors.Enabled = false;
            this.dataGridViewForVisitors.Location = new System.Drawing.Point(1230, 138);
            this.dataGridViewForVisitors.Name = "dataGridViewForVisitors";
            this.dataGridViewForVisitors.Size = new System.Drawing.Size(360, 327);
            this.dataGridViewForVisitors.TabIndex = 2;
            // 
            // buttonForVisitors
            // 
            this.buttonForVisitors.AutoSize = true;
            this.buttonForVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonForVisitors.Location = new System.Drawing.Point(1230, 471);
            this.buttonForVisitors.Name = "buttonForVisitors";
            this.buttonForVisitors.Size = new System.Drawing.Size(132, 44);
            this.buttonForVisitors.TabIndex = 3;
            this.buttonForVisitors.Text = "Wyświetl";
            this.buttonForVisitors.UseVisualStyleBackColor = true;
            this.buttonForVisitors.Click += new System.EventHandler(this.buttonForVisitors_Click);
            // 
            // comboBoxForVisitors
            // 
            this.comboBoxForVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.comboBoxForVisitors.FormattingEnabled = true;
            this.comboBoxForVisitors.Items.AddRange(new object[] {
            "Menu",
            "Ilość odwiedzających",
            "Ceny biletów"});
            this.comboBoxForVisitors.Location = new System.Drawing.Point(1377, 481);
            this.comboBoxForVisitors.Name = "comboBoxForVisitors";
            this.comboBoxForVisitors.Size = new System.Drawing.Size(213, 33);
            this.comboBoxForVisitors.TabIndex = 4;
            this.comboBoxForVisitors.Text = "Ilość odwiedzających";
            // 
            // buttonShowEmployees
            // 
            this.buttonShowEmployees.AutoSize = true;
            this.buttonShowEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonShowEmployees.Location = new System.Drawing.Point(188, 39);
            this.buttonShowEmployees.Name = "buttonShowEmployees";
            this.buttonShowEmployees.Size = new System.Drawing.Size(152, 41);
            this.buttonShowEmployees.TabIndex = 8;
            this.buttonShowEmployees.Text = "Wyświetl";
            this.buttonShowEmployees.UseVisualStyleBackColor = true;
            this.buttonShowEmployees.Click += new System.EventHandler(this.buttonShowEmployees_Click);
            // 
            // textBoxEmployeesSurnameLike
            // 
            this.textBoxEmployeesSurnameLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxEmployeesSurnameLike.Location = new System.Drawing.Point(24, 46);
            this.textBoxEmployeesSurnameLike.Name = "textBoxEmployeesSurnameLike";
            this.textBoxEmployeesSurnameLike.Size = new System.Drawing.Size(140, 26);
            this.textBoxEmployeesSurnameLike.TabIndex = 9;
            // 
            // buttonShowWorkSchedule
            // 
            this.buttonShowWorkSchedule.AutoSize = true;
            this.buttonShowWorkSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonShowWorkSchedule.Location = new System.Drawing.Point(368, 39);
            this.buttonShowWorkSchedule.Name = "buttonShowWorkSchedule";
            this.buttonShowWorkSchedule.Size = new System.Drawing.Size(152, 41);
            this.buttonShowWorkSchedule.TabIndex = 11;
            this.buttonShowWorkSchedule.Text = "Wyświetl";
            this.buttonShowWorkSchedule.UseVisualStyleBackColor = true;
            this.buttonShowWorkSchedule.Click += new System.EventHandler(this.buttonShowWorkSchedule_Click);
            // 
            // checkBoxFeedingInfo
            // 
            this.checkBoxFeedingInfo.AutoSize = true;
            this.checkBoxFeedingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.checkBoxFeedingInfo.Location = new System.Drawing.Point(888, 525);
            this.checkBoxFeedingInfo.Name = "checkBoxFeedingInfo";
            this.checkBoxFeedingInfo.Size = new System.Drawing.Size(252, 30);
            this.checkBoxFeedingInfo.TabIndex = 7;
            this.checkBoxFeedingInfo.Text = "Informacje o karmieniu";
            this.checkBoxFeedingInfo.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnimalsInfo
            // 
            this.checkBoxAnimalsInfo.AutoSize = true;
            this.checkBoxAnimalsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.checkBoxAnimalsInfo.Location = new System.Drawing.Point(888, 485);
            this.checkBoxAnimalsInfo.Name = "checkBoxAnimalsInfo";
            this.checkBoxAnimalsInfo.Size = new System.Drawing.Size(259, 30);
            this.checkBoxAnimalsInfo.TabIndex = 6;
            this.checkBoxAnimalsInfo.Text = "Informacje o zwierzęciu";
            this.checkBoxAnimalsInfo.UseVisualStyleBackColor = true;
            // 
            // buttonShowAnimals
            // 
            this.buttonShowAnimals.AutoSize = true;
            this.buttonShowAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonShowAnimals.Location = new System.Drawing.Point(604, 479);
            this.buttonShowAnimals.Name = "buttonShowAnimals";
            this.buttonShowAnimals.Size = new System.Drawing.Size(255, 85);
            this.buttonShowAnimals.TabIndex = 5;
            this.buttonShowAnimals.Text = "Wyświetl zwierzęta";
            this.buttonShowAnimals.UseVisualStyleBackColor = true;
            this.buttonShowAnimals.Click += new System.EventHandler(this.buttonShowAnimals_Click);
            // 
            // groupBoxEmployees
            // 
            this.groupBoxEmployees.Controls.Add(this.label2);
            this.groupBoxEmployees.Controls.Add(this.buttonShowEmployees);
            this.groupBoxEmployees.Controls.Add(this.labelShowWorkSchedule);
            this.groupBoxEmployees.Controls.Add(this.label1);
            this.groupBoxEmployees.Controls.Add(this.textBoxEmployeesSurnameLike);
            this.groupBoxEmployees.Controls.Add(this.buttonShowWorkSchedule);
            this.groupBoxEmployees.Location = new System.Drawing.Point(30, 479);
            this.groupBoxEmployees.Name = "groupBoxEmployees";
            this.groupBoxEmployees.Size = new System.Drawing.Size(527, 91);
            this.groupBoxEmployees.TabIndex = 13;
            this.groupBoxEmployees.TabStop = false;
            this.groupBoxEmployees.Text = "Pracownicy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(185, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pracownicy i ich płace";
            // 
            // labelShowWorkSchedule
            // 
            this.labelShowWorkSchedule.AutoSize = true;
            this.labelShowWorkSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelShowWorkSchedule.Location = new System.Drawing.Point(365, 19);
            this.labelShowWorkSchedule.Name = "labelShowWorkSchedule";
            this.labelShowWorkSchedule.Size = new System.Drawing.Size(156, 17);
            this.labelShowWorkSchedule.TabIndex = 17;
            this.labelShowWorkSchedule.Text = "Grafik pracy opiekunów";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Szukaj po nazwisku";
            // 
            // labelEmployees
            // 
            this.labelEmployees.AutoSize = true;
            this.labelEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelEmployees.Location = new System.Drawing.Point(191, 94);
            this.labelEmployees.Name = "labelEmployees";
            this.labelEmployees.Size = new System.Drawing.Size(154, 31);
            this.labelEmployees.TabIndex = 14;
            this.labelEmployees.Text = "Pracownicy";
            // 
            // labelAnimals
            // 
            this.labelAnimals.AutoSize = true;
            this.labelAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelAnimals.Location = new System.Drawing.Point(796, 94);
            this.labelAnimals.Name = "labelAnimals";
            this.labelAnimals.Size = new System.Drawing.Size(133, 31);
            this.labelAnimals.TabIndex = 15;
            this.labelAnimals.Text = "Zwierzęta";
            // 
            // labelForVisitors
            // 
            this.labelForVisitors.AutoSize = true;
            this.labelForVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelForVisitors.Location = new System.Drawing.Point(1280, 94);
            this.labelForVisitors.Name = "labelForVisitors";
            this.labelForVisitors.Size = new System.Drawing.Size(255, 31);
            this.labelForVisitors.TabIndex = 16;
            this.labelForVisitors.Text = "Dla odwiedzających";
            // 
            // labelZoo
            // 
            this.labelZoo.AutoSize = true;
            this.labelZoo.Font = new System.Drawing.Font("Perpetua", 50.25F, System.Drawing.FontStyle.Italic);
            this.labelZoo.Location = new System.Drawing.Point(789, 9);
            this.labelZoo.Name = "labelZoo";
            this.labelZoo.Size = new System.Drawing.Size(143, 77);
            this.labelZoo.TabIndex = 17;
            this.labelZoo.Text = "ZOO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1626, 590);
            this.Controls.Add(this.labelZoo);
            this.Controls.Add(this.labelForVisitors);
            this.Controls.Add(this.labelAnimals);
            this.Controls.Add(this.labelEmployees);
            this.Controls.Add(this.groupBoxEmployees);
            this.Controls.Add(this.buttonShowAnimals);
            this.Controls.Add(this.checkBoxAnimalsInfo);
            this.Controls.Add(this.checkBoxFeedingInfo);
            this.Controls.Add(this.comboBoxForVisitors);
            this.Controls.Add(this.buttonForVisitors);
            this.Controls.Add(this.dataGridViewForVisitors);
            this.Controls.Add(this.dataGridViewAnimals);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForVisitors)).EndInit();
            this.groupBoxEmployees.ResumeLayout(false);
            this.groupBoxEmployees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridView dataGridViewAnimals;
        private System.Windows.Forms.DataGridView dataGridViewForVisitors;
        private System.Windows.Forms.Button buttonForVisitors;
        private System.Windows.Forms.ComboBox comboBoxForVisitors;
        private System.Windows.Forms.Button buttonShowEmployees;
        private System.Windows.Forms.TextBox textBoxEmployeesSurnameLike;
        private System.Windows.Forms.Button buttonShowWorkSchedule;
        private System.Windows.Forms.CheckBox checkBoxFeedingInfo;
        private System.Windows.Forms.CheckBox checkBoxAnimalsInfo;
        private System.Windows.Forms.Button buttonShowAnimals;
        private System.Windows.Forms.GroupBox groupBoxEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmployees;
        private System.Windows.Forms.Label labelAnimals;
        private System.Windows.Forms.Label labelForVisitors;
        private System.Windows.Forms.Label labelShowWorkSchedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelZoo;
    }
}

