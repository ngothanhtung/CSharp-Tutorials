using System;

namespace ConsoleApplication1
{
    internal class BaiTap_Chuong_03_03_01
    {
        public static void Run()
        {
            // Enter data from keyboard
            var n = 0;
            // do .. while for input (valid)
            do
            {
                Console.Write("Please enter a number: ");
                var text = Console.ReadLine();
                n = Convert.ToInt32(text);
            } while (n < 0);


            Console.WriteLine("Numbers mod 3 = 0");

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i);
                    Console.Write(", ");
                }
            }
        }
    }

}
