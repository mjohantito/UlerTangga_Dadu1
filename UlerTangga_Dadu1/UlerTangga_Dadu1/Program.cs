using System;

namespace UlerTangga_Dadu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int dadu = 1; dadu <= 6; dadu++)
            {
                for (int i = 0; i < 8; i++) // kebawah
                {
                    for (int j = 0; j < 11; j++) // ke kanan
                    {
                        if (dadu == 1)
                        {
                            if (i == 2 || i == 5 || j == 3 || j == 7)
                            {
                                Console.Write(".");
                            }
                            else if (j == 1 || j == 5 || j == 9)
                            {
                                Console.Write(" ");
                            }
                            else if (i > 2 && i < 5 && j > 3 && j < 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("#");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else if (dadu == 2)
                        {
                            if (i == 2 || i == 5 || j == 3 || j == 7)
                            {
                                Console.Write(".");
                            }
                            else if (j == 1 || j == 5 || j == 9)
                            {
                                Console.Write(" ");
                            }
                            else if (i > 2 && i < 5 && j < 3 || i > 2 && i < 5 && j > 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("#");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else if (dadu == 3)
                        {
                            if (i == 2 || i == 5 || j == 3 || j == 7)
                            {
                                Console.Write(".");
                            }
                            else if (j == 1 || j == 5 || j == 9)
                            {
                                Console.Write(" ");
                            }
                            else if (i > 2 && i < 5 && j > 3 && j < 7 || i < 2 && j > 7 || i > 5 && j < 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("#");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else if (dadu == 4)
                        {
                            if (i == 2 || i == 5 || j == 3 || j == 7)
                            {
                                Console.Write(".");
                            }
                            else if (j == 1 || j == 5 || j == 9)
                            {
                                Console.Write(" ");
                            }
                            else if (i < 2 && j < 3 || i < 2 && j > 7 || i > 5 && j < 3 || i > 5 && j > 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("#");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else if (dadu == 5)
                        {
                            if (i == 2 || i == 5 || j == 3 || j == 7)
                            {
                                Console.Write(".");
                            }
                            else if (j == 1 || j == 5 || j == 9)
                            {
                                Console.Write(" ");
                            }
                            else if (i < 2 && j < 3 || i < 2 && j > 7 || i > 5 && j < 3 || i > 5 && j > 7 || i > 2 && i < 5 && j > 3 && j < 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("#");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else if (dadu == 6)
                        {

                            if (i == 2 || i == 5 || j == 3 || j == 7)
                            {
                                Console.Write(".");
                            }
                            else if (j == 1 || j == 5 || j == 9)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("#");
                                Console.ResetColor();
                            }

                        }

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
