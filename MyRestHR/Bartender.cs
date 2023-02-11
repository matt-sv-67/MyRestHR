using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Media;
using System.Drawing;


namespace MyRestHR
{
    [Serializable]
    public class Bartender : Juniors
    {
        public string SpecialtyDrink { get; set; } //the special drink the bartender can make
        protected Vector _coordinates, _direction;
        private static Random rand = new Random();



        public Bartender(string BartenderName, string BartenderLast, int BartenderAge, double BartenderSenr, string drink)
        {
            Name = BartenderName;
            LastName = BartenderLast;
            Age = BartenderAge;
            Seniorety = BartenderSenr;
            SpecialtyDrink = drink;
            EmployeeID = num++;
            role = 3;
            _coordinates.X = 405;
            _coordinates.Y = 10;
            createDirection();

        }

        public override void ViewDisplay(Label name, Label last, Label age, Label snr, Label extra, Label id, Label pay)
        {
            name.Text = Name;
            last.Text = LastName;
            age.Text = Age.ToString();
            snr.Text = Seniorety.ToString();
            id.Text = EmployeeID.ToString();
            pay.Text = Globalrate.ToString();
            extra.Text = SpecialtyDrink;
        }

        public double getX() { return _coordinates.X; }
        public double getY() { return _coordinates.Y; }
        public void SetX(int val) { _coordinates.X = (double)val; }
        public void SetY(int val) { _coordinates.Y = (double)val; }

        public override bool isInside(int X, int Y)
        {
            return Math.Abs(X - _coordinates.X) <= 100 && Math.Abs(Y - _coordinates.Y) <= 100;
        }

        public override void createDirection()
        {
            _direction.X = rand.Next(0, 100) - 50;
            _direction.Y = rand.Next(0, 50) - 25;
            _direction.Normalize();
            _direction *= _speed;
        }

        public override void updateLocation(bool changeDirection)
        {
            if (changeDirection)
                createDirection();
            if (_coordinates.X + _direction.X <= 405 || _coordinates.X + _direction.X >= 650 ||
                _coordinates.Y + _direction.Y <= 0 || _coordinates.Y + _direction.Y >= 200)
            {
                if (_coordinates.X + _direction.X <= 405 && _coordinates.X + _direction.X > 0 &&
                    _coordinates.Y + _direction.Y > 30 && _coordinates.Y + _direction.Y < 200)
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
