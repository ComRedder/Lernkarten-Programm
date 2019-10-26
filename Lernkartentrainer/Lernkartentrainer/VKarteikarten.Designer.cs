namespace Lernkartentrainer
{
    partial class VKarteikarten
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSide2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonProve = new System.Windows.Forms.Button();
            this.pnlHeader2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelWort = new System.Windows.Forms.Label();
            this.labelLösung = new System.Windows.Forms.Label();
            this.textBoxVokabelInput = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pnlWrongAnswer = new System.Windows.Forms.Panel();
            this.pnlRightAnswer = new System.Windows.Forms.Panel();
            this.labelRight = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxWrong = new System.Windows.Forms.PictureBox();
            this.pnlSide2.SuspendLayout();
            this.pnlHeader2.SuspendLayout();
            this.pnlWrongAnswer.SuspendLayout();
            this.pnlRightAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide2
            // 
            this.pnlSide2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlSide2.Controls.Add(this.buttonClose);
            this.pnlSide2.Controls.Add(this.buttonNext);
            this.pnlSide2.Controls.Add(this.buttonProve);
            this.pnlSide2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide2.Location = new System.Drawing.Point(0, 0);
            this.pnlSide2.Name = "pnlSide2";
            this.pnlSide2.Size = new System.Drawing.Size(289, 769);
            this.pnlSide2.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(12, 678);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(258, 83);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Schließen";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(12, 343);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(258, 83);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Weiter";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonProve
            // 
            this.buttonProve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProve.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProve.ForeColor = System.Drawing.Color.White;
            this.buttonProve.Location = new System.Drawing.Point(12, 254);
            this.buttonProve.Name = "buttonProve";
            this.buttonProve.Size = new System.Drawing.Size(258, 83);
            this.buttonProve.TabIndex = 2;
            this.buttonProve.Text = "Überprüfen";
            this.buttonProve.UseVisualStyleBackColor = true;
            this.buttonProve.Click += new System.EventHandler(this.buttonProve_Click);
            // 
            // pnlHeader2
            // 
            this.pnlHeader2.BackColor = System.Drawing.Color.DarkRed;
            this.pnlHeader2.Controls.Add(this.label5);
            this.pnlHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader2.Location = new System.Drawing.Point(289, 0);
            this.pnlHeader2.Name = "pnlHeader2";
            this.pnlHeader2.Size = new System.Drawing.Size(1039, 107);
            this.pnlHeader2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(253, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(514, 43);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vokabeltrainer-Karteikasten";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(345, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 34);
            this.label15.TabIndex = 2;
            this.label15.Text = "Wort:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(824, 254);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 34);
            this.label18.TabIndex = 3;
            this.label18.Text = "Lösung:";
            // 
            // labelWort
            // 
            this.labelWort.AutoSize = true;
            this.labelWort.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWort.Location = new System.Drawing.Point(435, 350);
            this.labelWort.Name = "labelWort";
            this.labelWort.Size = new System.Drawing.Size(131, 51);
            this.labelWort.TabIndex = 4;
            this.labelWort.Text = "Hallo";
            // 
            // labelLösung
            // 
            this.labelLösung.AutoSize = true;
            this.labelLösung.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.labelLösung.Location = new System.Drawing.Point(953, 350);
            this.labelLösung.Name = "labelLösung";
            this.labelLösung.Size = new System.Drawing.Size(181, 51);
            this.labelLösung.TabIndex = 5;
            this.labelLösung.Text = "Bonjour";
            // 
            // textBoxVokabelInput
            // 
            this.textBoxVokabelInput.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVokabelInput.Location = new System.Drawing.Point(575, 597);
            this.textBoxVokabelInput.Name = "textBoxVokabelInput";
            this.textBoxVokabelInput.Size = new System.Drawing.Size(374, 34);
            this.textBoxVokabelInput.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label20.Location = new System.Drawing.Point(73, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(379, 34);
            this.label20.TabIndex = 7;
            this.label20.Text = "Die Antwort ist leider falsch";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWrongAnswer
            // 
            this.pnlWrongAnswer.Controls.Add(this.pictureBoxWrong);
            this.pnlWrongAnswer.Controls.Add(this.label20);
            this.pnlWrongAnswer.Location = new System.Drawing.Point(530, 491);
            this.pnlWrongAnswer.Name = "pnlWrongAnswer";
            this.pnlWrongAnswer.Size = new System.Drawing.Size(478, 100);
            this.pnlWrongAnswer.TabIndex = 9;
            // 
            // pnlRightAnswer
            // 
            this.pnlRightAnswer.Controls.Add(this.pictureBox1);
            this.pnlRightAnswer.Controls.Add(this.labelRight);
            this.pnlRightAnswer.Location = new System.Drawing.Point(530, 491);
            this.pnlRightAnswer.Name = "pnlRightAnswer";
            this.pnlRightAnswer.Size = new System.Drawing.Size(478, 100);
            this.pnlRightAnswer.TabIndex = 10;
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRight.Location = new System.Drawing.Point(73, 32);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(298, 34);
            this.labelRight.TabIndex = 7;
            this.labelRight.Text = "Die Antwort ist richtig";
            this.labelRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lernkartentrainer.Properties.Resources.icons8_häkchen_64;
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxWrong
            // 
            this.pictureBoxWrong.Image = global::Lernkartentrainer.Properties.Resources.icons8_löschen_64;
            this.pictureBoxWrong.Location = new System.Drawing.Point(3, 14);
            this.pictureBoxWrong.Name = "pictureBoxWrong";
            this.pictureBoxWrong.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxWrong.TabIndex = 8;
            this.pictureBoxWrong.TabStop = false;
            // 
            // VKarteikarten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 769);
            this.Controls.Add(this.pnlRightAnswer);
            this.Controls.Add(this.pnlWrongAnswer);
            this.Controls.Add(this.textBoxVokabelInput);
            this.Controls.Add(this.labelLösung);
            this.Controls.Add(this.labelWort);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pnlHeader2);
            this.Controls.Add(this.pnlSide2);
            this.Name = "VKarteikarten";
            this.Text = "Lernkartentrainer";
            this.pnlSide2.ResumeLayout(false);
            this.pnlHeader2.ResumeLayout(false);
            this.pnlHeader2.PerformLayout();
            this.pnlWrongAnswer.ResumeLayout(false);
            this.pnlWrongAnswer.PerformLayout();
            this.pnlRightAnswer.ResumeLayout(false);
            this.pnlRightAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button buttonFach5;
        private System.Windows.Forms.Button buttonFach4;
        private System.Windows.Forms.Button buttonFach3;
        private System.Windows.Forms.Button buttonFach2;
        private System.Windows.Forms.Button buttonFach1;
        private System.Windows.Forms.Button buttonUebersicht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSideAuswahl;
        private System.Windows.Forms.Panel pnlFach1;
        private System.Windows.Forms.Button buttonF1Start;
        private System.Windows.Forms.Label labelF1Anzahl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelF1AnzahlFehler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelF1AnzahlRichtig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlFach2;
        private System.Windows.Forms.Label labelF2AnzahlRichtig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelF2AnzahlFehler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelF2Anzahl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonF2Start;
        private System.Windows.Forms.Panel pnlFach3;
        private System.Windows.Forms.Label labelF3AnzahlRichtig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelF3AnzahlFehler;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelF3Anzahl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonF3Start;
        private System.Windows.Forms.Panel pnlFach4;
        private System.Windows.Forms.Label labelF4AnzahlRichtig;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelF4AnzahlFehler;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelF4Anzahl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonF4Start;
        private System.Windows.Forms.Panel pnlFach5;
        private System.Windows.Forms.Label labelF5AnzahlRichtig;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelF5AnzahlFehler;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelF5Anzahl;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonF5Start;
        private System.Windows.Forms.Panel pnlUebersicht;
        private System.Windows.Forms.Panel pnlSide2;
        private System.Windows.Forms.Panel pnlHeader2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonProve;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelWort;
        private System.Windows.Forms.Label labelLösung;
        private System.Windows.Forms.TextBox textBoxVokabelInput;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBoxWrong;
        private System.Windows.Forms.Panel pnlWrongAnswer;
        private System.Windows.Forms.Panel pnlRightAnswer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRight;
    }
}

