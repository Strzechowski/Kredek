namespace ZadanieDomoweLab1
{
    partial class Form2
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
            this.winLabel = new System.Windows.Forms.Label();
            this.dumplingPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dumplingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold);
            this.winLabel.Location = new System.Drawing.Point(173, 132);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(805, 47);
            this.winLabel.TabIndex = 0;
            this.winLabel.Text = "Zjadłeś truflowego pieroga!! Gratulaacje!";
            // 
            // dumplingPictureBox
            // 
            this.dumplingPictureBox.Image = global::ZadanieDomoweLab1.Properties.Resources.Pierog;
            this.dumplingPictureBox.Location = new System.Drawing.Point(356, 267);
            this.dumplingPictureBox.Name = "dumplingPictureBox";
            this.dumplingPictureBox.Size = new System.Drawing.Size(428, 252);
            this.dumplingPictureBox.TabIndex = 1;
            this.dumplingPictureBox.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1181, 605);
            this.Controls.Add(this.dumplingPictureBox);
            this.Controls.Add(this.winLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dumplingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.PictureBox dumplingPictureBox;
    }
}