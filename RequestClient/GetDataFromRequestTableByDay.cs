using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RequestClient
{
    public partial class GetDataFromRequestTableByDay : Form
    {
        private int year, month;
        public GetDataFromRequestTableByDay(int year, int month)
        {
            InitializeComponent();
            this.year = year;
            this.month = month;
            refreshGrid();
        }

        private async void refreshGrid()
        {

            ServiceReference1.SelectClient client = new ServiceReference1.SelectClient();

            DataTable table = new DataTable();

            table.Columns.Add("Состояние");

            table.Rows.Add(table.NewRow());
            table.Rows.Add(table.NewRow());
            table.Rows.Add(table.NewRow());

            table.Rows[0][0] = "Оформленные";
            table.Rows[1][0] = "Выполненные";
            table.Rows[2][0] = "Не выполненные";

            var ss = await client.GetCountRequestByDayAsync(this.year, this.month, 2);
            var ss2 = await client.GetCountRequestByDayAsync(this.year, this.month, 3);
            int total1 =0, total2 = 0, total3 =0;

            for (int i = 0; i <ss.Length; i++)
            {
                table.Columns.Add((i+1).ToString());
                
                table.Rows[1][i + 1] = ss[i].Count;
                table.Rows[2][i + 1] = ss2[i].Count;
                table.Rows[0][i + 1] = ss[i].Count + ss2[i].Count;

                total1 += ss[i].Count + ss2[i].Count;
                total2 += ss[i].Count;
                total3 += ss2[i].Count;
            }
            table.Columns.Add("Всего");

            table.Rows[0][ss.Length + 1] = total1;
            table.Rows[1][ss.Length + 1] = total2;
            table.Rows[2][ss.Length + 1] = total3;
           

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Frozen = true;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            await client.CloseAsync();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >0 && e.ColumnIndex != dataGridView1.Columns.Count && e.RowIndex != -1)
                Main.openChildFormInPanel(new GetDataFromRequestTableBySomeDay(new DateTime(this.year, this.month, e.ColumnIndex)));
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.openChildFormInPanel(new GetDataFromRequestTableByMonth(year));
        }
    }
}
