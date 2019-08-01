using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Person
    {
        private string userFirstName;
        private string userLastName;
        private string userNumber;

        public Person(string fName, string lName, string currentNum)
        {
            userFirstName = fName;
            userLastName = lName;
            userNumber = currentNum;
            return;
        }

        public Person()
        {
            return;
        }

        public override string ToString()
        {
            return userFirstName + " " + userLastName;
        }
    }
}
