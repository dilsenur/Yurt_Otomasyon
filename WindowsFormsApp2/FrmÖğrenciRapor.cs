using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp2
{
    public partial class FrmÖğrenciRapor : Form
    {
        

        public FrmÖğrenciRapor()
        {
            InitializeComponent();
        }

        private void FrmÖğrenciRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet8.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Ogrenci);
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet7.Ogrenci' table. You can move, or remove it, as needed.
            // this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Ogrenci);

            //this.reportViewer1.RefreshReport();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            app.Visible = true;
            object Missing = Type.Missing;
            Workbook ktp = app.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)ktp.Sheets[1];
            int sutun = 1;
            int satır = 1;

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myrange = (Range)sheet1.Cells[satır, sutun + j];
                myrange.Value2 = dataGridView1.Columns[j].HeaderText;

            }
            satır++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j=0; j< dataGridView1.Columns.Count;j++ )
                {
                    Range myrange = (Range)sheet1.Cells[satır + i, sutun + j];
                    myrange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myrange.Select();
                }
            }
 
        }
    }
}
