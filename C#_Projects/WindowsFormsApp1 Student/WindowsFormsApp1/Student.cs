using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Student : IComparable<Student>
    {
        private string lastname;
        private string firstname;
        private string group;
        private double exam;
        private double coursework;

        public static object List { get; internal set; }

        public Student(string ln, string fn, string gr, double ex, double cw)
        {
            lastname = ln;
            firstname = fn;
            group = gr;
            exam = ex;
            coursework = cw;
        }
        public string Info()
        {
            string s = lastname + " " + firstname + " " + group + " " + exam + " " +
           coursework;
            return s;
        }

        public string getLastName()
        {
            return lastname;
        }

        public int CompareTo(Student obj)
        {
            int result = this.lastname.CompareTo(obj.lastname);
            if (result == 0)
            {
                result = this.firstname.CompareTo(obj.firstname);
            }
            return result;
        }
    }
}
