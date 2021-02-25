using System;

namespace _63120501018Siripatsaya
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1, p2, p3, p4, p5, p6;
            string Agency;

            Console.Write("Please input the first code  : ");
            p1 = int.Parse(Console.ReadLine());
            Console.Write("Please input the second code : ");
            p2 = int.Parse(Console.ReadLine());
            Console.Write("Please input the third code  : ");
            p3 = int.Parse(Console.ReadLine());
            Console.Write("Please input the fourth code : ");
            p4 = int.Parse(Console.ReadLine());
            Console.Write("Please input the fifth code  : ");
            p5 = int.Parse(Console.ReadLine());
            Console.Write("Please input the sixth code  : ");
            p6 = int.Parse(Console.ReadLine());
            Console.Write("Please input the agency : ");
            Agency = Console.ReadLine();

            if (Agency == "CIA")
            {
                if (p6 % 3 == 0)
                {
                    if (p5 != 1 && p5 != 3 && p5 != 5)
                    {
                        if (p3 >= 6 && p3 != 8)
                        {
                            Console.WriteLine(true);
                        }
                        else
                            Console.WriteLine(false);
                    }
                    else
                        Console.WriteLine(false);
                }
                else
                    Console.WriteLine(false);
            }

            else if (Agency == "FBI")
            {
                if (p4 % 2 == 0 && p4 != 6)
                {
                    if (p2 % 3 == 0)
                    {
                        if (p1 <= 7 && p1 >= 4)
                        {
                            Console.WriteLine(true);
                        }
                        else
                            Console.WriteLine(false);
                    }
                    else
                        Console.WriteLine(false);
                }
                else
                    Console.WriteLine(false);
            }

            else if (Agency == "NSA")
            {
                if (p6 == 1 || p6 == 2 || p6 == 3 || p6 == 5 || p6 == 6)
                {
                    if (p4 % 3 == 0 && p4 % 2 != 0)
                    {
                        if (p1 == 7 || p2 == 7 || p3 == 7 || p4 == 7 || p5 == 7 || p6 == 7)
                        {
                            Console.WriteLine(true);
                        }
                        else
                            Console.WriteLine(false);
                    }
                    else
                        Console.WriteLine(false);
                }
                else
                    Console.WriteLine(false);
            }

            else
            {
                Console.WriteLine("Password is incorrect.");
            }
            Console.ReadLine();
        }
    }
}
