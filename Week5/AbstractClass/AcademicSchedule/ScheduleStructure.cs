using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.AcademicSchedule
{
    public abstract class ScheduleStructure
    {
        private int currentPeriodNumber;

        public ScheduleStructure(int currentPeriodNumber)
        {
            this.currentPeriodNumber = currentPeriodNumber;
        }

        public int GetCurrentPeriodNumber()
        {
            return currentPeriodNumber;
        }

        public abstract int GetDaysRemaining();
        public abstract int GetDaysUntilNextPeriod();
    }
}
