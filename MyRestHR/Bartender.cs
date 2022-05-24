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
    internal class Bartender : Juniors
    {
        public string SpecialtyDrink { get; set; } //the special drink the bartender can make
        //{
        //    get
        //    {
        //        return SpecialtyDrink;
        //    }
        //    set
        //    {
        //        SpecialtyDrink = value;
        //    }
        //}

        public Bartender(string BartenderName, string BartenderLast, int BartenderAge, double BartenderSenr, string drink)
        {
            Name = BartenderName;
            LastName = BartenderLast;
            Age = BartenderAge;
            Seniorety = BartenderSenr;
            SpecialtyDrink = drink;
            EmployeeID = num++;
            role = 3;
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
    }


}
