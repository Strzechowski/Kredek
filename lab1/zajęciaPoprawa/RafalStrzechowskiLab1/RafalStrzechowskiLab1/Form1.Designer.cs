namespace RafalStrzechowskiLab1
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelMyName = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.labelPlus = new System.Windows.Forms.Label();
            this.labelEquals = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.textBoxMultiplication = new System.Windows.Forms.TextBox();
            this.textBoxNumber3 = new System.Windows.Forms.TextBox();
            this.textBoxNumber4 = new System.Windows.Forms.TextBox();
            this.labelMultiply = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.buttonNewWindow = new System.Windows.Forms.Button();
            this.textBoxNumberToChange = new System.Windows.Forms.TextBox();
            this.labelNewWindow = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.labelChange = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonStart.Location = new System.Drawing.Point(141, 90);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(133, 74);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelMyName
            // 
            this.labelMyName.AutoSize = true;
            this.labelMyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyName.Location = new System.Drawing.Point(3, 9);
            this.labelMyName.Name = "labelMyName";
            this.labelMyName.Size = new System.Drawing.Size(444, 57);
            this.labelMyName.TabIndex = 2;
            this.labelMyName.Text = "Rafal Strzechowski";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(168, 343);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "Zmień";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumber.Location = new System.Drawing.Point(535, 68);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(313, 57);
            this.labelNumber.TabIndex = 6;
            this.labelNumber.Text = "Wpisz liczby:";
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.Location = new System.Drawing.Point(653, 172);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber2.TabIndex = 7;
            this.textBoxNumber2.Text = "0";
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlus.Location = new System.Drawing.Point(593, 155);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(54, 57);
            this.labelPlus.TabIndex = 8;
            this.labelPlus.Text = "+";
            // 
            // labelEquals
            // 
            this.labelEquals.AutoSize = true;
            this.labelEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEquals.Location = new System.Drawing.Point(777, 155);
            this.labelEquals.Name = "labelEquals";
            this.labelEquals.Size = new System.Drawing.Size(54, 57);
            this.labelEquals.TabIndex = 9;
            this.labelEquals.Text = "=";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(837, 172);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSum.TabIndex = 10;
            this.textBoxSum.Text = "0";
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(667, 265);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(75, 23);
            this.buttonCount.TabIndex = 11;
            this.buttonCount.Text = "Oblicz";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textBoxMultiplication
            // 
            this.textBoxMultiplication.Location = new System.Drawing.Point(837, 219);
            this.textBoxMultiplication.Name = "textBoxMultiplication";
            this.textBoxMultiplication.Size = new System.Drawing.Size(100, 20);
            this.textBoxMultiplication.TabIndex = 12;
            this.textBoxMultiplication.Text = "0";
            // 
            // textBoxNumber3
            // 
            this.textBoxNumber3.Location = new System.Drawing.Point(487, 219);
            this.textBoxNumber3.Name = "textBoxNumber3";
            this.textBoxNumber3.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber3.TabIndex = 13;
            this.textBoxNumber3.Text = "0";
            // 
            // textBoxNumber4
            // 
            this.textBoxNumber4.Location = new System.Drawing.Point(653, 219);
            this.textBoxNumber4.Name = "textBoxNumber4";
            this.textBoxNumber4.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber4.TabIndex = 14;
            this.textBoxNumber4.Text = "0";
            // 
            // labelMultiply
            // 
            this.labelMultiply.AutoSize = true;
            this.labelMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMultiply.Location = new System.Drawing.Point(593, 211);
            this.labelMultiply.Name = "labelMultiply";
            this.labelMultiply.Size = new System.Drawing.Size(44, 57);
            this.labelMultiply.TabIndex = 15;
            this.labelMultiply.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(777, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 57);
            this.label4.TabIndex = 17;
            this.label4.Text = "=";
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(666, 454);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(75, 23);
            this.buttonNewWindow.TabIndex = 20;
            this.buttonNewWindow.Text = "Nowe Okno";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // textBoxNumberToChange
            // 
            this.textBoxNumberToChange.Location = new System.Drawing.Point(131, 317);
            this.textBoxNumberToChange.Name = "textBoxNumberToChange";
            this.textBoxNumberToChange.Size = new System.Drawing.Size(152, 20);
            this.textBoxNumberToChange.TabIndex = 21;
            this.textBoxNumberToChange.Text = "0";
            this.textBoxNumberToChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNewWindow
            // 
            this.labelNewWindow.AutoSize = true;
            this.labelNewWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.labelNewWindow.Location = new System.Drawing.Point(449, 441);
            this.labelNewWindow.Name = "labelNewWindow";
            this.labelNewWindow.Size = new System.Drawing.Size(198, 38);
            this.labelNewWindow.TabIndex = 23;
            this.labelNewWindow.Text = "Nowe Okno:";
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.SystemColors.Info;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonStop.Location = new System.Drawing.Point(141, 184);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(133, 74);
            this.buttonStop.TabIndex = 24;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(487, 172);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 28;
            this.textBoxNumber.Text = "0";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(156, 264);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 29;
            this.textBoxResult.Text = "Komunikat";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Location = new System.Drawing.Point(653, 382);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimer.TabIndex = 30;
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelChange.Location = new System.Drawing.Point(115, 287);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(185, 24);
            this.labelChange.TabIndex = 31;
            this.labelChange.Text = "Wpisz liczbę i zmień:";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.labelTimer.Location = new System.Drawing.Point(528, 367);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(109, 38);
            this.labelTimer.TabIndex = 32;
            this.labelTimer.Text = "Timer:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 552);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.textBoxTimer);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelNewWindow);
            this.Controls.Add(this.textBoxNumberToChange);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMultiply);
            this.Controls.Add(this.textBoxNumber4);
            this.Controls.Add(this.textBoxNumber3);
            this.Controls.Add(this.textBoxMultiplication);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.labelEquals);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.textBoxNumber2);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.labelMyName);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormMain";
            this.Text = "Główne Okno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelMyName;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.Label labelEquals;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textBoxMultiplication;
        private System.Windows.Forms.TextBox textBoxNumber3;
        private System.Windows.Forms.TextBox textBoxNumber4;
        private System.Windows.Forms.Label labelMultiply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.Button buttonNewWindow;
        private System.Windows.Forms.TextBox textBoxNumberToChange;
        private System.Windows.Forms.Label labelNewWindow;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Label labelTimer;
    }
}

