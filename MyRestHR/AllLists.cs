using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyRestHR
{
    internal class AllLists : Employee
    {
        public List<Managers> _managers;
        public List<Waiter> _waiters;
        public List<Bartender> _bartenders;

        public  int countman = 0;
        public  int countwait = 0;
        public  int countbar = 0;

        public AllLists()
        {
            _managers = new List<Managers>();
            _waiters = new List<Waiter>();
            _bartenders = new List<Bartender>();
        }

        public void AddManagerToList(string name, string last, int age, double snr, string res)
        {
            _managers.Add(new Managers(name, last, age, snr, res));
            ((System.ComponentModel.ISupportInitialize)(_managers[countman].picture)).BeginInit();
            ((Form1)Form.ActiveForm).ScreenEmployee(_managers[countman].picture, 1);
            _managers[countman].picture.MouseDown += new MouseEventHandler(((ViewForm)ViewForm.ActiveForm).visual_MouseDown);
            _managers[countman].picture.MouseUp += new MouseEventHandler(((ViewForm)ViewForm.ActiveForm).visual_MouseUp);
            ((Form1)Form.ActiveForm).Controls.Add(_managers[countman].picture);
            ((System.ComponentModel.ISupportInitialize)(_managers[countman].picture)).EndInit();
            _managers[countman].picture.Parent = ((Form1)Form.ActiveForm).BackGround;
            countman++;
        }

        public void AddWaiterToList(string name, string last, int age, double snr, double wght)
        {
            _waiters.Add(new Waiter(name, last, age, snr, wght));
            ((System.ComponentModel.ISupportInitialize)(_waiters[countwait].picture)).BeginInit();
            ((Form1)Form.ActiveForm).ScreenEmployee(_waiters[countwait].picture, 2);
            _waiters[countwait].picture.MouseDown += new MouseEventHandler(((ViewForm)Form1.ActiveForm).visual_MouseDown);
            _waiters[countwait].picture.MouseUp += new MouseEventHandler(((ViewForm)Form1.ActiveForm).visual_MouseUp);
            ((Form1)Form.ActiveForm).Controls.Add(_waiters[countwait].picture);
            ((System.ComponentModel.ISupportInitialize)(_waiters[countwait].picture)).EndInit();
            _waiters[countwait].picture.Parent = ((Form1)Form.ActiveForm).BackGround;
            countwait++;
        }

        public void AddBartenderToList(string name, string last, int age, double snr, string drink)
        {
            _bartenders.Add(new Bartender(name, last, age, snr, drink));
            ((System.ComponentModel.ISupportInitialize)(_bartenders[countbar].picture)).BeginInit();
            ((Form1)Form.ActiveForm).ScreenEmployee(_bartenders[countbar].picture, 3);
            _bartenders[countbar].picture.MouseDown += new MouseEventHandler(((ViewForm)ViewForm.ActiveForm).visual_MouseDown);
            _bartenders[countbar].picture.MouseUp += new MouseEventHandler(((ViewForm)ViewForm.ActiveForm).visual_MouseUp);
            ((Form1)Form.ActiveForm).Controls.Add(_bartenders[countbar].picture);
            ((System.ComponentModel.ISupportInitialize)(_bartenders[countbar].picture)).EndInit();
            _bartenders[countbar].picture.Parent = ((Form1)Form.ActiveForm).BackGround;
            countbar++;
        }
    }
}
