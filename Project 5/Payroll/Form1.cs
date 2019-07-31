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
        private bool onPayroll;
        private Person newPerson;

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

        private void ListAdder()
        {
            int counter = -1;

            if (payrollYes.Checked)
            {
                personList.Items.Add(firstName.Text + " " + lastName.Text + "***");
            }

            if(payrollNo.Checked)
            {
                personList.Items.Add(firstName.Text + " " + lastName.Text);
            }
               
        }

        private void hirePerson_Click(object sender, EventArgs e)
        {
            string inputFirstName = firstName.Text;
            string inputLastName = lastName.Text;
            string inputNumber = phoneNum.Text;
            newPerson = new Person(inputFirstName, inputLastName, inputNumber);

            string inputAddress = addressInfo.Text;
            string inputAptNum = pAptNum.Text;
            string inputCity = pCity.Text;
            string inputState = pState.Text;
            string inputZip = pZip.Text;
            Employee newEmployee = new Employee(inputAddress, inputAptNum, inputCity, inputState, inputZip);



            Employees.Add(newPerson);
            ListAdder();
        }

        private void personList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.personList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MessageBox.Show(index.ToString());
                

            }
        }
    }
}
