using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceReference1;
namespace RequestClient
{
    public partial class EditRequestStateTable : Form
    {
 
        public EditRequestStateTable()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode =DataGridViewTriState.True;
            refreshGrid();
        }

        private async void refreshGrid()
        {
            RequestStateTableCRUDClient client = new RequestStateTableCRUDClient();
            RequestStateTable[] requestStateTable = client.ReadRequestStateTableAsync().Result;

            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Состояние завявки", typeof(string));


            int i = 0;

            foreach (RequestStateTable item in requestStateTable)
            {
                table.Rows.Add(table.NewRow());
                table.Rows[i][0] = item.IdRequestState;
                table.Rows[i][1] = item.State;
                i++;
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            await client.CloseAsync();
        }

       

    
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            RequestStateTableCRUDClient client = new RequestStateTableCRUDClient();
                        
            await client.UpdateRequestStateTableAsync(
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(), 
                long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            await client.CloseAsync();

            refreshGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            RequestStateTableCRUDClient client = new RequestStateTableCRUDClient();

        
            await client.DeleteRequestStateTableAsync(long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            await client.CloseAsync();

            refreshGrid();
        }

     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            RequestStateTableCRUDClient client = new RequestStateTableCRUDClient();

            await client.CreateRequestStateTableAsync(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString());
            await client.CloseAsync();
            refreshGrid();
        }
    }
}
