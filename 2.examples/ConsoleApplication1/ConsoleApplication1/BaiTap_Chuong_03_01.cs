using System;

namespace ConsoleApplication1
{
    internal class BaiTap_Chuong_03_01
    {
        public static void Run()
        {

            Console.Write("Please enter score: ");
            var text = Console.ReadLine();
            var dtb = Convert.ToDouble(text);
            // Điểm của học sinh: Float
            string xep_loai;


            if (dtb >= 9)
            {
                xep_loai = "XUẤT SẮC";
            }
            else if (dtb >= 8)
            {
                xep_loai = "GIỎI";
            }
            else if (dtb >= 6.5)
            {
                xep_loai = "KHÁ";
            }
            else if (dtb >= 5)
            {
                xep_loai = "TRUNG BÌNH";
            }
            else
            {
                xep_loai = "YẾU";
            }

            Console.WriteLine("Xếp loại: Danh hiệu học sinh " + xep_loai);
        }
    }
}
