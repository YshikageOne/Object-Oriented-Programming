using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.Chess
{
    internal class MainChess
    {
        public static void Main()
        {
            Console.Write("Is white (Y - yes, N - no): ");
            bool isWhite = Console.ReadLine()[0] == 'Y';
            Pawn pawn = new Pawn(isWhite);

            Console.Write("Is two moves (Y - yes, N - no): ");
            bool isTwoMoves = Console.ReadLine()[0] == 'Y';

            // NOTE: Uncomment the line below when you want to submit your solution already
            Tester.Test(pawn, isTwoMoves);
        }
    }
}
