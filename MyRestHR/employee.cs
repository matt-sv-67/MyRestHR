using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;
using System.Media;


namespace MyRestHR
{
    [Serializable]
    public abstract class Employee
    {
        //attributes
        public static int num = 1;

        public int role;

        protected double _speed = 2;

        //   private static Random rand = new Random();

        public virtual bool isInside(int X, int Y) { return true;  }
        //public double getX() { return _coordinates.X; }
        //public double getY() { return _coordinates.Y; }
        //public void SetX(int val) { _coordinates.X = (double)val; }
        //public void SetY(int val) { _coordinates.Y = (double)val; }
        public double getSpeed() { return _speed; }
        public void setSpeed(int val) { _speed = val; }
        public virtual void updateLocation(bool changeDirection) { }
        public virtual void createDirection() { }


        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public double Seniorety { get; set; } //in years

        public int EmployeeID { get; set; }

        public double Globalrate;

        public PictureBox picture = new PictureBox();


        public virtual void ViewDisplay(Label name, Label last, Label age, Label snr, Label extra, Label id, Label pay) {   }

    }







}
