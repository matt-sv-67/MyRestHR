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
    public partial class AddForm : Form
    {
        //fields
        AllLists lists = new AllLists();
        
        //methods
        public AddForm()
        {
            InitializeComponent();
            extratext.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            ((Form1)Form1.ActiveForm).MovePanel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int choice = 1;
        private void managerbtn_CheckedChanged(object sender, EventArgs e)
        {
            extratext.Visible = true;
            extralbl.Text = "Responsebility:";
            choice = 1;
        }

        private void waiterbtn_CheckedChanged(object sender, EventArgs e)
        {
            extratext.Visible = true;
            extralbl.Text = "Can Carry:";
            choice = 2;
        }

        private void barbtn_CheckedChanged(object sender, EventArgs e)
        {
            extratext.Visible = true;
            extralbl.Text = "Specialty Drink:";
            choice = 3;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            int flag = 1;
            if (String.IsNullOrWhiteSpace(nametext.Text))
            {
                MessageBox.Show("Name field must be filled!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 0;
            }
            if (String.IsNullOrWhiteSpace(lasttext.Text))
            {
                MessageBox.Show("Surname field must be filled!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 0;
            }
            if (String.IsNullOrWhiteSpace(agetext.Text))
            {
                MessageBox.Show("Age field must be filled!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 0;
            }
            else
            {
                if ((Convert.ToInt32(agetext.Text)<18) || (Convert.ToInt32(agetext.Text)>99))
                {
                    MessageBox.Show("Age must be over 18 and under 99!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 0;
                }
            }
            if (String.IsNullOrWhiteSpace(snrtext.Text))
            {
                MessageBox.Show("Seniority field must be filled!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 0;
            }
            if (String.IsNullOrWhiteSpace(extratext.Text))
            {
                MessageBox.Show("This field must be filled!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 0;
            }
            if (flag == 1)
            {
                switch (choice)
                {
                    case 1:
                        lists.AddManagerToList(nametext.Text,
                                               lasttext.Text,
                                               Convert.ToInt32(agetext.Text),
                                               Convert.ToDouble(snrtext.Text),
                                               extratext.Text);
                        break;
                    case 2:
                        lists.AddWaiterToList(nametext.Text,
                                               lasttext.Text,
                                               Convert.ToInt32(agetext.Text),
                                               Convert.ToDouble(snrtext.Text),
                                               Convert.ToDouble(extratext.Text)); 
                        break;
                    case 3:
                        lists.AddBartenderToList(nametext.Text,
                                               lasttext.Text,
                                               Convert.ToInt32(agetext.Text),
                                               Convert.ToDouble(snrtext.Text),
                                               extratext.Text);
                        break;
                    default:
                        break;
                }
                nametext.Text = null;
                lasttext.Text = null;
                agetext.Text = null;
                snrtext.Text = null;
                extratext.Text = null;
            }




        }
    }
}
