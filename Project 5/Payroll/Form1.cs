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
        }

        private void ListAdder()
        {
            int counter = -1;

            if (payrollYes.Checked)
            {
                /*
                counter++;
                personList.Items[counter].
                ListViewItem li = new ListViewItem();
                li.ForeColor = Color.Blue;
                li.Text = listName;
                string holdThis = li.Text;
                personList.Items.Add(holdThis);
                personList.Items.Add(firstName.Text + ", " + lastName.Text);
                personList.Items[counter] = Color.Blue;
                ForeColor = Color.Blue;*/
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
            listName = inputFirstName + " " + inputLastName;
            //AddPerson(inputFirstName, inputLastName, inputNumber);
            Person newPerson = new Person(inputFirstName, inputLastName, inputNumber);
            Employees.Add(newPerson);
            ListAdder();
        }

        private void personList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
