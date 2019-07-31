using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class mainForm : Form
    {
        private List<Person> Employees = new List<Person>();
        private string listName;
        private bool isEmployed;

        public mainForm()
        {
            InitializeComponent();
        }

        private void basicInfo_Enter(object sender, EventArgs e)
        {
            
            
        }

        

        public void AddPerson(string fName, string lName, string currentNum)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string inputFirstName = firstName.Text;
            string inputLastName = lastName.Text;
            string inputNumber = phoneNum.Text;
            listName = inputFirstName + " " + inputLastName;
            //AddPerson(inputFirstName, inputLastName, inputNumber);
            isEmployed = false;

            Person newPerson = new Person(inputFirstName, inputLastName, inputNumber);
            Employees.Add(newPerson);
            ListAdder();
            
        }

        private void ListAdder()
        {
            if (isEmployed == true)
            {
                ListViewItem li = new ListViewItem();
                li.ForeColor = Color.Blue;
                li.Text = listName;
                string holdThis = li.Text;
                personList.Items.Add(holdThis);

            }

            else if (isEmployed == false)
            {
                personList.Items.Add(listName);
            }
            
        }

        private void hirePerson_Click(object sender, EventArgs e)
        {
            string inputFirstName = firstName.Text;
            string inputLastName = lastName.Text;
            string inputNumber = phoneNum.Text;
            listName = inputFirstName + " " + inputLastName;
            //AddPerson(inputFirstName, inputLastName, inputNumber);
            isEmployed = true;

            Person newPerson = new Person(inputFirstName, inputLastName, inputNumber);
            Employees.Add(newPerson);
            ListAdder();
        }
    }
}
