using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RequestClient
{
    public partial class GetDataFromRequestTableByMonth : Form
    {
        private int year;
        public GetDataFromRequestTableByMonth()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
            year = 0;
        }

        public GetDataFromRequestTableByMonth(int year)
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
            this.year = year;
            dateTimePicker1.Value = new DateTime(year, 1,1);
        }

        private async  void button1_Click(object sender, EventArgs e)
        {
            this.year = dateTimePicker1.Value.Year;
            ServiceReference1.SelectClient client = new ServiceReference1.SelectClient();

            DataTable table = new DataTable();

            table.Columns.Add("Состояние");

            table.Columns.Add("Январь");
            table.Columns.Add("Февраль");
            table.Columns.Add("Март");
            table.Columns.Add("Апрель");
            table.Columns.Add("Май");
            table.Columns.Add("Июнь");

            table.Columns.Add("Июль");
            table.Columns.Add("Август");
            table.Columns.Add("Сентябрь");
            table.Columns.Add("Октябрь");
            table.Columns.Add("Ноябрь");
            table.Columns.Add("Декабрь");

            table.Rows.Add(table.NewRow());
            table.Rows.Add(table.NewRow());
            table.Rows.Add(table.NewRow());

            table.Rows[0][0] = "Оформленные";
            table.Rows[1][0] = "Выполненные";
            table.Rows[2][0] = "Не выполненные";

            int formalized, tmp;
            int total1 = 0, total2 = 0, total3 = 0;
            for (int i = 1; i <= 12; i++)
            {
                formalized = 0;
                tmp = await client.GetCountRequestByMonthsAsync(dateTimePicker1.Value.Year, i, 2);
                table.Rows[1][i] = tmp;
                total2 += tmp;
                formalized += tmp;

                tmp = await client.GetCountRequestByMonthsAsync(dateTimePicker1.Value.Year, i, 3);
                table.Rows[2][i] = tmp;
                total3 += tmp;
                formalized += tmp;
                total1 += formalized;
                table.Rows[0][i] = formalized;
            }

            table.Columns.Add("Всего");

            table.Rows[0][13] = total1;
            table.Rows[1][13] = total2;
            table.Rows[2][13] = total3;

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Frozen = true;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            await client.CloseAsync();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 && e.ColumnIndex != dataGridView1.Columns.Count && e.RowIndex != -1)
                Main.openChildFormInPanel(new GetDataFromRequestTableByDay(dateTimePicker1.Value.Year, e.ColumnIndex));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
