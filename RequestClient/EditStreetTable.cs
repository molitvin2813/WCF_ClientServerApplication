using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RequestClient
{
    public partial class EditStreetTable : Form
    {
        public EditStreetTable()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            refreshGrid();
        }

        private async void refreshGrid()
        {
            StreetTableCRUDClient client = new StreetTableCRUDClient();
            StreetTable[] streetTables = client.ReadStreetTableAsync().Result;

            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Улица", typeof(string));

            int i = 0;
            foreach (StreetTable item in streetTables)
            {
                table.Rows.Add(table.NewRow());
                table.Rows[i][0] = item.IdStreet;
                table.Rows[i][1] = item.Street;              
                i++;
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            await client.CloseAsync();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            StreetTableCRUDClient client = new StreetTableCRUDClient();
            await client.CreateStreetTableAsync(
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString());

            await client.CloseAsync();
            refreshGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            StreetTableCRUDClient client = new StreetTableCRUDClient();
            await client.DeleteStreetTableAsync(
                int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));

            await client.CloseAsync();
            refreshGrid();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            StreetTableCRUDClient client = new StreetTableCRUDClient();
            await client.UpdateStreetTableAsync
                (
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                    int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString())
                );

            await client.CloseAsync();
            refreshGrid();
        }

    }
}
