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
    public partial class EditRequestTypeTable : Form
    {
        public EditRequestTypeTable()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            refreshGrid();
        }

        private async void refreshGrid()
        {
            RequestTypeTableCRUDClient client = new RequestTypeTableCRUDClient();
            RequestTypeTable[] requesTypeTable = client.ReadRequestTypeTableAsync().Result;

            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(long));
            table.Columns.Add("Тип заявки", typeof(string));
            table.Columns.Add("Цена за услугу", typeof(decimal));

            int i = 0;
            foreach (RequestTypeTable item in requesTypeTable)
            {
                table.Rows.Add(table.NewRow());
                table.Rows[i][0] = item.IdRequestType;
                table.Rows[i][1] = item.Type;
                table.Rows[i][2] = item.Price;
                i++;
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            await client.CloseAsync();
        }
    
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            RequestTypeTableCRUDClient client = new RequestTypeTableCRUDClient();
            await client.CreateRequestTypeTableAsync(
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(), 
                decimal.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString()));
                      
            await client.CloseAsync();
            refreshGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            RequestTypeTableCRUDClient client = new RequestTypeTableCRUDClient();
            await client.DeleteRequestTypeTableAsync(
                long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));

            await client.CloseAsync();
            refreshGrid();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            RequestTypeTableCRUDClient client = new RequestTypeTableCRUDClient();
            await client.UpdateRequestTypeTableAsync
                (
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(), 
                    decimal.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString()), 
                    long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString())
                );

            await client.CloseAsync();
            refreshGrid();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
