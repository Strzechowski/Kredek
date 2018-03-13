namespace ZadanieDomoweLab4
{
    partial class FormZoo
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
            this.buttonShowData = new System.Windows.Forms.Button();
            this.dataGridViewShowData = new System.Windows.Forms.DataGridView();
            this.groupBoxEmployees = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonMakePdf = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.labelWorkType = new System.Windows.Forms.Label();
            this.comboBoxWorkType = new System.Windows.Forms.ComboBox();
            this.labelPesel = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.buttonSearchEmployee = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.comboBoxShowData = new System.Windows.Forms.ComboBox();
            this.buttonMakeCsvTable = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelZoo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).BeginInit();
            this.groupBoxEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowData
            // 
            this.buttonShowData.BackColor = System.Drawing.Color.Ivory;
            this.buttonShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.buttonShowData.Location = new System.Drawing.Point(792, 279);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(190, 69);
            this.buttonShowData.TabIndex = 0;
            this.buttonShowData.Text = "Wyświetl tabelę";
            this.buttonShowData.UseVisualStyleBackColor = false;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // dataGridViewShowData
            // 
            this.dataGridViewShowData.BackgroundColor = System.Drawing.Color.Chocolate;
            this.dataGridViewShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowData.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewShowData.Name = "dataGridViewShowData";
            this.dataGridViewShowData.Size = new System.Drawing.Size(749, 336);
            this.dataGridViewShowData.TabIndex = 1;
            // 
            // groupBoxEmployees
            // 
            this.groupBoxEmployees.BackColor = System.Drawing.Color.Chocolate;
            this.groupBoxEmployees.Controls.Add(this.labelId);
            this.groupBoxEmployees.Controls.Add(this.buttonMakePdf);
            this.groupBoxEmployees.Controls.Add(this.textBoxId);
            this.groupBoxEmployees.Controls.Add(this.buttonRemoveEmployee);
            this.groupBoxEmployees.Controls.Add(this.buttonEditEmployee);
            this.groupBoxEmployees.Controls.Add(this.labelWorkType);
            this.groupBoxEmployees.Controls.Add(this.comboBoxWorkType);
            this.groupBoxEmployees.Controls.Add(this.labelPesel);
            this.groupBoxEmployees.Controls.Add(this.labelSurname);
            this.groupBoxEmployees.Controls.Add(this.labelName);
            this.groupBoxEmployees.Controls.Add(this.textBoxPesel);
            this.groupBoxEmployees.Controls.Add(this.textBoxSurname);
            this.groupBoxEmployees.Controls.Add(this.buttonSearchEmployee);
            this.groupBoxEmployees.Controls.Add(this.textBoxName);
            this.groupBoxEmployees.Controls.Add(this.buttonAddEmployee);
            this.groupBoxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBoxEmployees.Location = new System.Drawing.Point(12, 354);
            this.groupBoxEmployees.Name = "groupBoxEmployees";
            this.groupBoxEmployees.Size = new System.Drawing.Size(749, 257);
            this.groupBoxEmployees.TabIndex = 2;
            this.groupBoxEmployees.TabStop = false;
            this.groupBoxEmployees.Text = "Edycja Pracowników";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelId.Location = new System.Drawing.Point(303, 225);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(276, 18);
            this.labelId.TabIndex = 14;
            this.labelId.Text = "Id pracownika do edycji/usunięcia/PDF\'a:";
            // 
            // buttonMakePdf
            // 
            this.buttonMakePdf.BackColor = System.Drawing.Color.Ivory;
            this.buttonMakePdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonMakePdf.Location = new System.Drawing.Point(6, 144);
            this.buttonMakePdf.Name = "buttonMakePdf";
            this.buttonMakePdf.Size = new System.Drawing.Size(171, 98);
            this.buttonMakePdf.TabIndex = 14;
            this.buttonMakePdf.Text = "Stwórz PDF z rozliczeniem pracownika";
            this.buttonMakePdf.UseVisualStyleBackColor = false;
            this.buttonMakePdf.Click += new System.EventHandler(this.buttonMakePdf_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxId.Location = new System.Drawing.Point(589, 221);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(133, 26);
            this.textBoxId.TabIndex = 13;
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.BackColor = System.Drawing.Color.Ivory;
            this.buttonRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(6, 88);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(171, 44);
            this.buttonRemoveEmployee.TabIndex = 12;
            this.buttonRemoveEmployee.Text = "Usuń ";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = false;
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.buttonRemoveEmployee_Click);
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.BackColor = System.Drawing.Color.Ivory;
            this.buttonEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonEditEmployee.Location = new System.Drawing.Point(189, 32);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(171, 44);
            this.buttonEditEmployee.TabIndex = 11;
            this.buttonEditEmployee.Text = "Edytuj ";
            this.buttonEditEmployee.UseVisualStyleBackColor = false;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // labelWorkType
            // 
            this.labelWorkType.AutoSize = true;
            this.labelWorkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelWorkType.Location = new System.Drawing.Point(470, 182);
            this.labelWorkType.Name = "labelWorkType";
            this.labelWorkType.Size = new System.Drawing.Size(112, 20);
            this.labelWorkType.TabIndex = 10;
            this.labelWorkType.Text = "Rodzaj pracy:";
            // 
            // comboBoxWorkType
            // 
            this.comboBoxWorkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxWorkType.FormattingEnabled = true;
            this.comboBoxWorkType.Items.AddRange(new object[] {
            "Manager",
            "Ogrodnik",
            "Opiekun Zwierząt"});
            this.comboBoxWorkType.Location = new System.Drawing.Point(589, 174);
            this.comboBoxWorkType.Name = "comboBoxWorkType";
            this.comboBoxWorkType.Size = new System.Drawing.Size(133, 28);
            this.comboBoxWorkType.TabIndex = 3;
            this.comboBoxWorkType.Text = "Manager";
            // 
            // labelPesel
            // 
            this.labelPesel.AutoSize = true;
            this.labelPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelPesel.Location = new System.Drawing.Point(526, 134);
            this.labelPesel.Name = "labelPesel";
            this.labelPesel.Size = new System.Drawing.Size(56, 20);
            this.labelPesel.TabIndex = 9;
            this.labelPesel.Text = "Pesel:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelSurname.Location = new System.Drawing.Point(493, 88);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(86, 20);
            this.labelSurname.TabIndex = 8;
            this.labelSurname.Text = "Nazwisko:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelName.Location = new System.Drawing.Point(534, 42);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 20);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Imię:";
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxPesel.Location = new System.Drawing.Point(589, 129);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(133, 26);
            this.textBoxPesel.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxSurname.Location = new System.Drawing.Point(589, 84);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(133, 26);
            this.textBoxSurname.TabIndex = 5;
            // 
            // buttonSearchEmployee
            // 
            this.buttonSearchEmployee.BackColor = System.Drawing.Color.Ivory;
            this.buttonSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonSearchEmployee.Location = new System.Drawing.Point(189, 88);
            this.buttonSearchEmployee.Name = "buttonSearchEmployee";
            this.buttonSearchEmployee.Size = new System.Drawing.Size(171, 44);
            this.buttonSearchEmployee.TabIndex = 3;
            this.buttonSearchEmployee.Text = "Wyszukaj po nazwisku";
            this.buttonSearchEmployee.UseVisualStyleBackColor = false;
            this.buttonSearchEmployee.Click += new System.EventHandler(this.buttonSearchEmployee_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxName.Location = new System.Drawing.Point(589, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 26);
            this.textBoxName.TabIndex = 4;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.Ivory;
            this.buttonAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonAddEmployee.Location = new System.Drawing.Point(6, 32);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(171, 44);
            this.buttonAddEmployee.TabIndex = 3;
            this.buttonAddEmployee.Text = "Dodaj ";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // comboBoxShowData
            // 
            this.comboBoxShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBoxShowData.FormattingEnabled = true;
            this.comboBoxShowData.Items.AddRange(new object[] {
            "Zwierząt",
            "Pracowników"});
            this.comboBoxShowData.Location = new System.Drawing.Point(1003, 300);
            this.comboBoxShowData.Name = "comboBoxShowData";
            this.comboBoxShowData.Size = new System.Drawing.Size(204, 32);
            this.comboBoxShowData.TabIndex = 4;
            this.comboBoxShowData.Text = "Pracowników";
            // 
            // buttonMakeCsvTable
            // 
            this.buttonMakeCsvTable.BackColor = System.Drawing.Color.Ivory;
            this.buttonMakeCsvTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonMakeCsvTable.Location = new System.Drawing.Point(792, 12);
            this.buttonMakeCsvTable.Name = "buttonMakeCsvTable";
            this.buttonMakeCsvTable.Size = new System.Drawing.Size(441, 94);
            this.buttonMakeCsvTable.TabIndex = 9;
            this.buttonMakeCsvTable.Text = "Zapisz aktualną tabelę";
            this.buttonMakeCsvTable.UseVisualStyleBackColor = false;
            this.buttonMakeCsvTable.Click += new System.EventHandler(this.buttonMakeCsvTable_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxPath.Location = new System.Drawing.Point(1003, 135);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(204, 29);
            this.textBoxPath.TabIndex = 10;
            this.textBoxPath.Text = "Dane";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxFileName.Location = new System.Drawing.Point(1003, 179);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(204, 29);
            this.textBoxFileName.TabIndex = 11;
            this.textBoxFileName.Text = "C:\\Users\\rafal\\Desktop\\";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.BackColor = System.Drawing.Color.Ivory;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelFileName.Location = new System.Drawing.Point(827, 181);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(145, 25);
            this.labelFileName.TabIndex = 13;
            this.labelFileName.Text = "Ścieżka pliku:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.BackColor = System.Drawing.Color.Ivory;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelPath.Location = new System.Drawing.Point(838, 137);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(134, 25);
            this.labelPath.TabIndex = 12;
            this.labelPath.Text = "Nazwa pliku:";
            // 
            // labelZoo
            // 
            this.labelZoo.AutoSize = true;
            this.labelZoo.BackColor = System.Drawing.Color.Ivory;
            this.labelZoo.Font = new System.Drawing.Font("Lucida Fax", 71.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoo.Location = new System.Drawing.Point(786, 435);
            this.labelZoo.Name = "labelZoo";
            this.labelZoo.Size = new System.Drawing.Size(447, 109);
            this.labelZoo.TabIndex = 17;
            this.labelZoo.Text = "ZOO v.2";
            // 
            // FormZoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZadanieDomoweLab4.Properties.Resources.giraffeV2;
            this.ClientSize = new System.Drawing.Size(1245, 621);
            this.Controls.Add(this.labelZoo);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonMakeCsvTable);
            this.Controls.Add(this.comboBoxShowData);
            this.Controls.Add(this.groupBoxEmployees);
            this.Controls.Add(this.buttonShowData);
            this.Controls.Add(this.dataGridViewShowData);
            this.Name = "FormZoo";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).EndInit();
            this.groupBoxEmployees.ResumeLayout(false);
            this.groupBoxEmployees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.DataGridView dataGridViewShowData;
        private System.Windows.Forms.GroupBox groupBoxEmployees;
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Label labelPesel;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWorkType;
        private System.Windows.Forms.ComboBox comboBoxWorkType;
        private System.Windows.Forms.Button buttonRemoveEmployee;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Button buttonSearchEmployee;
        private System.Windows.Forms.ComboBox comboBoxShowData;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonMakeCsvTable;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonMakePdf;
        private System.Windows.Forms.Label labelZoo;
    }
}

