using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lernkartentrainer
{
    public partial class VEditorXML : Form
    {
        public VEditorXML()
        {
            InitializeComponent();
        }

        void Clear_all()
        {
            dataGridViewEditorXML.Columns.Clear();
        }

        void ReadXML(string file)
        {
            Clear_all();

            DataSet myDataSet = new DataSet();
            myDataSet.ReadXml(file);
            dataGridViewEditorXML.DataSource = myDataSet.Tables[0].DefaultView;
        }

        void SaveXML(string file)
        {
            DataTable dt = new DataTable("Platzhalter");

            for (int i = 0; i < dataGridViewEditorXML.ColumnCount; i++)
            {
                dt.Columns.Add(dataGridViewEditorXML.Columns[i].Name, typeof(System.String));
            }

            DataRow myrow;
            int icols = dataGridViewEditorXML.Columns.Count;
            foreach (DataGridViewRow drow in this.dataGridViewEditorXML.Rows)
            {
                if (drow.Cells[0].Value != null)    //Überprüfung ob beim Abspeichern eine leere Zeile ist. Das will man damit verhindern.
                {
                    myrow = dt.NewRow();
                    for (int i = 0; i < icols; i++)
                    {
                        myrow[i] = drow.Cells[i].Value;
                    }
                    dt.Rows.Add(myrow);
                }
            }
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            SaveXML(saveFileDialog1.FileName);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ReadXML(openFileDialog1.FileName);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
