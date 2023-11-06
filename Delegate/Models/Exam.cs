using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Delegate.Models
{
    internal class Exam
    {
        public Student student { get; set; }
        public byte Point { get; set; }
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Exam(Student student, byte  point, string subject,DateTime startime,DateTime endtime)
        {
            this.student = student;
            Point = point;
            Subject = subject;
            StartDate = startime;
            EndDate = endtime;
        }
        public override string ToString()
        {
            return $"StudentName: {student.Name}   Subject: {Subject}    Point: {Point}    Duration: {EndDate-StartDate}";

        }

    }
}
