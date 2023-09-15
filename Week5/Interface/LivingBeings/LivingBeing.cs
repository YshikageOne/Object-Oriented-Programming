using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.LivingBeings
{
    public interface LivingBeing
    {
        void Eat();
        void Grow();
        void Grow(int n);
    }
}
