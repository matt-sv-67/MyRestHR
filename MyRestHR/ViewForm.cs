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
    [Serializable]
    public partial class ViewForm : Form
    {
        AllLists _lists;

        public ViewForm(AllLists lists)
        {
            InitializeComponent();
            Headerlbl.Text = "Choose Employee To Display";
            _lists = lists;
        }

        private void button3_Click(object sender, EventArgs e)          // return button
        {
            this.Close();
            ((Form1)Form1.ActiveForm).SaveLoadFront();
            ((Form1)Form1.ActiveForm).MovePanel();
            ((Form1)Form1.ActiveForm).view = 0;
        }


        private void Firebtn_Click(object sender, EventArgs e)             //Remove Employee
        {
            if (_lists.countman != 0 || _lists.countwait != 0 || _lists.countbar != 0)
            {


                int DeleteID = Convert.ToInt32(fillid.Text);

                Managers ManToRemvore = _lists._managers.Find(r => r.EmployeeID == DeleteID);
                Waiter WitToRemvore = _lists._waiters.Find(r => r.EmployeeID == DeleteID);
                Bartender BarToRemvore = _lists._bartenders.Find(r => r.EmployeeID == DeleteID);

                if (ManToRemvore != null)
                {
                    ManToRemvore.picture.Dispose();
                    _lists._managers.RemoveAll(r => r.EmployeeID == DeleteID);
                    _lists.countman--;
                }
                if (WitToRemvore != null)
                {
                    WitToRemvore.picture.Dispose();
                    _lists._waiters.RemoveAll(r => r.EmployeeID == DeleteID);
                    _lists.countwait--;
                }
                if (BarToRemvore != null)
                {
                    BarToRemvore.picture.Dispose();
                    _lists._bartenders.RemoveAll(r => r.EmployeeID == DeleteID);
                    _lists.countbar--;
                }

            ((Form1)Form1.ActiveForm).prevIndex = -1;
                ClearEmployeeview();
            }
        }




        private void ClearEmployeeview()
        {
            fillid.Text = null;
            fillname.Text = null;
            filllast.Text = null;
            fillage.Text = null;
            fillsnr.Text = null;
            fillextra.Text = null;
            fillpay.Text = null;
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
