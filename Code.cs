using System.ComponentModel.Design;
using System.Threading;

namespace Task6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int count = 5, floor;
            int a = 0, b;
            Console.WriteLine("Please enter a floor(0-5)");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Please enter a floor no: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                floor = Convert.ToInt32(Console.ReadLine());
                if (floor > 5 || floor < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Please enter floor number between 0 to 5");
                }
                else
                {
                    if (a == floor)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You are in same floor");
                    }
                    else if (a < floor)
                    {
                        a++;
                        while (a <= floor)
                        {
                            if (a != floor)
                            {
                                Console.WriteLine();
                                Thread.Sleep(5000);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("You have arrived floor " + a);
                                Thread.Sleep(2600);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Crossed from floor " + a);
                            }
                            else
                            {
                                Console.WriteLine();
                                Thread.Sleep(5000);
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("You have arrived floor " + a);

                            }
                            Thread.Sleep(8000);
                            a++;
                        }
                        a--;
                    }
                    else
                    {
                        a--;
                        while (a >= floor)
                        {
                            if (a == 0)
                            {
                                Console.WriteLine();
                                Thread.Sleep(5000);
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("You have arrived to Ground floor");
                            }
                            else if (a != floor)
                            {
                                Console.WriteLine();
                                Thread.Sleep(5000);
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("You have arrived floor " + a);
                                Thread.Sleep(2600);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Crossed from floor " + a);
                            }
                            else
                            {
                                Console.WriteLine();
                                Thread.Sleep(5000);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("You have arrived floor " + a);
                                Thread.Sleep(2600);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Crossed from floor " + a);
                            }
                            Thread.Sleep(8000);
                            a--;
                        }
                        a++;
                    }
                }
                if (a == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are in Ground floor");
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("you are in floor " + a);
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Do you want to continue[0/1]: ");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 0)
                {
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
