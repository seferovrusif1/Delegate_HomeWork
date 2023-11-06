using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Delegate.Models
{
    internal class Services
    {
        public List<Exam> Exams = new List<Exam>();
        public void AddExam(Exam exam)
        {
            Exams.Add(exam);
        }
        public void MoreThan50()
        {
            var a=Exams.FindAll(x => x.Point > 50);
            a.ForEach(x=>Console.WriteLine(x));
        }
        public void LongerThanOneHour()
        {
            var a = Exams.FindAll(x => (x.EndDate - x.StartDate).TotalHours>1);
            a.ForEach(x => Console.WriteLine(x));

        }
        public void LastWeekExams()
        {
            var a = Exams.FindAll(x => (DateTime.Now- x.StartDate).TotalDays < 7);
            a.ForEach(x => Console.WriteLine(x));

        }
    }
}
