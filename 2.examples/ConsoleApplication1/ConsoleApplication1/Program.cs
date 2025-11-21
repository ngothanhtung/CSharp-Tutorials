using System;

namespace ConsoleApplication1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            
            var s1 = new Student();
            s1.Id = 1;
            s1.Score = 10;
            s1.LoadFromTextFile();
            s1.Display();
            
            s1.Score.to
            
          
           
            //
            // var s2 = new Student();
            // s2.Id = 2;
            // s2.Name = "Jane Smith";
            // s2.Email = "janesmith@gmail.com";
            // s2.Address = "456 Oak St, Othertown, USA";
            // s2.Age = 19;
            // s2.Score = 9;
            // s2.SaveToTextFile();
            //
            // s2.Display();

            var ps1 = new PhanSo();
            ps1.TuSo = 3;
            ps1.MauSo = 4;
            
            ps1.HienThi();
            
            var ps2 = new PhanSo();
            ps2.TuSo = 1;
            ps2.MauSo = 4;
            
            ps2.HienThi();

            var ps = ps1.Cong(ps2);
            ps.HienThi();

            PhanSo psrg = ps.RutGon();
            psrg.HienThi();
        }
    }
}