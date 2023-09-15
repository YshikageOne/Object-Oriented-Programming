using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.AcademicSchedule
{
    public class MainAcademic
    {
        public static void Main(string[] args)
        {
            Console.Write("Select Influencer (1 - Semestral, 2 - SchoolYear): ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("\nEnter current month: ");
            int currentMonth = int.Parse(Console.ReadLine());
            Console.Write("Enter current date: ");
            int currentDate = int.Parse(Console.ReadLine());
            Console.Write("Enter current year: ");
            int currentYear = int.Parse(Console.ReadLine());
            DateTime currentDateObj = new DateTime(currentYear, currentMonth, currentDate);

            if (choice == 1)
            {
                Console.WriteLine("\nSemester 1");
                Console.Write("Start month: ");
                int sem1StartMonth = int.Parse(Console.ReadLine());
                Console.Write("Start date: ");
                int sem1StartDate = int.Parse(Console.ReadLine());
                Console.Write("Start year: ");
                int sem1StartYear = int.Parse(Console.ReadLine());
                DateTime sem1Start = new DateTime(sem1StartYear, sem1StartMonth, sem1StartDate);

                Console.Write("End month: ");
                int sem1EndMonth = int.Parse(Console.ReadLine());
                Console.Write("End date: ");
                int sem1EndDate = int.Parse(Console.ReadLine());
                Console.Write("End year: ");
                int sem1EndYear = int.Parse(Console.ReadLine());
                DateTime sem1End = new DateTime(sem1EndYear, sem1EndMonth, sem1EndDate);

                Console.WriteLine("\nSemester 2");
                Console.Write("Start month: ");
                int sem2StartMonth = int.Parse(Console.ReadLine());
                Console.Write("Start date: ");
                int sem2StartDate = int.Parse(Console.ReadLine());
                Console.Write("Start year: ");
                int sem2StartYear = int.Parse(Console.ReadLine());
                DateTime sem2Start = new DateTime(sem2StartYear, sem2StartMonth, sem2StartDate);

                Console.Write("End month: ");
                int sem2EndMonth = int.Parse(Console.ReadLine());
                Console.Write("End date: ");
                int sem2EndDate = int.Parse(Console.ReadLine());
                Console.Write("End year: ");
                int sem2EndYear = int.Parse(Console.ReadLine());
                DateTime sem2End = new DateTime(sem2EndYear, sem2EndMonth, sem2EndDate);

                Console.Write("Enter period number ");
                int periodNumber = int.Parse(Console.ReadLine());

                SemestralSchedule semestralSchedule = new SemestralSchedule(currentDateObj, sem1Start, sem1End, sem2Start, sem2End, periodNumber);
                Tester.Test(semestralSchedule);
            }
            else if (choice == 2)
            {
                Console.Write("Start month: ");
                int startMonth = int.Parse(Console.ReadLine());
                Console.Write("Start date: ");
                int startDate = int.Parse(Console.ReadLine());
                Console.Write("Start year: ");
                int startYear = int.Parse(Console.ReadLine());
                DateTime start = new DateTime(startYear, startMonth, startDate);

                Console.Write("End month: ");
                int endMonth = int.Parse(Console.ReadLine());
                Console.Write("End date: ");
                int endDate = int.Parse(Console.ReadLine());
                Console.Write("End year: ");
                int endYear = int.Parse(Console.ReadLine());
                DateTime end = new DateTime(endYear, endMonth, endDate);

                SchoolYearSchedule schoolYearSchedule = new SchoolYearSchedule(currentDateObj, start, end);
                Tester.Test(schoolYearSchedule);
            }
        }
    }
}
