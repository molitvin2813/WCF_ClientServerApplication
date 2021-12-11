using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServiceReference1;

namespace RequestClient
{
    public partial class EditBrigadeTable : Form
    {
        public EditBrigadeTable()
        {
            InitializeComponent();
            refreshGrid();
        }

        private async void refreshGrid()
        {
            BrigadeCRUDClient brigadeCRUDClient = new BrigadeCRUDClient();
            Brigade[] brigades = brigadeCRUDClient.ReadBrigadeTableAsync().Result;

            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(long));
            table.Columns.Add("ФИО", typeof(string));

            int i = 0;

            foreach (Brigade item in brigades)
            {
                table.Rows.Add(table.NewRow());
                table.Rows[i][0] = item.IdBrigade;
                table.Rows[i][1] = item.Name;
                i++;
            }
            dataGridView1.DataSource = table;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            await brigadeCRUDClient.CloseAsync();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            BrigadeCRUDClient client = new BrigadeCRUDClient();
            await client.CreateBrigadeTableAsync(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString());
            await client.CloseAsync();
            refreshGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            BrigadeCRUDClient client = new BrigadeCRUDClient();
            await client.DeleteBrigadeTableAsync(long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));

            await client.CloseAsync();
            refreshGrid();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            BrigadeCRUDClient client = new BrigadeCRUDClient();
            await client.UpdateBrigadeTableAsync
                (
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                    long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString())
                );

            await client.CloseAsync();
            refreshGrid();
        }
    }
}
