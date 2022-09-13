// Programmer: David Flannery
// Date: 9/13/2022
// Description: delivary 3


using System; 

namespace delivary_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value between 0 and 100");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Specify integer numbers (odd or even):"); 
            string y = Console.ReadLine();

            Console.WriteLine("Integer input:" + x);
            Console.WriteLine("String Input:" + y);
            Console.WriteLine("Output:");
            Console.WriteLine(" You have selected the "  +y+  " series. The numbers between 0 and "  +x+  " are:"); 

            try  // Try catch statemen
            {


                if ((x > 100) && (x < 0))
                {
                    Console.WriteLine(" please choose an integer between 0 and 100");
                }
                else if (y == "even")
                {
                    for (int i = 0; i < x; i++) // for loop for the even ser
                    {
                        int even = 2 * i;
                        if (even > x)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(even.ToString());
                        }
                    }
                }
                else if (y == "odd")
                {
                    for (int i = 1; i < x; i++) // for loop for odd set 
                    {
                        int odd = 2 * i - 1;
                        if (odd > x)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(odd.ToString());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not valid integer represenation. Try again");
                }
            }
            catch
            {
                Console.WriteLine("enter an integer between 0 and 100");
                Console.WriteLine("Press any button to close out of program");
                Console.ReadKey(true); 

            }



        }
    }
}
