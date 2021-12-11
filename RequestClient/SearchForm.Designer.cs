
namespace RequestClient
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonAdress = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.radioButtonFIO = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSearchByAdress = new System.Windows.Forms.Panel();
            this.textBoxApartment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSearchByID = new System.Windows.Forms.Panel();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSearchByFio = new System.Windows.Forms.Panel();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSearchByAdress.SuspendLayout();
            this.panelSearchByID.SuspendLayout();
            this.panelSearchByFio.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.panelTop.Size = new System.Drawing.Size(875, 43);
            this.panelTop.TabIndex = 13;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(152)))), ((int)(((byte)(246)))));
            this.label6.Image = global::RequestClient.Properties.Resources.close;
            this.label6.Location = new System.Drawing.Point(817, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.label6.Size = new System.Drawing.Size(38, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = " ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.56856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43144F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 602);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 531);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(24, 6, 24, 6);
            this.panel1.Size = new System.Drawing.Size(865, 67);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonAdress);
            this.panel3.Controls.Add(this.radioButtonID);
            this.panel3.Controls.Add(this.radioButtonFIO);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(24, 6);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(516, 55);
            this.panel3.TabIndex = 1;
            // 
            // radioButtonAdress
            // 
            this.radioButtonAdress.AutoSize = true;
            this.radioButtonAdress.Checked = true;
            this.radioButtonAdress.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonAdress.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButtonAdress.Location = new System.Drawing.Point(266, 5);
            this.radioButtonAdress.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.radioButtonAdress.Name = "radioButtonAdress";
            this.radioButtonAdress.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.radioButtonAdress.Size = new System.Drawing.Size(121, 45);
            this.radioButtonAdress.TabIndex = 2;
            this.radioButtonAdress.TabStop = true;
            this.radioButtonAdress.Text = "АДРЕС";
            this.radioButtonAdress.UseVisualStyleBackColor = true;
            this.radioButtonAdress.CheckedChanged += new System.EventHandler(this.radioButtonAdress_CheckedChanged);
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonID.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButtonID.Location = new System.Drawing.Point(103, 5);
            this.radioButtonID.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.radioButtonID.Size = new System.Drawing.Size(163, 45);
            this.radioButtonID.TabIndex = 1;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "№ ЗАЯВКИ";
            this.radioButtonID.UseVisualStyleBackColor = true;
            this.radioButtonID.CheckedChanged += new System.EventHandler(this.radioButtonID_CheckedChanged);
            // 
            // radioButtonFIO
            // 
            this.radioButtonFIO.AutoSize = true;
            this.radioButtonFIO.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonFIO.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButtonFIO.Location = new System.Drawing.Point(5, 5);
            this.radioButtonFIO.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.radioButtonFIO.Name = "radioButtonFIO";
            this.radioButtonFIO.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.radioButtonFIO.Size = new System.Drawing.Size(98, 45);
            this.radioButtonFIO.TabIndex = 0;
            this.radioButtonFIO.TabStop = true;
            this.radioButtonFIO.Text = "ФИО";
            this.radioButtonFIO.UseVisualStyleBackColor = true;
            this.radioButtonFIO.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Location = new System.Drawing.Point(759, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(16, 13, 16, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 55);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelSearchByAdress);
            this.panel2.Controls.Add(this.panelSearchByID);
            this.panel2.Controls.Add(this.panelSearchByFio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.panel2.Size = new System.Drawing.Size(865, 519);
            this.panel2.TabIndex = 2;
            // 
            // panelSearchByAdress
            // 
            this.panelSearchByAdress.Controls.Add(this.textBoxApartment);
            this.panelSearchByAdress.Controls.Add(this.label5);
            this.panelSearchByAdress.Controls.Add(this.textBoxHouse);
            this.panelSearchByAdress.Controls.Add(this.label4);
            this.panelSearchByAdress.Controls.Add(this.comboBox1);
            this.panelSearchByAdress.Controls.Add(this.label3);
            this.panelSearchByAdress.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchByAdress.Location = new System.Drawing.Point(24, 40);
            this.panelSearchByAdress.MinimumSize = new System.Drawing.Size(718, 0);
            this.panelSearchByAdress.Name = "panelSearchByAdress";
            this.panelSearchByAdress.Padding = new System.Windows.Forms.Padding(30);
            this.panelSearchByAdress.Size = new System.Drawing.Size(817, 450);
            this.panelSearchByAdress.TabIndex = 7;
            // 
            // textBoxApartment
            // 
            this.textBoxApartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.textBoxApartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxApartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxApartment.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxApartment.Location = new System.Drawing.Point(30, 247);
            this.textBoxApartment.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxApartment.MinimumSize = new System.Drawing.Size(620, 30);
            this.textBoxApartment.Name = "textBoxApartment";
            this.textBoxApartment.Size = new System.Drawing.Size(757, 30);
            this.textBoxApartment.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(30, 191);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label5.Size = new System.Drawing.Size(124, 56);
            this.label5.TabIndex = 16;
            this.label5.Text = "КВАРТИРА";
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.textBoxHouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxHouse.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxHouse.Location = new System.Drawing.Point(30, 161);
            this.textBoxHouse.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxHouse.MinimumSize = new System.Drawing.Size(620, 30);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(757, 30);
            this.textBoxHouse.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(30, 105);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label4.Size = new System.Drawing.Size(64, 56);
            this.label4.TabIndex = 14;
            this.label4.Text = "ДОМ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(757, 34);
            this.comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(30, 30);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.label3.Size = new System.Drawing.Size(87, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "УЛИЦА";
            // 
            // panelSearchByID
            // 
            this.panelSearchByID.Controls.Add(this.textBoxID);
            this.panelSearchByID.Controls.Add(this.label2);
            this.panelSearchByID.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchByID.Location = new System.Drawing.Point(24, 30);
            this.panelSearchByID.MinimumSize = new System.Drawing.Size(718, 0);
            this.panelSearchByID.Name = "panelSearchByID";
            this.panelSearchByID.Padding = new System.Windows.Forms.Padding(30);
            this.panelSearchByID.Size = new System.Drawing.Size(817, 10);
            this.panelSearchByID.TabIndex = 6;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxID.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxID.Location = new System.Drawing.Point(30, 71);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxID.MinimumSize = new System.Drawing.Size(620, 30);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(757, 30);
            this.textBoxID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.label2.Size = new System.Drawing.Size(127, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "№ ЗАЯВКИ";
            // 
            // panelSearchByFio
            // 
            this.panelSearchByFio.Controls.Add(this.textBoxFIO);
            this.panelSearchByFio.Controls.Add(this.label1);
            this.panelSearchByFio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchByFio.Location = new System.Drawing.Point(24, 20);
            this.panelSearchByFio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelSearchByFio.MinimumSize = new System.Drawing.Size(718, 0);
            this.panelSearchByFio.Name = "panelSearchByFio";
            this.panelSearchByFio.Padding = new System.Windows.Forms.Padding(49, 39, 49, 39);
            this.panelSearchByFio.Size = new System.Drawing.Size(817, 10);
            this.panelSearchByFio.TabIndex = 5;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.textBoxFIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxFIO.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxFIO.Location = new System.Drawing.Point(49, 80);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFIO.MinimumSize = new System.Drawing.Size(620, 30);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(719, 30);
            this.textBoxFIO.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.label1.Size = new System.Drawing.Size(62, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 645);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditRequestTableSearchFrom";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelSearchByAdress.ResumeLayout(false);
            this.panelSearchByAdress.PerformLayout();
            this.panelSearchByID.ResumeLayout(false);
            this.panelSearchByID.PerformLayout();
            this.panelSearchByFio.ResumeLayout(false);
            this.panelSearchByFio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonAdress;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.RadioButton radioButtonFIO;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSearchByAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSearchByID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSearchByFio;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxApartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}