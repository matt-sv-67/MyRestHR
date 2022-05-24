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

        protected Vector _coordinates, _direction;
        protected double _speed = 3;

        public virtual bool isInside(int X, int Y) { return true; }

        public double getX() { return _coordinates.X; }
        public double getY() { return _coordinates.Y; }
        public void SetX(int val) { _coordinates.X = (double)val; }
        public void SetY(int val) { _coordinates.Y = (double)val; }
        public double getSpeed() { return _speed; }
        public void setSpeed(int val) { _speed = val; }

        public string Name { get; set; }
        //{
        //    //get;
        //    //{
        //    //    //return Name;
        //    //}
        //    //set;
        //    //{
        //    //   // Name = value; //remeber to update
        //    //}
        //}
        public string LastName { get; set; }
        //{
        //    get
        //    {
        //        return LastName;
        //    }
        //    set
        //    {
        //        LastName = value; //remeber to update
        //    }
        //}
        public int Age { get; set; }
        //{
        //    get
        //    {
        //        return Age;
        //    }
        //    set
        //    {
        //        Age = value; //remeber to update
        //    }
        //}
        public double Seniorety { get; set; } //in years
        //{
        //    get
        //    {
        //        return Seniorety;
        //    }
        //    set
        //    {
        //        Seniorety = value; //remember to update
        //    }
        //}
        public int EmployeeID { get; set; }
        //{
        //    get
        //    {
        //        return EmployeeID;
        //    }
        //    set
        //    {
        //        EmployeeID = num++;
        //    }
        //}
        public double Globalrate;
        //public Image image; //remember to edit!!!

        //methods
        //public Employee(string name, string last, int age, double senr)
        //{
        //    Name = name;
        //    LastName = last;
        //    Age = age;
        //    Seniorety = senr;
        //}
        public PictureBox picture = new PictureBox();


        public virtual void ViewDisplay(Label name, Label last, Label age, Label snr, Label extra, Label id, Label pay)
        {

        }

    }







}
