using System;

namespace ConsoleApplication1
{
    internal class BaiTap_Chuong_03_03_02
    {
        public static void Run()
        {


            int count = 0;

            int i = 0;

            while (count <= 10)
            {
                if (i % 5 == 0)
                {
                    count++;
                    Console.Write(i + ", ");
                }

                i++;
            }
        }
    }

}
