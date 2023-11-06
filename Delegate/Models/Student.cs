using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Models
{
    internal class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public Student(string name, string surname)
        {
            Name = name;
            SurName = surname;
        }

    }
}
