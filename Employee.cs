using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SERIALIZING_OBJECTS_IN_C__PT._2_
{
    [Serializable]
    public class Employee
    {
        private string mName;
        private string mPhoneNo;
        private DateTime mDateofBirth;
        private string mDepartment;
        private string mSalary;

        public Employee()
        {
            mName = "";
            mPhoneNo = "";
            mDateofBirth = DateTime.Now;
            mDepartment = "";
            mSalary = "";
        }

        public Employee(string name, string phoneNo, DateTime dateofBirth, string department, string salary)
        {
            mName = name;
            mPhoneNo = phoneNo;
            mDateofBirth = dateofBirth;
            mDepartment = department;
            mSalary = salary;
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public string PhoneNo
        {
            get { return mPhoneNo; }
            set { mPhoneNo = value; }
        }
        public DateTime DateofBirth
        {
            get { return mDateofBirth; }
            set { mDateofBirth = value; }
        }
        public string Department
        {
            get { return mDepartment; }
            set { mDepartment = value; }
        }
        public string Salary
        {
            get { return mSalary; }
            set { mSalary = value; }
        }
    }
}
