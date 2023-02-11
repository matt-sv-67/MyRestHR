using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestHR
{
    [Serializable]
    public  abstract class Juniors : Employee
    {
        string Level
        {
            get
            {
                return Level;
            }
            set
            {
                Level = value;
            }
        }
        public new double Globalrate = 5300;
    }
}
