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
            personList.DataSource = Employees;
        }

        private void basicInfo_Enter(object sender, EventArgs e)
        {

        }
        
        public void AddPerson(string fName, string lName, string currentNum)
        {

        }

        private void ListAdder()
        {
            Employees.Add(newPerson);
            //int counter = -1;
            
            if (payrollYes.Checked)
            {
                //personList.Items.Add(firstName.Text + " " + lastName.Text + "***");
            }

            if (payrollNo.Checked)
            {
                //personList.Items.Add(firstName.Text + " " + lastName.Text);
            }
        }

        private void hirePerson_Click(object sender, EventArgs e)
        {
            string inputFirstName = firstName.Text;
            string inputLastName = lastName.Text;
            string inputNumber = phoneNum.Text;
            newPerson = new Person(inputFirstName, inputLastName, inputNumber);

            string empName = inputFirstName + " " + inputLastName;
            string inputAddress = addressInfo.Text;
            string inputAptNum = pAptNum.Text;
            string inputCity = pCity.Text;
            string inputState = pState.Text;
            string inputZip = pZip.Text;
            Employee newEmployee = new Employee(newPerson, inputAddress, inputAptNum, inputCity, inputState, inputZip);
            


            
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

        private static Random rand = new Random(DateTime.Now.Second);
        private void generateHuman_Click(object sender, EventArgs e)
        {
            RandName();
        }
        
        private void RandName()
        {
            string[] randFirstNames = new string[] { "Abby", "Abigail", "Adele", "Adrian", "Aaron", "Abdulai", "Abe", "Abel", "Abraham", "Adam", "Adan", "Adolfo", "Adolph", "Adrian"};
            string[] randLastNames = new string[] { "Abbott", "Acosta", "Adams", "Adkins", "Aguilar", "Smith", "Scott", "McKenzie", "Sallah", "Thomas", "Taylor" };
            

            Random rand = new Random(DateTime.Now.Second);
            firstName.Text = randFirstNames[rand.Next(0, randFirstNames.Length - 1)];
            lastName.Text = randLastNames[rand.Next(0, randLastNames.Length - 1)];
        }

    }
}
