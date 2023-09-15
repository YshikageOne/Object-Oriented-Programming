using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.BasicUnitOfSociety
{
    public abstract class FamilyMember
    {
        private String type;

        public FamilyMember(String type)
        {
            this.type = type;
        }

        public abstract void Greet();

        public override String ToString()
        {
            return $"Family Member [{type}]";
        }
    }

}
