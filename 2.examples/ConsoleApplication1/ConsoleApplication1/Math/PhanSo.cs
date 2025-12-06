namespace ConsoleApplication1.Math
{
    public class PhanSo
    {
        private int _TuSo;
        public int TuSo
        {
            set { this._TuSo = value; }
            get { return this._TuSo; }
        }

        private int _MauSo;
        public int MauSo
        {
            set
            {
                if (value == 0)
                {
                    throw new System.ArgumentException("Mau so khong duoc bang 0.");
                }
                this._MauSo = value;
            }
            get { return this._MauSo; }
        }

        public void HienThi()
        {
            System.Console.WriteLine($"{this._TuSo} / {this._MauSo}");
        }

        /// <summary>
        /// Cộng hai phân số
        /// </summary>
        /// <param name="ps">Phân số cộng vào</param>
        /// <returns>Phân số</returns>
        public PhanSo Cong(PhanSo ps)
        {
            PhanSo result = new PhanSo();
            result.TuSo = this.TuSo * ps.MauSo + ps.TuSo * this.MauSo;
            result.MauSo = this.MauSo * ps.MauSo;
            return result;
        }

        public PhanSo Tru(PhanSo ps)
        {
            PhanSo result = new PhanSo();
            result.TuSo = this.TuSo * ps.MauSo - ps.TuSo * this.MauSo;
            result.MauSo = this.MauSo * ps.MauSo;
            return result;
        }

        public PhanSo Nhan(PhanSo ps)
        {
            PhanSo result = new PhanSo();
            result.TuSo = this.TuSo * ps.TuSo;
            result.MauSo = this.MauSo * ps.MauSo;
            return result;
        }

        public PhanSo Chia(PhanSo ps)
        {
            PhanSo result = new PhanSo();
            result.TuSo = this.TuSo * ps.MauSo;
            result.MauSo = this.MauSo * ps.TuSo;
            return result;
        }

        public PhanSo RutGon()
        {
            int a = this.TuSo;
            int b = this.MauSo;
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            int gcd = a;

            PhanSo result = new PhanSo();
            result.TuSo = this.TuSo / gcd;
            result.MauSo = this.MauSo / gcd;
            return result;
        }
    }
}