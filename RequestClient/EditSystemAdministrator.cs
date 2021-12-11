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
    public partial class EditSystemAdministrator : Form
    {
        public EditSystemAdministrator()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            refreshGrid();
        }

        private async void refreshGrid()
        {
            SystemAdministratorTableCRUDClient client = new SystemAdministratorTableCRUDClient();
            SystemAdministratorTable[] systemAdministrators = client.ReadSystemAdministratorTableAsync().Result;

            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(long));
            table.Columns.Add("ФИО", typeof(string));

            int i = 0;

            foreach (SystemAdministratorTable item in systemAdministrators)
            {
                table.Rows.Add(table.NewRow());
                table.Rows[i][0] = item.IdSystemAdministrator;
                table.Rows[i][1] = item.Name;
                i++;
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            await client.CloseAsync();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            SystemAdministratorTableCRUDClient client = new SystemAdministratorTableCRUDClient();
            await client.CreateSystemAdministratorTableAsync(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

            await client.CloseAsync();
            refreshGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            SystemAdministratorTableCRUDClient client = new SystemAdministratorTableCRUDClient();
            await client.DeleteSystemAdministratorTableAsync(
                long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));

            await client.CloseAsync();
            refreshGrid();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            SystemAdministratorTableCRUDClient client = new SystemAdministratorTableCRUDClient();
            await client.UpdateSystemAdministratorTableAsync
                (
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                    long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString())
                );

            await client.CloseAsync();
            refreshGrid();
        }
    }
}
