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
    public partial class EditManagerTable : Form
    {
        public EditManagerTable()
        {
            InitializeComponent();

            refreshGrid();
        }

        private async void refreshGrid()
        {
            ManagerTableCRUDClient client = new ManagerTableCRUDClient();
            ManagerTable[] managers = client.ReadManagerTableAsync().Result;

            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("ФИО", typeof(string));
            table.Columns.Add("Процент");

            int i = 0;

            foreach (ManagerTable item in managers)
            {
                table.Rows.Add(table.NewRow());
                table.Rows[i][0] = item.IdManager;
                table.Rows[i][1] = item.Name;
                table.Rows[i][2] = item.Percent;
                i++;
            }
            dataGridView1.DataSource = table;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            await client.CloseAsync();
        }
   
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            ManagerTableCRUDClient client = new ManagerTableCRUDClient();
            await client.CreateManagerTableAsync(
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                float.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString())
                );
            await client.CloseAsync();
            refreshGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            ManagerTableCRUDClient client = new ManagerTableCRUDClient();
            await client.DeleteManagerTableAsync(long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));

            await client.CloseAsync();
            refreshGrid();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            ManagerTableCRUDClient client = new ManagerTableCRUDClient();
            await client.UpdateManagerTableAsync
                (
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                    float.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString()),
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
