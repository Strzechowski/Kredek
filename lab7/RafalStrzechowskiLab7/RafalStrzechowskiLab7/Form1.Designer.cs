namespace RafalStrzechowskiLab7
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
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelMyName = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelPoitionName = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxPositionName = new System.Windows.Forms.TextBox();
            this.buttonGraphics = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.notifyIconMonitor = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonBackground = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDownload
            // 
            this.buttonDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonDownload.Location = new System.Drawing.Point(61, 104);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(204, 54);
            this.buttonDownload.TabIndex = 0;
            this.buttonDownload.Text = "Pobierz";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonSend.Location = new System.Drawing.Point(61, 164);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(204, 54);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Wyślij";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelMyName
            // 
            this.labelMyName.AutoSize = true;
            this.labelMyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.labelMyName.Location = new System.Drawing.Point(53, 25);
            this.labelMyName.Name = "labelMyName";
            this.labelMyName.Size = new System.Drawing.Size(373, 47);
            this.labelMyName.TabIndex = 2;
            this.labelMyName.Text = "Rafal Strzechowski";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelX.Location = new System.Drawing.Point(55, 230);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(40, 31);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelY.Location = new System.Drawing.Point(55, 261);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(40, 31);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y:";
            // 
            // labelPoitionName
            // 
            this.labelPoitionName.AutoSize = true;
            this.labelPoitionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelPoitionName.Location = new System.Drawing.Point(55, 292);
            this.labelPoitionName.Name = "labelPoitionName";
            this.labelPoitionName.Size = new System.Drawing.Size(94, 31);
            this.labelPoitionName.TabIndex = 5;
            this.labelPoitionName.Text = "Name:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(165, 241);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 6;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(165, 272);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 7;
            // 
            // textBoxPositionName
            // 
            this.textBoxPositionName.Location = new System.Drawing.Point(165, 304);
            this.textBoxPositionName.Name = "textBoxPositionName";
            this.textBoxPositionName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPositionName.TabIndex = 8;
            // 
            // buttonGraphics
            // 
            this.buttonGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonGraphics.Location = new System.Drawing.Point(61, 343);
            this.buttonGraphics.Name = "buttonGraphics";
            this.buttonGraphics.Size = new System.Drawing.Size(204, 54);
            this.buttonGraphics.TabIndex = 9;
            this.buttonGraphics.Text = "Grafika";
            this.buttonGraphics.UseVisualStyleBackColor = true;
            this.buttonGraphics.Click += new System.EventHandler(this.buttonGraphics_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonMoveUp.Location = new System.Drawing.Point(612, 135);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(115, 54);
            this.buttonMoveUp.TabIndex = 10;
            this.buttonMoveUp.Text = "Góra";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonMoveDown.Location = new System.Drawing.Point(612, 241);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(115, 54);
            this.buttonMoveDown.TabIndex = 11;
            this.buttonMoveDown.Text = "Dół";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonMoveRight.Location = new System.Drawing.Point(733, 187);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(115, 54);
            this.buttonMoveRight.TabIndex = 12;
            this.buttonMoveRight.Text = "Prawo";
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonMoveLeft.Location = new System.Drawing.Point(491, 187);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(115, 54);
            this.buttonMoveLeft.TabIndex = 13;
            this.buttonMoveLeft.Text = "Lewo";
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // notifyIconMonitor
            // 
            this.notifyIconMonitor.Text = "monitor";
            this.notifyIconMonitor.Visible = true;
            this.notifyIconMonitor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMonitor_MouseDoubleClick);
            // 
            // buttonBackground
            // 
            this.buttonBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonBackground.Location = new System.Drawing.Point(61, 421);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(204, 54);
            this.buttonBackground.TabIndex = 14;
            this.buttonBackground.Text = "Praca w tle";
            this.buttonBackground.UseVisualStyleBackColor = true;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonStart.Location = new System.Drawing.Point(495, 430);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(144, 54);
            this.buttonStart.TabIndex = 15;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 624);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonBackground);
            this.Controls.Add(this.buttonMoveLeft);
            this.Controls.Add(this.buttonMoveRight);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.buttonGraphics);
            this.Controls.Add(this.textBoxPositionName);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelPoitionName);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelMyName);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonDownload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelMyName;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelPoitionName;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxPositionName;
        private System.Windows.Forms.Button buttonGraphics;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.NotifyIcon notifyIconMonitor;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.Button buttonStart;
    }
}

