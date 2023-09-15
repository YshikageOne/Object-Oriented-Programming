using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.Chess
{
    public class ChessPiece
    {
        private string kind;
        private bool isWhite;

        public ChessPiece(string kind, bool isWhite)
        {
            this.kind = kind;
            this.isWhite = isWhite;
        }

        public string GetKind() { return kind; }
        public bool GetIsWhite() { return isWhite; }
    }
}
