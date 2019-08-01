using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Payroll
{
    class Employee : Person
    {
        private string userAddress;
        private string userApt;
        private string userCity;
        private string userState;
        private string userZip;

        public Employee(Person pName, string pAddress, string pApt, string pCity, string pState, string pZip)
        {
            userAddress = pAddress;
            userApt = pApt;
            userCity = pCity;
            userState = pState;
            userZip = pZip;
            return;
        }

        public Employee()
        {
            return;
        }
        


    }
}
