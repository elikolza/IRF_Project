using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace tokcz
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public DataTable ReadCsv(string fileName)
        {
            DataTable dt = new DataTable("Data");
            using(OleDbConnection cn=new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\""+
                Path.GetDirectoryName(fileName)+"\";Extended Properties= 'text; HDR=yes;FMT=Delimited(,)';"))
            {
                using (OleDbCommand cmd = new OleDbCommand(string.Format("select *from [{0}]", new FileInfo(fileName).Name),cn))
                {
                    cn.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private void buttoncsv_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        dgw.DataSource = ReadCsv(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dgw.CurrentCell.RowIndex;
            dgw.Rows.RemoveAt(rowIndex);
        }

        private void buttonexcel_Click(object sender, EventArgs e)
        {
            if (dgw.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgw.Columns.Count +1; i++)
                {
                    xcelApp.Cells[1, i] = dgw.Columns[i-1].HeaderText;
                }

                for (int i = 0; i < dgw.Rows.Count; i++)
                {
                    for (int j = 0; j < dgw.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgw.Rows[i].Cells[j].Value.ToString();
                    }
                }

                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
