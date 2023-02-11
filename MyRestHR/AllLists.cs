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
    [Serializable]
    public class AllLists : Employee
    {
        public List<Managers> _managers;
        public List<Waiter> _waiters;
        public List<Bartender> _bartenders;

        public int countman = 0;
        public int countwait = 0;
        public int countbar = 0;

        public AllLists()
        {
            _managers = new List<Managers>();
            _waiters = new List<Waiter>();
            _bartenders = new List<Bartender>();
        }

        public void AddManagerToList(string name, string last, int age, double snr, string res)
        {
            _managers.Add(new Managers(name, last, age, snr, res));
            countman++;

            ((System.ComponentModel.ISupportInitialize)(_managers[countman-1].picture)).BeginInit();
            ((Form1)Form.ActiveForm).ScreenEmployee(_managers[countman-1].picture, 1);
            _managers[countman-1].picture.MouseDown += new MouseEventHandler(((Form1)Form.ActiveForm).visual_MouseDown);
            _managers[countman-1].picture.MouseUp += new MouseEventHandler(((Form1)Form.ActiveForm).visual_MouseUp);
            ((Form1)Form.ActiveForm).Controls.Add(_managers[countman-1].picture);
            ((System.ComponentModel.ISupportInitialize)(_managers[countman-1].picture)).EndInit();
            _managers[countman-1].picture.Parent = ((Form1)Form.ActiveForm).BackGround;
        }

        public void AddWaiterToList(string name, string last, int age, double snr, double wght)
        {
            _waiters.Add(new Waiter(name, last, age, snr, wght));
            countwait++;

            ((System.ComponentModel.ISupportInitialize)(_waiters[countwait-1].picture)).BeginInit();
            ((Form1)Form.ActiveForm).ScreenEmployee(_waiters[countwait-1].picture, 2);
            _waiters[countwait-1].picture.MouseDown += new MouseEventHandler(((Form1)Form.ActiveForm).visual_MouseDown);
            _waiters[countwait-1].picture.MouseUp += new MouseEventHandler(((Form1)Form.ActiveForm).visual_MouseUp);
            ((Form1)Form.ActiveForm).Controls.Add(_waiters[countwait-1].picture);
            ((System.ComponentModel.ISupportInitialize)(_waiters[countwait-1].picture)).EndInit();
            _waiters[countwait-1].picture.Parent = ((Form1)Form.ActiveForm).BackGround;
        }

        public void AddBartenderToList(string name, string last, int age, double snr, string drink)
        {
            
            _bartenders.Add(new Bartender(name, last, age, snr, drink));
            countbar++;

            ((System.ComponentModel.ISupportInitialize)(_bartenders[countbar-1].picture)).BeginInit();
            ((Form1)Form.ActiveForm).ScreenEmployee(_bartenders[countbar-1].picture, 3);
            _bartenders[countbar-1].picture.MouseDown += new MouseEventHandler(((Form1)Form.ActiveForm).visual_MouseDown);
            _bartenders[countbar-1].picture.MouseUp += new MouseEventHandler(((Form1)Form.ActiveForm).visual_MouseUp);
            ((Form1)Form.ActiveForm).Controls.Add(_bartenders[countbar-1].picture);
            ((System.ComponentModel.ISupportInitialize)(_bartenders[countbar-1].picture)).EndInit();
            _bartenders[countbar-1].picture.Parent = ((Form1)Form.ActiveForm).BackGround;
        }

        
    }
}
