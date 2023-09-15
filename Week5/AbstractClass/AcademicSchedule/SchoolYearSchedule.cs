using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.AcademicSchedule
{
    public class SchoolYearSchedule : ScheduleStructure
    {
        private DateTime start;
        private DateTime end;
        private DateTime currentDate;

        public SchoolYearSchedule(DateTime currentDate, DateTime start, DateTime end)
            : base(1) //There is only one period in a school year
        {
            this.currentDate = currentDate;
            this.start = start;
            this.end = end;
        }

        public override int GetDaysRemaining()
        {
            TimeSpan timeRemaining = end - currentDate - TimeSpan.FromDays(1);
            return timeRemaining.Days;
        }


        public override int GetDaysUntilNextPeriod()
        {
            DateTime nextSchoolYearStart = new DateTime(currentDate.Year + 1, start.Month, start.Day);
            TimeSpan timeUntilNextSchoolYear = nextSchoolYearStart - currentDate;
            int daysUntilNextSchoolYear = timeUntilNextSchoolYear.Days;

            return daysUntilNextSchoolYear;
        }
    }
}
