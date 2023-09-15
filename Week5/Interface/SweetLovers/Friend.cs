using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.SweetLovers
{
    public interface Lover
    {
        void SetLover(Lover lover);
        void ReceiveLove();
        void GiveLove();
    }

    public interface BoyFriend
    {
        void GiveFlowers(int flowerCount);
    }

    public interface GirlFriend
    {
        void ReceiveFlowers(int flowerCount);
    }

    public abstract class Friend : Lover
    {
        private char gender;
        private bool isLoved = false;

        public Friend(char gender)
        {
            this.gender = gender;
        }

        public abstract void SetLover(Lover lover);

        public void ReceiveLove()
        {
            isLoved = true;
        }

        public abstract void GiveLove();

        public override string ToString()
        {
            return $"{gender} - {isLoved}";
        }
    }

    public class MaleFriend : Friend, BoyFriend
    {
        private int flowersGiven = 0;
        private FemaleFriend lover = null;

        public MaleFriend() : base('M')
        {
        }

        public override void SetLover(Lover lover)
        {
            if (lover is FemaleFriend)
            {
                this.lover = (FemaleFriend)lover;
            }
        }

        public override void GiveLove()
        {
            Console.WriteLine("mwamwa");
            ReceiveLove();
        }

        public void GiveFlowers(int flowerCount)
        {
            flowersGiven += flowerCount;
            lover.ReceiveFlowers(flowerCount);
        }
    }

    public class FemaleFriend : Friend, GirlFriend
    {
        private int flowersReceived = 0;
        private MaleFriend lover = null;

        public FemaleFriend() : base('F')
        {
        }

        public override void SetLover(Lover lover)
        {
            if (lover is MaleFriend)
            {
                this.lover = (MaleFriend)lover;
            }
        }

        public override void GiveLove()
        {
            Console.WriteLine("tsuptsup");
            ReceiveLove();
        }

        public void ReceiveFlowers(int flowerCount)
        {
            flowersReceived += flowerCount;
        }
    }

}
