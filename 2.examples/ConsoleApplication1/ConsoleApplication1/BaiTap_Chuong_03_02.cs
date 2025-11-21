using System;

namespace ConsoleApplication1
{
    internal class BaiTap_Chuong_03_02
    {
        public static void Run()
        {
            // Enter data from keyboard
            // do ..while

            var month = -1;
            // do .. while for input (valid)
            do
            {
                Console.Write("Please enter month (number 1..12): ");
                var text = Console.ReadLine();
                month = Convert.ToInt32(text);
            } while (month < 1 || month > 12);


            string season;
            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    season = "Spring";
                    break;
                case 4:
                case 5:
                case 6:
                    season = "Summer";
                    break;
                case 7:
                case 8:
                case 9:
                    season = "Autumn";
                    break;

                case 10:
                case 11:
                case 12:
                    season = "Winter";
                    break;
                default:
                    season = "Invalid month";
                    break;
            }

            Console.WriteLine("Season: " + season);

        }
    }

}
