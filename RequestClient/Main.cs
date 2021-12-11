
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RequestClient
{
    public partial class Main : Form
    {
        private bool isCollapsedSideMenu, isCollapsedEditTable;
        private bool isMax;
        private MakeMovable makeMovable;

        public Main()
        {
            InitializeComponent();
            isCollapsedSideMenu = true;
            isCollapsedEditTable = false;
            makeMovable = new MakeMovable(this);
            makeMovable.SetMovable(this.panelTop);
            isMax = false;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new EditRequestStateTable());
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
 
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {

        }


        public static Form activeForm = null;
        public static void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GetDataFromRequestTableByMonth());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new EditRequestTypeTable());
        }


        private void button5_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new EditSystemAdministrator());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new EditManagerTable());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new EditWorkerTable());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new EditRequestTable());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!isCollapsedSideMenu)
            {
                sideMenu.Width += 10;
                if (sideMenu.Width == 300)
                {
                    button2.Visible = true;
                    button9.Visible = true;
                    panelEditTable.Visible = true;
                    isCollapsedSideMenu = true;
                    button8.Text = "<";
                    timer2.Stop();
                    
                }
            }
            else
            {
                button2.Visible = false;
                button9.Visible = false;
                panelEditTable.Visible = false;
                sideMenu.Width -= 10;
                if (sideMenu.Width == 100)
                {
                   
                    isCollapsedSideMenu = false;
                    button8.Text = ">";

                    timer2.Stop();
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isCollapsedEditTable)
            {
                panelEditTable.Height += 5;
                if (panelEditTable.Size == panelEditTable.MaximumSize)
                {
                    isCollapsedEditTable = true;
                    timer1.Stop();
                }
            }
            else
            {
                panelEditTable.Height -= 5;
                if (panelEditTable.Size == panelEditTable.MinimumSize)
                {
                    isCollapsedEditTable = false;
                    timer1.Stop();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;

            if (!isMax)
            {
                this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 10); ;              
            }

            else
            {
                this.Size = this.MinimumSize;               

            }
            this.CenterToScreen();

            isMax = !isMax;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void buttonEditStreet_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new EditStreetTable());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new EditBrigadeTable());
        }
    }
}

