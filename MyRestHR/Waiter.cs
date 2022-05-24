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

    internal class Waiter : Juniors
    {
        public double MaxWeight { get; set; } //max carry weight in KG
        //{
        //    get
        //    {
        //        return MaxWeight;
        //    }
        //    set
        //    {
        //        MaxWeight = value;
        //    }
        //}

        public Waiter(string WaiterName, string WaiterLast, int WaiterAge, double WaiterSenr, double Maxweight)
        {
            Name = WaiterName;
            LastName = WaiterLast;
            Age = WaiterAge;
            Seniorety = WaiterSenr;
            MaxWeight = Maxweight;
            EmployeeID = num++;
            role = 2;
        }


        public override void ViewDisplay(Label name, Label last, Label age, Label snr, Label extra, Label id, Label pay)
        {
            name.Text = Name;
            last.Text = LastName;
            age.Text = Age.ToString();
            snr.Text = Seniorety.ToString();
            id.Text = EmployeeID.ToString();
            pay.Text = Globalrate.ToString();
            extra.Text = MaxWeight.ToString();
        }
    }
}