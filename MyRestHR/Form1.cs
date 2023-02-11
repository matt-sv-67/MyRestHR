using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyRestHR
{
    [Serializable]
    public partial class Form1 : Form
    {

        AllLists lists = new AllLists();

        //public AllLists lsts = ((AddForm)AddForm.ActiveForm).ReturnLists();

        public List<PictureBox> EmployeeGifs = new List<PictureBox>();
        public int view = 0;
        int ClickedOn = 0;
        private int curIndex, moveTickCount;
        public int prevIndex;

        public Form1()
        {
            InitializeComponent();
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
            SaveLoadBack();
            LoadForm(new AddForm(this.lists));
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
        

        
        public void visual_MouseDown(object sender, MouseEventArgs e)
        {
            if (((Form1)Form1.ActiveForm).view == 1)
            {

                PictureBox visual = new PictureBox();
                visual = (PictureBox)sender;
                curIndex = -1;
                if (ClickedOn == 0)
                {
                    for (int i = 0; i < lists.countman; i++)
                    {
                        if ((lists._managers[i]).isInside(visual.Location.X + e.X, visual.Location.Y + e.Y))
                        {
                            ClickedOn = 1;
                            string s = e.Button.ToString();
                            if (s == "Left")
                            {
                                ViewForm vf = new ViewForm(lists);
                                LoadForm(vf);

                                (lists._managers[i]).ViewDisplay(vf.fillname,
                                                              vf.filllast,
                                                              vf.fillage,
                                                              vf.fillsnr,
                                                              vf.fillextra,
                                                              vf.fillid,
                                                              vf.fillpay); //send labels of viewform
                                curIndex = i;
                                (lists._managers[i]).setSpeed(0);
                                break;
                            }
                        }
                    }
                }
                for (int i = 0; i < lists.countwait; i++)
                {
                    if ((lists._waiters[i]).isInside(visual.Location.X + e.X, visual.Location.Y + e.Y))
                    {
                        ClickedOn = 2;
                        string s = e.Button.ToString();
                        if (s == "Left")
                        {
                            ViewForm vf = new ViewForm(lists);
                            LoadForm(vf);
                            (lists._waiters[i]).ViewDisplay(vf.fillname,
                                                              vf.filllast,
                                                              vf.fillage,
                                                              vf.fillsnr,
                                                              vf.fillextra,
                                                              vf.fillid,
                                                              vf.fillpay); //send labels of viewform
                            curIndex = i;
                            (lists._waiters[i]).setSpeed(0);
                            break;
                        }
                    }
                }
                for (int i = 0; i < lists.countbar; i++)
                {
                    if ((lists._bartenders[i]).isInside(visual.Location.X + e.X, visual.Location.Y + e.Y))
                    {
                        ClickedOn = 3;
                        string s = e.Button.ToString();
                        if (s == "Left")
                        {
                            ViewForm vf = new ViewForm(lists);
                            LoadForm(vf);
                            (lists._bartenders[i]).ViewDisplay(vf.fillname,
                                                              vf.filllast,
                                                              vf.fillage,
                                                              vf.fillsnr,
                                                              vf.fillextra,
                                                              vf.fillid,
                                                              vf.fillpay); //send labels of viewform
                            curIndex = i;
                            (lists._bartenders[i]).setSpeed(0);
                            break;
                        }
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
                        (lists._managers[curIndex]).setSpeed(2);
                        break;
                    case 2:
                        (lists._waiters[curIndex]).setSpeed(2);
                        break;
                    case 3:
                        (lists._bartenders[curIndex]).setSpeed(2);
                        break;
                    default:
                        break;
                }
            }

            curIndex = -1;
            ClickedOn = 0;
        }

       

        public void MovePanel()
        {
            this.LeftPanel.SendToBack();
        }





        private void moveEmployee_Tick_1(object sender, EventArgs e)
        {
            moveTickCount++;
            
            int i;
            if (moveTickCount == 20)
            {
                moveTickCount = 0;

                for (i = 0; i < lists.countman; i++)
                {
                    lists._managers[i].updateLocation(true);
                    lists._managers[i].picture.Location = new Point((int)lists._managers[i].getX(), (int)lists._managers[i].getY());
                }

                for (i = 0; i < lists.countwait; i++)
                {
                    lists._waiters[i].updateLocation(true);
                    lists._waiters[i].picture.Location = new Point((int)lists._waiters[i].getX(), (int)lists._waiters[i].getY());
                }

                for (i = 0; i < lists.countbar; i++)
                {
                    lists._bartenders[i].updateLocation(true);
                    lists._bartenders[i].picture.Location = new Point((int)lists._bartenders[i].getX(), (int)lists._bartenders[i].getY());
                }
            }
            else
            {
                for (i = 0; i < lists.countman; i++)
                {
                    lists._managers[i].updateLocation(false);
                    lists._managers[i].picture.Location = new Point((int)lists._managers[i].getX(), (int)lists._managers[i].getY());
                }

                for (i = 0; i < lists.countwait; i++)
                {
                    lists._waiters[i].updateLocation(false);
                    lists._waiters[i].picture.Location = new Point((int)lists._waiters[i].getX(), (int)lists._waiters[i].getY());
                }
                for (i = 0; i < lists.countbar; i++)
                {
                    lists._bartenders[i].updateLocation(false);
                    lists._bartenders[i].picture.Location = new Point((int)lists._bartenders[i].getX(), (int)lists._bartenders[i].getY());
                }
            }
        }

        private void userControl1_Load(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "restaurant files (*.rst)|*.rst|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, lists);
                }
            }
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "restaurant files (*.rst)|*.rst|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                lists = (AllLists)binaryFormatter.Deserialize(stream);
            }
        }

        private void savebtn_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "restaurant files (*.rst)|*.rst|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, lists);
                }
            }
        }

        private void loadbtn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "restaurant files (*.rst)|*.rst|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                lists = (AllLists)binaryFormatter.Deserialize(stream);
            }
        }

        public void SaveLoadFront()
        {
            loadbtn.BringToFront();
            savebtn.BringToFront();
        }

        public void SaveLoadBack()
        {
            loadbtn.SendToBack();
            savebtn.SendToBack();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            this.LeftPanel.BringToFront();
            SaveLoadBack();
            LoadForm(new ViewForm(lists));
            view = 1;
        }
    }
}
