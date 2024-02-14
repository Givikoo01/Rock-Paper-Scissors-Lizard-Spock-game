using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class GameRules
    {
        public static string Winner(int userMove, int computerMove, int numMoves)
        {
            //logic to determine winner
            int half = numMoves / 2;
            int diff = (computerMove - userMove + numMoves) % numMoves;
            if (diff == 0)
                return "Draw";
            else if (diff <= half)
                return "Computer wins";
            else
                return "User wins";
        }
    }
}
