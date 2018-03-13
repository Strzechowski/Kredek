namespace ZadanieDomoweLab7
{
    partial class FormEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnd));
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.labelNickname = new System.Windows.Forms.Label();
            this.buttonSaveScore = new System.Windows.Forms.Button();
            this.dataGridViewRanking = new System.Windows.Forms.DataGridView();
            this.labelRankingInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.Location = new System.Drawing.Point(348, 35);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.ReadOnly = true;
            this.textBoxScore.Size = new System.Drawing.Size(131, 57);
            this.textBoxScore.TabIndex = 0;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(22, 38);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(320, 56);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Twój wynik:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(389, 285);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(164, 31);
            this.textBoxSurname.TabIndex = 13;
            this.textBoxSurname.Text = "Kowalski";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(266, 285);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(98, 23);
            this.labelSurname.TabIndex = 12;
            this.labelSurname.Text = "Nazwisko:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(389, 246);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(164, 31);
            this.textBoxName.TabIndex = 11;
            this.textBoxName.Text = "Jan";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(315, 247);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 23);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Imię:";
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNickname.Location = new System.Drawing.Point(391, 323);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(164, 31);
            this.textBoxNickname.TabIndex = 9;
            this.textBoxNickname.Text = "Nick";
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNickname.Location = new System.Drawing.Point(315, 324);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(53, 23);
            this.labelNickname.TabIndex = 8;
            this.labelNickname.Text = "Nick:";
            // 
            // buttonSaveScore
            // 
            this.buttonSaveScore.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveScore.Location = new System.Drawing.Point(32, 247);
            this.buttonSaveScore.Name = "buttonSaveScore";
            this.buttonSaveScore.Size = new System.Drawing.Size(202, 107);
            this.buttonSaveScore.TabIndex = 14;
            this.buttonSaveScore.Text = "Zapisz swój wynik w rankingu";
            this.buttonSaveScore.UseVisualStyleBackColor = true;
            this.buttonSaveScore.Click += new System.EventHandler(this.buttonSaveScore_Click);
            // 
            // dataGridViewRanking
            // 
            this.dataGridViewRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRanking.Location = new System.Drawing.Point(593, 25);
            this.dataGridViewRanking.Name = "dataGridViewRanking";
            this.dataGridViewRanking.ReadOnly = true;
            this.dataGridViewRanking.Size = new System.Drawing.Size(442, 329);
            this.dataGridViewRanking.TabIndex = 16;
            // 
            // labelRankingInfo
            // 
            this.labelRankingInfo.AutoSize = true;
            this.labelRankingInfo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRankingInfo.Location = new System.Drawing.Point(63, 185);
            this.labelRankingInfo.Name = "labelRankingInfo";
            this.labelRankingInfo.Size = new System.Drawing.Size(485, 30);
            this.labelRankingInfo.TabIndex = 17;
            this.labelRankingInfo.Text = "Podaj dane, aby widnieć w rankingu";
            // 
            // FormEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1072, 390);
            this.Controls.Add(this.labelRankingInfo);
            this.Controls.Add(this.dataGridViewRanking);
            this.Controls.Add(this.buttonSaveScore);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxNickname);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podsumowanie gry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.Button buttonSaveScore;
        private System.Windows.Forms.DataGridView dataGridViewRanking;
        private System.Windows.Forms.Label labelRankingInfo;
    }
}