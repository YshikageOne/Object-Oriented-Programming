using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.AcademicSchedule
{
    public class SemestralSchedule : ScheduleStructure
    {
        private DateTime[][] pairs;
        private DateTime currentDate;

        public SemestralSchedule(DateTime currentDate, DateTime sem1Start, DateTime sem1End, DateTime sem2Start, DateTime sem2End, int currentPeriodNumber)
            : base(currentPeriodNumber)
        {
            this.currentDate = currentDate;
            pairs = new DateTime[2][];
            pairs[0] = new DateTime[] { sem1Start, sem1End };
            pairs[1] = new DateTime[] { sem2Start, sem2End };
        }

        public override int GetDaysRemaining()
        {
            int currentPeriod = GetCurrentPeriodNumber() - 1;
            DateTime periodEnd = pairs[currentPeriod][1];
            TimeSpan timeRemaining = periodEnd - currentDate;
            return timeRemaining.Days;
        }

        public override int GetDaysUntilNextPeriod()
        {
            int currentPeriod = GetCurrentPeriodNumber() - 1;
            int nextPeriod = (currentPeriod + 1) % 2;
            DateTime nextPeriodStart = new DateTime(currentDate.Year + (nextPeriod == 0 ? 0 : 1), pairs[nextPeriod][0].Month, pairs[nextPeriod][0].Day);
            TimeSpan timeUntilNextPeriod = nextPeriodStart - currentDate;
            int daysUntilNextPeriod = timeUntilNextPeriod.Days;

            return daysUntilNextPeriod + 1;
        }
    }
}
