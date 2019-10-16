namespace Lernkartentrainer
{
    partial class View
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
            this.sidepanel = new System.Windows.Forms.Panel();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.buttonUebersicht = new System.Windows.Forms.Button();
            this.buttonFach1 = new System.Windows.Forms.Button();
            this.buttonFach2 = new System.Windows.Forms.Button();
            this.buttonFach3 = new System.Windows.Forms.Button();
            this.buttonFach4 = new System.Windows.Forms.Button();
            this.buttonFach5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.sidepanel.SuspendLayout();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.sidepanel.Controls.Add(this.panelSide);
            this.sidepanel.Controls.Add(this.buttonFach5);
            this.sidepanel.Controls.Add(this.buttonFach4);
            this.sidepanel.Controls.Add(this.buttonFach3);
            this.sidepanel.Controls.Add(this.buttonFach2);
            this.sidepanel.Controls.Add(this.buttonFach1);
            this.sidepanel.Controls.Add(this.buttonUebersicht);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(289, 769);
            this.sidepanel.TabIndex = 0;
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.DarkRed;
            this.headerpanel.Controls.Add(this.label1);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(289, 0);
            this.headerpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(1139, 111);
            this.headerpanel.TabIndex = 1;
            // 
            // buttonUebersicht
            // 
            this.buttonUebersicht.FlatAppearance.BorderSize = 0;
            this.buttonUebersicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUebersicht.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUebersicht.ForeColor = System.Drawing.Color.White;
            this.buttonUebersicht.Location = new System.Drawing.Point(15, 115);
            this.buttonUebersicht.Name = "buttonUebersicht";
            this.buttonUebersicht.Size = new System.Drawing.Size(258, 83);
            this.buttonUebersicht.TabIndex = 0;
            this.buttonUebersicht.Text = "Übersicht";
            this.buttonUebersicht.UseVisualStyleBackColor = true;
            this.buttonUebersicht.Click += new System.EventHandler(this.buttonUebersicht_Click);
            // 
            // buttonFach1
            // 
            this.buttonFach1.FlatAppearance.BorderSize = 0;
            this.buttonFach1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFach1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFach1.ForeColor = System.Drawing.Color.White;
            this.buttonFach1.Location = new System.Drawing.Point(15, 204);
            this.buttonFach1.Name = "buttonFach1";
            this.buttonFach1.Size = new System.Drawing.Size(258, 83);
            this.buttonFach1.TabIndex = 1;
            this.buttonFach1.Text = "1.Fach";
            this.buttonFach1.UseVisualStyleBackColor = true;
            this.buttonFach1.Click += new System.EventHandler(this.buttonFach1_Click);
            // 
            // buttonFach2
            // 
            this.buttonFach2.FlatAppearance.BorderSize = 0;
            this.buttonFach2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFach2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFach2.ForeColor = System.Drawing.Color.White;
            this.buttonFach2.Location = new System.Drawing.Point(15, 293);
            this.buttonFach2.Name = "buttonFach2";
            this.buttonFach2.Size = new System.Drawing.Size(258, 83);
            this.buttonFach2.TabIndex = 2;
            this.buttonFach2.Text = "2.Fach";
            this.buttonFach2.UseVisualStyleBackColor = true;
            this.buttonFach2.Click += new System.EventHandler(this.buttonFach2_Click);
            // 
            // buttonFach3
            // 
            this.buttonFach3.FlatAppearance.BorderSize = 0;
            this.buttonFach3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFach3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFach3.ForeColor = System.Drawing.Color.White;
            this.buttonFach3.Location = new System.Drawing.Point(15, 382);
            this.buttonFach3.Name = "buttonFach3";
            this.buttonFach3.Size = new System.Drawing.Size(258, 83);
            this.buttonFach3.TabIndex = 3;
            this.buttonFach3.Text = "3.Fach";
            this.buttonFach3.UseVisualStyleBackColor = true;
            this.buttonFach3.Click += new System.EventHandler(this.buttonFach3_Click);
            // 
            // buttonFach4
            // 
            this.buttonFach4.FlatAppearance.BorderSize = 0;
            this.buttonFach4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFach4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFach4.ForeColor = System.Drawing.Color.White;
            this.buttonFach4.Location = new System.Drawing.Point(15, 471);
            this.buttonFach4.Name = "buttonFach4";
            this.buttonFach4.Size = new System.Drawing.Size(258, 83);
            this.buttonFach4.TabIndex = 4;
            this.buttonFach4.Text = "4.Fach";
            this.buttonFach4.UseVisualStyleBackColor = true;
            this.buttonFach4.Click += new System.EventHandler(this.buttonFach4_Click);
            // 
            // buttonFach5
            // 
            this.buttonFach5.FlatAppearance.BorderSize = 0;
            this.buttonFach5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFach5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFach5.ForeColor = System.Drawing.Color.White;
            this.buttonFach5.Location = new System.Drawing.Point(15, 560);
            this.buttonFach5.Name = "buttonFach5";
            this.buttonFach5.Size = new System.Drawing.Size(258, 83);
            this.buttonFach5.TabIndex = 5;
            this.buttonFach5.Text = "5.Fach";
            this.buttonFach5.UseVisualStyleBackColor = true;
            this.buttonFach5.Click += new System.EventHandler(this.buttonFach5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vokabeltrainer-Karteikasten";
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.DarkRed;
            this.panelSide.Location = new System.Drawing.Point(0, 115);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(10, 83);
            this.panelSide.TabIndex = 2;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 769);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.sidepanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "View";
            this.Text = "Lernkartentrainer";
            this.sidepanel.ResumeLayout(false);
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Button buttonFach5;
        private System.Windows.Forms.Button buttonFach4;
        private System.Windows.Forms.Button buttonFach3;
        private System.Windows.Forms.Button buttonFach2;
        private System.Windows.Forms.Button buttonFach1;
        private System.Windows.Forms.Button buttonUebersicht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSide;
    }
}

