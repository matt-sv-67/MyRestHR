using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Media;

namespace MyRestHR
{
    [Serializable]
    public  class Managers :  Employee
    {
        //attributes
        string Responsibility { get; set; }

        public new double Globalrate = 12000;
        protected Vector _coordinates, _direction;
        private static Random rand = new Random();


        //methods
        public Managers(string ManagerName, string ManagerLast, int ManagerAge, double ManagerSenr, string res)
        {
            Name = ManagerName;
            LastName = ManagerLast;
            Age = ManagerAge;
            Seniorety = ManagerSenr;
            Responsibility = res;
            EmployeeID = num++;
            role = 1;
            _coordinates.X = 10;
            _coordinates.Y = 10;
            createDirection();

        }

        public double getX() { return _coordinates.X; }
        public double getY() { return _coordinates.Y; }
        public void SetX(int val) { _coordinates.X = (double)val; }
        public void SetY(int val) { _coordinates.Y = (double)val; }

        public override void ViewDisplay(Label name, Label last, Label age, Label snr, Label extra, Label id, Label pay)
        {
            name.Text = Name;
            last.Text = LastName;
            age.Text = Age.ToString();
            snr.Text = Seniorety.ToString();
            id.Text = EmployeeID.ToString();
            pay.Text = Globalrate.ToString();
            extra.Text = Responsibility;

        }

        public override bool isInside(int X, int Y)
        {
            return Math.Abs(X - _coordinates.X) <= 80 && Math.Abs(Y - _coordinates.Y) <= 80;
        }

        public override void createDirection()
        {
            _direction.X = rand.Next(0, 200) - 100;
            _direction.Y = rand.Next(0, 200) - 100;
            _direction.Normalize();
            _direction *= _speed;
        }

        public override void updateLocation(bool changeDirection)
        {
            if (changeDirection)
                createDirection();
            if (_coordinates.X + _direction.X <= 10 || _coordinates.X + _direction.X >= 650 ||
                _coordinates.Y + _direction.Y <= 0 || _coordinates.Y + _direction.Y >= 450)
            {
                if (_coordinates.X + _direction.X <= 10 && _coordinates.X + _direction.X > 0 &&
                    _coordinates.Y + _direction.Y > 30 && _coordinates.Y + _direction.Y < 420)
                {
                    _coordinates += _direction;
                    return;
                }
                _direction = -_direction;
            }
            _coordinates += _direction;
        }
    }
}
