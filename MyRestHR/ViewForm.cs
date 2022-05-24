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
    public partial class ViewForm : Form
    {
        AllLists lsts = new AllLists();

        private int curIndex;
        public ViewForm()
        {
            InitializeComponent();
            Headerlbl.Text = "Choose employee to display";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            ((Form1)Form1.ActiveForm).MovePanel();
            ((Form1)Form1.ActiveForm).view = 0;

        }
        int ClickedOn;
        public void visual_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox visual = new PictureBox();
            visual = (PictureBox)sender;
            curIndex = -1;
            for (int i = 0; i < lsts.countman; i++)
            {
                if (lsts._managers[i].isInside(visual.Location.X + e.X, visual.Location.Y + e.Y))
                {
                    ClickedOn = 1;
                    string s = e.Button.ToString();
                    if (s == "Left")
                    {
                        lsts._managers[i].ViewDisplay( fillname,  filllast,  fillage,  fillsnr,  fillextra,  fillid,  fillpay);
                        curIndex = i;
                        lsts._managers[i].setSpeed(0);
                        break;
                    }
                }
            }
            for (int i = 0; i < lsts.countwait; i++)
            {
                if (lsts._waiters[i].isInside(visual.Location.X + e.X, visual.Location.Y + e.Y))
                {
                    ClickedOn = 2;
                    string s = e.Button.ToString();
                    if (s == "Left")
                    {
                        lsts._waiters[i].ViewDisplay(fillname, filllast, fillage, fillsnr, fillextra, fillid, fillpay);
                        curIndex = i;
                        lsts._waiters[i].setSpeed(0);
                        break;
                    }
                }
            }
            for (int i = 0; i < lsts.countbar; i++)
            {
                if (lsts._bartenders[i].isInside(visual.Location.X + e.X, visual.Location.Y + e.Y))
                {
                    ClickedOn = 3;
                    string s = e.Button.ToString();
                    if (s == "Left")
                    {
                        lsts._bartenders[i].ViewDisplay(fillname, filllast, fillage, fillsnr, fillextra, fillid, fillpay);
                        curIndex = i;
                        lsts._bartenders[i].setSpeed(0);
                        break;
                    }
                }
            }
        }

        public void visual_MouseUp(object sender, MouseEventArgs e)
        {                     
            if (curIndex >= 0)
            {
                switch (ClickedOn)
                {
                    case 1:
                        lsts._managers[curIndex].setSpeed(3);
                        break;
                    case 2:
                        lsts._waiters[curIndex].setSpeed(3);
                        break;
                    case 3:
                        lsts._bartenders[curIndex].setSpeed(3);
                        break;
                    default:
                        break;
                }
            }
                
            curIndex = -1;
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void extralbl_Click(object sender, EventArgs e)
        {

        }

        private void snrlbl_Click(object sender, EventArgs e)
        {

        }

        private void agelbl_Click(object sender, EventArgs e)
        {

        }

        private void lastlbl_Click(object sender, EventArgs e)
        {

        }

        private void namelbl_Click(object sender, EventArgs e)
        {

        }

        private void fillname_Click(object sender, EventArgs e)
        {

        }
    }
}
