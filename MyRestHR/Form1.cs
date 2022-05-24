using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRestHR
{
    public partial class Form1 : Form
    {
        public List<PictureBox> EmployeeGifs = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            BarBoredrs.Visible = false;
        }
        public void LoadForm(object Form)
        {
            if (this.LeftPanel.Controls.Count>0)
            {
                this.LeftPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Left;
            this.LeftPanel.Controls.Add(f);
            this.LeftPanel.Tag = f;
            f.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.LeftPanel.BringToFront();
            LoadForm(new AddForm());
        }

        public void ScreenEmployee(PictureBox picture, int choice)
        {
            switch (choice)
            {
                case 1:
                    picture.Image = global::MyRestHR.Properties.Resources.manager;
                    picture.InitialImage = global::MyRestHR.Properties.Resources.manager;
                    picture.Size = new System.Drawing.Size(80, 80);
                    picture.BackColor = System.Drawing.Color.Transparent;
                    picture.Cursor = System.Windows.Forms.Cursors.Hand;
                    picture.Location = new System.Drawing.Point(10, 10);
                    picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    picture.TabIndex = 13;
                    picture.TabStop = false;
                    picture.Visible = true;
                    break;
                case 2:
                    picture.Image = global::MyRestHR.Properties.Resources.finalwaiter;
                    picture.InitialImage = global::MyRestHR.Properties.Resources.finalwaiter;
                    picture.Size = new System.Drawing.Size(100, 100);
                    picture.BackColor = System.Drawing.Color.Transparent;
                    picture.Cursor = System.Windows.Forms.Cursors.Hand;
                    picture.Location = new System.Drawing.Point(10, 450);
                    picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    picture.TabIndex = 13;
                    picture.TabStop = false;
                    picture.Visible = true;
                    break;
                case 3:
                    picture.Image = global::MyRestHR.Properties.Resources.bartender;
                    picture.InitialImage = global::MyRestHR.Properties.Resources.bartender;
                    picture.Size = new System.Drawing.Size(100, 100);
                    picture.BackColor = System.Drawing.Color.Transparent;
                    picture.Cursor = System.Windows.Forms.Cursors.Hand;
                    picture.Location = new System.Drawing.Point(405, 10);
                    picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    picture.TabIndex = 13;
                    picture.TabStop = false;
                    picture.Visible = true;
                    break;
                default:
                    break;
            }
        }

        public int view = 0;

        public void MovePanel()
        {
            this.LeftPanel.SendToBack();
        }

        public void DevalitateScreen()
        {
            this.BackGround.Invalidate();
        }

        private void userControl1_Load(object sender, EventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            this.LeftPanel.BringToFront();
            LoadForm(new ViewForm());
            view = 1;
        }
    }
}
