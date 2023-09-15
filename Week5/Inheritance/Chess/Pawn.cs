using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.Chess
{
    public class Pawn : ChessPiece
    {
        private bool hasMoved;

        public Pawn(bool isWhite) : base("Pawn", isWhite)
        {
            hasMoved = false;
        }

        public void Move(bool isTwoMoves)
        {
            if (isTwoMoves == false)
            {
                String color = GetIsWhite() ? "White" : "Black";
                Console.WriteLine($"{color} pawn has moved one step");
                hasMoved = true;
            }
            else
            {
                if (hasMoved == true)
                {

                }
                else
                {
                    String color = GetIsWhite() ? "White" : "Black";
                    Console.WriteLine($"{color} pawn has moved two steps");
                    hasMoved = true;
                }
            }
        }

        public override string ToString()
        {
            String color = GetIsWhite() ? "White" : "Black";
            String moved = hasMoved ? "already moved" : "not yet moved";
            return $"{color} pawn has {moved}";
        }
    }
}
