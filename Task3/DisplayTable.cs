using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class DisplayTable
    {
        //Displaying the table
        public DisplayTable(string[] moves)
        {
            for (int i = 0; i < moves.Length; i++)
            {
                Console.WriteLine($"{i+1} - {moves[i]}");
            }
            Console.WriteLine("0 - exit \n? - help");
        }
    }
}
