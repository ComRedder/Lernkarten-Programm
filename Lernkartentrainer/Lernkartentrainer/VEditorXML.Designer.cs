namespace Lernkartentrainer
{
    partial class VEditorXML
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.pnlSide2 = new System.Windows.Forms.Panel();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.pnlHeader2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewEditorXML = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlSide2.SuspendLayout();
            this.pnlHeader2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditorXML)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(12, 567);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(258, 83);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Schließen";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pnlSide2
            // 
            this.pnlSide2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlSide2.Controls.Add(this.buttonClose);
            this.pnlSide2.Controls.Add(this.buttonOpen);
            this.pnlSide2.Controls.Add(this.buttonSpeichern);
            this.pnlSide2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide2.Location = new System.Drawing.Point(0, 107);
            this.pnlSide2.Name = "pnlSide2";
            this.pnlSide2.Size = new System.Drawing.Size(289, 662);
            this.pnlSide2.TabIndex = 10;
            // 
            // buttonOpen
            // 
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.ForeColor = System.Drawing.Color.White;
            this.buttonOpen.Location = new System.Drawing.Point(12, 343);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(258, 83);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Öffnen";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpeichern.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpeichern.ForeColor = System.Drawing.Color.White;
            this.buttonSpeichern.Location = new System.Drawing.Point(12, 126);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(258, 83);
            this.buttonSpeichern.TabIndex = 2;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // pnlHeader2
            // 
            this.pnlHeader2.BackColor = System.Drawing.Color.DarkRed;
            this.pnlHeader2.Controls.Add(this.label5);
            this.pnlHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader2.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader2.Name = "pnlHeader2";
            this.pnlHeader2.Size = new System.Drawing.Size(1328, 107);
            this.pnlHeader2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(436, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(514, 43);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vokabeltrainer-Karteikasten";
            // 
            // dataGridViewEditorXML
            // 
            this.dataGridViewEditorXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditorXML.Location = new System.Drawing.Point(295, 113);
            this.dataGridViewEditorXML.Name = "dataGridViewEditorXML";
            this.dataGridViewEditorXML.RowHeadersWidth = 62;
            this.dataGridViewEditorXML.RowTemplate.Height = 28;
            this.dataGridViewEditorXML.Size = new System.Drawing.Size(1021, 644);
            this.dataGridViewEditorXML.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // VEditorXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 769);
            this.Controls.Add(this.pnlSide2);
            this.Controls.Add(this.pnlHeader2);
            this.Controls.Add(this.dataGridViewEditorXML);
            this.Name = "VEditorXML";
            this.Text = "VEditorXML";
            this.pnlSide2.ResumeLayout(false);
            this.pnlHeader2.ResumeLayout(false);
            this.pnlHeader2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditorXML)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel pnlSide2;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Panel pnlHeader2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewEditorXML;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}