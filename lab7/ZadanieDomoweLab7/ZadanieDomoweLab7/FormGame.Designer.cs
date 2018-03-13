namespace ZadanieDomoweLab7
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.timerMoveBalls = new System.Windows.Forms.Timer(this.components);
            this.timerSpawnBalls = new System.Windows.Forms.Timer(this.components);
            this.timerDifficultyLevel = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerMoveBalls
            // 
            this.timerMoveBalls.Tick += new System.EventHandler(this.timerMoveBalls_Tick);
            // 
            // timerSpawnBalls
            // 
            this.timerSpawnBalls.Interval = 400;
            this.timerSpawnBalls.Tick += new System.EventHandler(this.timerSpawnBalls_Tick);
            // 
            // timerDifficultyLevel
            // 
            this.timerDifficultyLevel.Interval = 1000;
            this.timerDifficultyLevel.Tick += new System.EventHandler(this.timerDifficultyLevel_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1462, 558);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGame";
            this.Text = "Śnieżne Płatki";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormGame_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerMoveBalls;
        private System.Windows.Forms.Timer timerSpawnBalls;
        private System.Windows.Forms.Timer timerDifficultyLevel;
    }
}

