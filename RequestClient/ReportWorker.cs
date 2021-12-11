using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace RequestClient
{


    public partial class ReportWorker : Form
    {
        DateTime date;
        public ReportWorker( DateTime date)
        {
            InitializeComponent();
            this.date = date;
            refreshGrid();
            refreshGridManager();
        }

        private void tabControl1_DrawItem(object sender,
System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Blue, 4);
            g.DrawRectangle(p, this.tabPage3.Bounds);
        }

        private async void refreshGrid()
        {
            label1.Text = "Общий отчет по сотрудникам за " + this.date.ToString();

            SelectClient client = new SelectClient();
            WorkerReport[] workers = client.GetWorkerReportAsync(this.date).Result;

            DataTable table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("ФИО");
            table.Columns.Add("Процент");
            table.Columns.Add("Сумма");


            var ss = (from see in workers
                    group see by see.IdWorker into g
                   
                    select new
                    {
                        IdWorker = g.Key,
                        Sum = Math.Round(g.Sum(c => c.Sum), 2),
                        Name = (from p in g select p.Name).ToArray()[0],
                        Percent =  (from p in g select p.Percent).ToArray()[0]
                    }).ToArray();
            
            for (int j = 0; j < ss.Length; j++)
            {
                table.Rows.Add(table.NewRow());
               
                table.Rows[j][0]= ss[j].IdWorker;
                table.Rows[j][1] = ss[j].Name;
                table.Rows[j][2] = ss[j].Percent;
                table.Rows[j][3] = ss[j].Sum;
            }

        
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            await client.CloseAsync();
        }

        private async void refreshGridManager()
        {
            label1.Text = "Общий отчет по сотрудникам за " + this.date.ToString();

            SelectClient client = new SelectClient();
            ManagerReport[] workers = client.GetManagerReportAsync(this.date).Result;

            DataTable table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("ФИО");
            table.Columns.Add("Процент");
            table.Columns.Add("Сумма");


            var ss = (from see in workers
                      group see by see.IdManager into g

                      select new
                      {
                          IdWorker = g.Key,
                          Sum = Math.Round(g.Sum(c => c.Sum), 2),
                          Name = (from p in g select p.Name).ToArray()[0],
                          Percent = (from p in g select p.Percent).ToArray()[0]
                      }).ToArray();

            for (int j = 0; j < ss.Length; j++)
            {
                table.Rows.Add(table.NewRow());

                table.Rows[j][0] = ss[j].IdWorker;
                table.Rows[j][1] = ss[j].Name;
                table.Rows[j][2] = ss[j].Percent;
                table.Rows[j][3] = ss[j].Sum;
            }


            dataGridView2.DataSource = table;
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            await client.CloseAsync();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Main.openChildFormInPanel(new GetDataFromRequestTableBySomeDay(this.date));
        }
    }
}
