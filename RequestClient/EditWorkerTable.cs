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
    public partial class EditWorkerTable : Form
    {
        public EditWorkerTable()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            refreshGrid();
        }

        private async void refreshGrid()
        {
            WorkerTableCRUDClient client = new WorkerTableCRUDClient();
            Worker[] workers = client.ReadWorkerTableAsync().Result;

            BrigadeCRUDClient brigadeCRUDClient = new BrigadeCRUDClient();
            Brigade[] brigades = await brigadeCRUDClient.ReadBrigadeTableAsync();

            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(long));
            table.Columns.Add("ФИО",typeof(string));
            table.Columns.Add("Процент");
            table.Columns.Add("Бригада", typeof(string));


            int i = 0;

            foreach (Worker item in workers)
            {
                table.Rows.Add(table.NewRow());
                table.Rows[i][0] = item.IdWorker;
                table.Rows[i][1] = item.Name;
                table.Rows[i][2] = item.Percent;
                table.Rows[i][3] = (from brigade in brigades
                                    where brigade.IdBrigade == item.IdBrigade
                                    select new
                                    {
                                        brigade.Name
                                    }
                                    ).ToArray()[0].Name;
                i++;
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            await brigadeCRUDClient.CloseAsync();
            await client.CloseAsync();
        }  

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            BrigadeCRUDClient brigadeCRUDClient = new BrigadeCRUDClient();
            Brigade[] brigades = await brigadeCRUDClient.ReadBrigadeTableAsync();
            await brigadeCRUDClient.CloseAsync();


            WorkerTableCRUDClient client = new WorkerTableCRUDClient();
            await client.CreateWorkerTableAsync
                (
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(), 
                    float.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString()),
                    (
                        from brigade in brigades
                        where brigade.Name == dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString()
                        select new
                        {
                            brigade.IdBrigade
                        }
                    ).ToArray()[0].IdBrigade
                );

            await client.CloseAsync();
            refreshGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            WorkerTableCRUDClient client = new WorkerTableCRUDClient();
            await client.DeleteWorkerTableAsync(
                long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));

            await client.CloseAsync();
            refreshGrid();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            BrigadeCRUDClient brigadeCRUDClient = new BrigadeCRUDClient();
            Brigade[] brigades = await brigadeCRUDClient.ReadBrigadeTableAsync();
            await brigadeCRUDClient.CloseAsync();

            WorkerTableCRUDClient client = new WorkerTableCRUDClient();
            await client.UpdateWorkerTableAsync
                (
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(),

                    float.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString()),


                     (
                        from brigade in brigades
                        where brigade.Name == dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString()
                        select new
                        {
                            brigade.IdBrigade
                        }
                    ).ToArray()[0].IdBrigade,

                    long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString())
                );

            await client.CloseAsync();
            refreshGrid();
        }

    }
}
