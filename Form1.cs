using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SERIALIZING_OBJECTS_IN_C__PT._2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phoneNo = txtPhoneNo.Text;
            DateTime dateofBirth = datDateofBirth.Value;
            string department = txtDepartment.Text;
            string salary = txtSalary.Text;

            if(name == "")
            {
                MessageBox.Show("Please enter your name!", "Input Error");
                return;
            }
            if(phoneNo == "")
            {
                MessageBox.Show("Please enter your phone number!", "Input Error");
                return;
            }
            if(dateofBirth == DateTime.Now)
            {
                MessageBox.Show("Please enter your date of birth!", "Input Error");
                return;
            }
            if(department == "")
            {
                MessageBox.Show("Please specify your department!", "Input Error");
                return;
            }
            if(salary == "")
            {
                MessageBox.Show("Please specify your salary!", "Input Error");
                return;
            }

            

            using(FileStream fs = new FileStream("employees.binary",FileMode.Create, FileAccess.Write))
            {
                Employee employee = new Employee(name, phoneNo, dateofBirth, department, salary);

                BinaryFormatter bFormatter = new BinaryFormatter();

                bFormatter.Serialize(fs, employee);

                MessageBox.Show("Your data was saved successfully!", "Data Saved");

                lblStatus.Text = "Object serialized";
                lblStatus.ForeColor = Color.DarkGreen;
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            try
            {
                using(FileStream fs = new FileStream("employees.binary", FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bFormatter = new BinaryFormatter();

                    var employee = (Employee)bFormatter.Deserialize(fs);

                    txtName.Text = employee.Name;
                    txtPhoneNo.Text = employee.PhoneNo;
                    datDateofBirth.Value = employee.DateofBirth;
                    txtDepartment.Text = employee.Department;
                    txtSalary.Text = employee.Salary;

                    MessageBox.Show("Your data was loaded successfully!","Data Loaded");

                    lblStatus.Text = "Object deserialized";
                    lblStatus.ForeColor = Color.DarkRed;
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("File Not Found\n" + ex.Message, "FileNotFoundException");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhoneNo.Clear();
            datDateofBirth.Value = DateTime.Now;
            txtDepartment.Clear();
            txtSalary.Clear();
            lblStatus.Text = "Status";
            lblStatus.ForeColor = Color.Black;
        }
    }
}
