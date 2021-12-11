using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace RequestClient
{
    public partial class SearchForm : Form
    {
        private MakeMovable makeMovable;
        public SearchForm()
        {
            InitializeComponent();
            makeMovable = new MakeMovable(this);
            makeMovable.SetMovable(this.panelTop);


            refreshCombo();
        }

        private async void refreshCombo()
        {
            StreetTableCRUDClient client3 = new StreetTableCRUDClient();
            StreetTable[] streetTables = await client3.ReadStreetTableAsync();

            await client3.CloseAsync();

            foreach (StreetTable item in streetTables)
                comboBox1.Items.Add(item.Street);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButtonFIO.Checked)
            {
                panelSearchByAdress.Height = 0;
                panelSearchByID.Height = 0;
                panelSearchByFio.Height += 10;
                if (panelSearchByFio.Height == 450)
                    timer1.Stop();
            }
            else if (radioButtonAdress.Checked)
            {
                panelSearchByAdress.Height += 10;
                panelSearchByID.Height = 0;
                panelSearchByFio.Height = 0;
                if (panelSearchByAdress.Height == 450)
                    timer1.Stop();
            }
            else if (radioButtonID.Checked)
            {
                panelSearchByAdress.Height = 0;
                panelSearchByID.Height += 10;
                panelSearchByFio.Height = 0;
                if (panelSearchByID.Height == 450)
                    timer1.Stop();
            }
        }

        private void radioButtonID_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void radioButtonAdress_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

    

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (radioButtonFIO.Checked)
            {
                if(textBoxFIO.Text!="")
                    EditRequestTable.searchFIO = textBoxFIO.Text;
            }
            else if (radioButtonID.Checked)
            {
                if (textBoxID.Text != "")
                    EditRequestTable.searchID = textBoxID.Text;
            }
            else if (radioButtonAdress.Checked)
            {
                if (comboBox1.Text != "")
                    EditRequestTable.searchStreet = comboBox1.Text;
                if (textBoxHouse.Text != "")
                    EditRequestTable.searchHouse = textBoxHouse.Text;
                if (textBoxApartment.Text != "")
                    EditRequestTable.searchApartment = textBoxApartment.Text;
            }

            EditRequestTable.isSearch = true;
            EditRequestTable.refreshGrid();

            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
