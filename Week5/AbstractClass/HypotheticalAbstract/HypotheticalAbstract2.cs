﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.HypotheticalAbstract
{
    public abstract class HypotheticalAbstract2 : HypotheticalAbstract1
    {
        public HypotheticalAbstract2(int a, int b) : base(a, b)
        {

        }

        public override int GetValue1()
        {
            return a + b;
        }
    }
}
