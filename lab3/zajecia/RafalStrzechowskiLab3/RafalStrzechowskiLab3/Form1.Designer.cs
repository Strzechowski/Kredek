namespace RafalStrzechowskiLab3
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
            this.dataGridViewFilm = new System.Windows.Forms.DataGridView();
            this.buttonFilm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.nameLabel.Location = new System.Drawing.Point(38, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(314, 39);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Rafał Strzechowski";
            // 
            // dataGridViewFilm
            // 
            this.dataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilm.Location = new System.Drawing.Point(36, 83);
            this.dataGridViewFilm.Name = "dataGridViewFilm";
            this.dataGridViewFilm.Size = new System.Drawing.Size(492, 398);
            this.dataGridViewFilm.TabIndex = 1;
            // 
            // buttonFilm
            // 
            this.buttonFilm.Location = new System.Drawing.Point(644, 208);
            this.buttonFilm.Name = "buttonFilm";
            this.buttonFilm.Size = new System.Drawing.Size(99, 52);
            this.buttonFilm.TabIndex = 2;
            this.buttonFilm.Text = "Wszystkie Fimy";
            this.buttonFilm.UseVisualStyleBackColor = true;
            this.buttonFilm.Click += new System.EventHandler(this.buttonFilm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 546);
            this.Controls.Add(this.buttonFilm);
            this.Controls.Add(this.dataGridViewFilm);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView dataGridViewFilm;
        private System.Windows.Forms.Button buttonFilm;
    }
}

