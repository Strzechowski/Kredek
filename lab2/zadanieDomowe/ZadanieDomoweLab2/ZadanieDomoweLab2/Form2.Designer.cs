namespace ZadanieDomoweLab2
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
            this.SuspendLayout();
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.IndianRed;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.winLabel.Location = new System.Drawing.Point(300, 194);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(471, 54);
            this.winLabel.TabIndex = 0;
            this.winLabel.Text = "Gratulacje! Wygrałeś!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZadanieDomoweLab2.Properties.Resources.pierogi;
            this.ClientSize = new System.Drawing.Size(1111, 616);
            this.Controls.Add(this.winLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winLabel;
    }
}