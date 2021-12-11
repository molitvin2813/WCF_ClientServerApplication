
namespace RequestClient
{
    partial class Main
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            panelChildForm = new System.Windows.Forms.Panel();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panelEditTable = new System.Windows.Forms.Panel();
            this.buttonEditStreet = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEditTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.panelTop.Controls.Add(this.button12);
            this.panelTop.Controls.Add(this.button11);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.panelTop.Size = new System.Drawing.Size(1260, 51);
            this.panelTop.TabIndex = 3;
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button12.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button12.Dock = System.Windows.Forms.DockStyle.Right;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.Color.Gainsboro;
            this.button12.Image = global::RequestClient.Properties.Resources.minimize;
            this.button12.Location = new System.Drawing.Point(1112, 10);
            this.button12.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.button12.Size = new System.Drawing.Size(45, 31);
            this.button12.TabIndex = 18;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button11.Dock = System.Windows.Forms.DockStyle.Right;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.Gainsboro;
            this.button11.Image = global::RequestClient.Properties.Resources.maximize__6_;
            this.button11.Location = new System.Drawing.Point(1157, 10);
            this.button11.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.button11.Size = new System.Drawing.Size(45, 31);
            this.button11.TabIndex = 17;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(152)))), ((int)(((byte)(246)))));
            this.label6.Image = global::RequestClient.Properties.Resources.close;
            this.label6.Location = new System.Drawing.Point(1202, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 5, 15, 10);
            this.label6.Size = new System.Drawing.Size(38, 35);
            this.label6.TabIndex = 16;
            this.label6.Text = " ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(panelChildForm);
            this.panel2.Controls.Add(this.sideMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 729);
            this.panel2.TabIndex = 4;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelChildForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panelChildForm.Location = new System.Drawing.Point(300, 0);
            panelChildForm.Margin = new System.Windows.Forms.Padding(5);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Padding = new System.Windows.Forms.Padding(15);
            panelChildForm.Size = new System.Drawing.Size(960, 729);
            panelChildForm.TabIndex = 5;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
            this.sideMenu.Controls.Add(this.panel1);
            this.sideMenu.Controls.Add(this.panelEditTable);
            this.sideMenu.Controls.Add(this.button9);
            this.sideMenu.Controls.Add(this.button2);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 0);
            this.sideMenu.Margin = new System.Windows.Forms.Padding(5);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Padding = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.sideMenu.Size = new System.Drawing.Size(300, 729);
            this.sideMenu.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 649);
            this.panel1.MinimumSize = new System.Drawing.Size(87, 65);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(290, 65);
            this.panel1.TabIndex = 10;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.Gainsboro;
            this.button8.Location = new System.Drawing.Point(15, 15);
            this.button8.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(260, 35);
            this.button8.TabIndex = 11;
            this.button8.Text = "<";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panelEditTable
            // 
            this.panelEditTable.Controls.Add(this.buttonEditStreet);
            this.panelEditTable.Controls.Add(this.button10);
            this.panelEditTable.Controls.Add(this.button7);
            this.panelEditTable.Controls.Add(this.button3);
            this.panelEditTable.Controls.Add(this.button6);
            this.panelEditTable.Controls.Add(this.button5);
            this.panelEditTable.Controls.Add(this.button1);
            this.panelEditTable.Controls.Add(this.button4);
            this.panelEditTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEditTable.Location = new System.Drawing.Point(5, 165);
            this.panelEditTable.MaximumSize = new System.Drawing.Size(290, 360);
            this.panelEditTable.MinimumSize = new System.Drawing.Size(290, 75);
            this.panelEditTable.Name = "panelEditTable";
            this.panelEditTable.Size = new System.Drawing.Size(290, 75);
            this.panelEditTable.TabIndex = 9;
            // 
            // buttonEditStreet
            // 
            this.buttonEditStreet.AutoSize = true;
            this.buttonEditStreet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditStreet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonEditStreet.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditStreet.FlatAppearance.BorderSize = 0;
            this.buttonEditStreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditStreet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonEditStreet.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEditStreet.Location = new System.Drawing.Point(0, 324);
            this.buttonEditStreet.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.buttonEditStreet.Name = "buttonEditStreet";
            this.buttonEditStreet.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.buttonEditStreet.Size = new System.Drawing.Size(290, 36);
            this.buttonEditStreet.TabIndex = 11;
            this.buttonEditStreet.Text = "Улицы";
            this.buttonEditStreet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditStreet.UseVisualStyleBackColor = true;
            this.buttonEditStreet.Click += new System.EventHandler(this.buttonEditStreet_Click);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.Gainsboro;
            this.button10.Location = new System.Drawing.Point(0, 288);
            this.button10.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(290, 36);
            this.button10.TabIndex = 10;
            this.button10.Text = "Бригады";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.Gainsboro;
            this.button7.Location = new System.Drawing.Point(0, 252);
            this.button7.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(290, 36);
            this.button7.TabIndex = 6;
            this.button7.Text = "Рабочие";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(0, 216);
            this.button3.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(290, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Тип";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Gainsboro;
            this.button6.Location = new System.Drawing.Point(0, 180);
            this.button6.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(290, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "Менеджер";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Location = new System.Drawing.Point(0, 111);
            this.button5.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(290, 69);
            this.button5.TabIndex = 4;
            this.button5.Text = "Системный Администратор";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(0, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(290, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Состояние";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(290, 75);
            this.button4.TabIndex = 9;
            this.button4.Text = "ИЗМЕНИТЬ ТАБЛИЦЫ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.Gainsboro;
            this.button9.Location = new System.Drawing.Point(5, 90);
            this.button9.Margin = new System.Windows.Forms.Padding(50, 25, 5, 5);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(290, 75);
            this.button9.TabIndex = 8;
            this.button9.Text = "НОВАЯ ЗАЯВКА";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(5, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(290, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "СПИСОК ЗАЯВОК";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1260, 780);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1250, 780);
            this.Name = "Main";
            this.Text = "Main";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.sideMenu.ResumeLayout(false);
            this.sideMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEditTable.ResumeLayout(false);
            this.panelEditTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panelEditTable;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEditStreet;
        public static System.Windows.Forms.Panel panelChildForm;
    }
}