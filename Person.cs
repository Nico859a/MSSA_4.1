using Assignment4._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._1
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNum { get; set; }
        public string WorkNum { get; set; }
        public string Address { get; set; }

        public Person(string firstName, string lastName, string mobileNum, string workNum, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            MobileNum = mobileNum;
            WorkNum = workNum;
            Address = address;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
