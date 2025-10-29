using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aiden_TextBasedRPGMap_GameProgramming1
{
    internal class Program
    {



        static Char[,] mapArray = { { '^', '^', '^', '^', '^', '^', '^', '^', '^', '^', '^', '^', '^', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*',},
                                    { '^', '^', '^', '^', '^', '^', '^', '^', '^', '^', '^', '*', '*', '*', '*', '*', '*', '*', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '*', '*', '*',},
                                    { '^', '^', '^', '^', '^', '^', '^', '^', '^', '*', '*', '*', '*', '*', '*', '*', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '*',},
                                    { '^', '^', '^', '^', '^', '-', '-', '-', '-', '-', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '*',},
                                    { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '*', '*', '*', '*',},
                                    { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '*', '*', '*', '*', '*',},
                                    { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '*', '*', '*', '*', '*', '*', '*', '*',},
                                    { '*', '*', '*', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_',},
                                    { '*', '*', '*', '*', '*', '*', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_',},
                                    { '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_',},
        };

        static void DisplayMap(int scale)
        {

            for (int i = 0; i < mapArray.GetLength(0); i++)
            {

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("|");

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

                    for (int l = 0; l < scale; l++)
                    {
                        Console.Write(mapArray[i, j]);
                    }
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("|");

                if (scale > 1)
                {

                    for (int l = 0; l < scale - 1; l++)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("|");

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
                            else if (mapArray[i, j] == '*')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }

                            for (int t = 0; t < scale; t++)
                            {
                                Console.Write(mapArray[i, j]);
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("|");

                    }

                }

                Console.WriteLine();

            }
        }

        static void Main(string[] args)
        {
            DisplayMap(1);
            Console.ReadKey();
            Console.Clear();

            DisplayMap(2);
            Console.ReadKey();
            Console.Clear();

            DisplayMap(3);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
