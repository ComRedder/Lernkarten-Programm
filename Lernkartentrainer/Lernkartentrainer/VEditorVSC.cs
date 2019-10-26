using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lernkartentrainer
{
    public partial class VEditorVSC : Form
    {
        public VEditorVSC()
        {
            InitializeComponent();
        }

        void Clear_all()
        {
            dataGridViewEditor.Columns.Clear();
        }

        void ReadCSV(string file)
        {
            Clear_all();
            string rowValue;
            string[] cellValue;

            if (System.IO.File.Exists(file))
            {
                StreamReader streamreader = new StreamReader(file);
                rowValue = streamreader.ReadLine();
                cellValue = rowValue.Split(';');

                for (int i = 0; i < cellValue.Count() - 1; i++)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();

                    column.Name = cellValue[i];
                    column.HeaderText = cellValue[i];
                    dataGridViewEditor.Columns.Add(column);
                }

                while (streamreader.Peek() != -1)
                {
                    rowValue = streamreader.ReadLine();
                    cellValue = rowValue.Split(';');
                    dataGridViewEditor.Rows.Add(cellValue);
                }
                streamreader.Close();
            }
        }

        void SaveCSV(string file)
        {
            StreamWriter streamwriter = new StreamWriter(file);
            string strHeader = "";

            for (int i = 0; i < dataGridViewEditor.Columns.Count; i++)
            {
                strHeader += dataGridViewEditor.Columns[i].HeaderText + ";";
            }

            strHeader = strHeader.TrimEnd(';');

            streamwriter.WriteLine(strHeader);

            for (int m = 0; m < dataGridViewEditor.Rows.Count - 1; m++)
            {
                string strRowValue = "";

                for (int n = 0; n < dataGridViewEditor.Columns.Count; n++)
                {
                    strRowValue += dataGridViewEditor.Rows[m].Cells[n].Value + ";";
                }
                strRowValue = strRowValue.TrimEnd(';');
                streamwriter.WriteLine(strRowValue);
            }
            streamwriter.Close();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ReadCSV(openFileDialog1.FileName);
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            SaveCSV(saveFileDialog1.FileName);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
