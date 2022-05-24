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
    internal class Managers :  Employee
    {
        //attributes
        string Responsibility { get; set; }
        //{
        //    get
        //    {
        //        return Responsibility;
        //    }
        //    set
        //    {
        //        Responsibility = value;
        //    }
        //}
        public new double Globalrate = 12000;

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
        }

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
}
}
