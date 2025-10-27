using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aiden_TextBasedRPGMap_GameProgramming1
{
    internal class Program
    {



        static Char[,] mapArray = { { '^', '^', '^', '^', '^', '^', '^', '^', '^', '^', '^', '^', '^', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*',},
                                    { '^', '^', '^', '^', '^', '^', '^', '^', '^', '^', '^', '*', '*', '*', '*', '*', '*', '*', '~', '~', '~', '~', '~', '~',},
                                    { '^', '^', '^', '^', '^', '^', '^', '^', '^', '*', '*', '*', '*', '*', '*', '*', '~', '~', '~', '~', '~', '~', '~', '~',},
                                    { '^', '^', '^', '^', '^', '-', '-', '-', '-', '-', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~',},
                                    { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~',},
                                    { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '~', '~', '~', '~', '~', '~', '~',},
                                    { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-',},
                                    { '*', '*', '*', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_',},
                                    { '*', '*', '*', '*', '*', '*', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_',},
                                    { '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_',},
        };

        static void DisplayMap()
        {
            for (int i = 0; i < mapArray.GetLength(0); i++)
            {
                for (int j = 0; j < mapArray.GetLength(1); j++)
                {
                    if (mapArray[i, j] == '-')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else if (mapArray[i, j] == '~')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else if (mapArray[i, j] == '^')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else if (mapArray[i,j] == '*')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                        Console.Write(mapArray[i, j]);
                }
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine();

            }
        }

        static void Main(string[] args)
        {
            DisplayMap();
        }
    }
}
