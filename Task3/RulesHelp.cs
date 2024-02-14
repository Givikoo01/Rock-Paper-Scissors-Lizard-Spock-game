using ConsoleTable;
using System.ComponentModel.DataAnnotations;

namespace Task3
{
    public class RulesHelp
    {

        //Displaying help table
        public static void ShowRulesTable(string[] moves)
        {
            var table = new Table();
            table.AddColumn("PC/USER >");
            table.AddColumn(moves);
            if (moves.Length > 0)
            {
                for (int i = 0; i < moves.Length; i++)
                {
                    List<string> movesForTable = new List<string>();
                    movesForTable.Add(moves[i]);
                    for (int j = 0; j < moves.Length; j++)
                    {
                        movesForTable.Add(GameRules.Winner(i+1, j+1, moves.Length));
                    }

                    table.AddRow(movesForTable.ToArray());
                }
            }
            Console.WriteLine(table);
        }
        }
    }
