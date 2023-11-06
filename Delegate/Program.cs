using Delegate.Models;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surName;
            string subject;
            byte point=0;
            DateTime startTime;
            DateTime endTime;
            Services services=new Services();
            bool iscontinue = true;
            while (iscontinue)
            {
                Console.WriteLine("1. Create Exam\n2. Show point more than 50\n3. Show last week exams\n4. Show longer than 1 hour\n5. Quit");
                string a=Console.ReadLine();
                switch (a)
                {
                    case "1":
                        Console.WriteLine("Enter name:");                   name =Console.ReadLine();
                        Console.WriteLine("Enter surname:");                surName = Console.ReadLine();
                        Console.WriteLine("Enter subject name:");           subject = Console.ReadLine();
                        bool istrue = true;
                        while (istrue)
                        {
                            Console.WriteLine("Enter point:");
                            point = Convert.ToByte(Console.ReadLine());
                            if (point<0 ||point>100)
                            {
                                Console.WriteLine("Wrong point input!!(0-100)");
                            }
                            else
                            {
                                istrue = false;
                            }
                        }
                        Console.WriteLine("Enter exam start date (example: 2023/2/12 11:24:21  yyyy/mm/dd hh:mm:ss):");
                        startTime = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter exam end date (example: 2023/2/12 11:24:21  yyyy/mm/dd hh:mm:ss):");
                        endTime = Convert.ToDateTime(Console.ReadLine());
                        Student telebe = new Student(name,surName);
                        Exam imtahan = new Exam(telebe,point,subject,startTime,endTime);
                        services.Exams.Add(imtahan);
                        break;
                    case "2":
                        services.MoreThan50();
                        break;
                    case "3":
                        services.LastWeekExams();
                        break;
                    case "4":
                        services.LongerThanOneHour();
                        break;
                    case "5":   
                        iscontinue = false;
                        break;
                    default: Console.WriteLine("Wrong input:");
                        break;
                }
            }
        }
    }
}