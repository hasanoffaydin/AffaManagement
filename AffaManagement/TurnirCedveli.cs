using AffaManagement.Business;
using AffaManagement.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffaManagement
{
    public partial class TurnirCedveli : Form
    {
        public TurnirCedveli()
        {
            InitializeComponent();
        }

        private void TurnirCedveli_Load(object sender, EventArgs e)
        {

            TurnirAndResult turnirAndResult = new TurnirAndResult();
            dataGridView1.DataSource = turnirAndResult.TurnirCedveli();
            dataGridView2.DataSource = turnirAndResult.ResultCedveli();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Workbooks.Add();

            Microsoft.Office.Interop.Excel._Worksheet workSheet = (Microsoft.Office.Interop.Excel._Worksheet)excelApp.ActiveSheet;

            int row = 1;

            for (int i = 0; i < Math.Max(dataGridView1.Rows.Count, dataGridView2.Rows.Count); i++)
            {
                int col = 1;

                if (i < dataGridView1.Rows.Count)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        var value1 = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                        if (!string.IsNullOrEmpty(value1))
                        {
                            workSheet.Cells[row, col] = value1;
                        }
                        col++;
                    }
                }

                if (i < dataGridView2.Rows.Count)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        var value2 = dataGridView2.Rows[i].Cells[j].Value?.ToString();
                        if (!string.IsNullOrEmpty(value2))
                        {
                            workSheet.Cells[row, col] = value2;
                        }
                        col++;
                    }
                }

                row++;
            }

            excelApp.Visible = true;

            
        }


    }
}
