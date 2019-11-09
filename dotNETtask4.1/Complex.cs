using System;

namespace dotNETtask4._1
{
    class Complex
    {
        private readonly double epsilon = 1e-4;
        public double Re { get; set; }
        public double Im { get; set; }
        public double Phi { get; set; }
        public double R { get; set; }

        public Complex(double re = 0, double im = 0)
        {
            Re = re;
            Im = im;
        }

        public override string ToString()
        {
            string res = "";
            if (Math.Abs(Re) < epsilon && Math.Abs(Im) < epsilon)
            {
                res = "0";
            } else if (Math.Abs(Re) < epsilon)
            {
                if (Im < 0)
                    res = (Math.Abs(Im) - 1 < epsilon) ? $"-i" : $"{Math.Abs(Im):0.##}i";
                else
                    res = (Math.Abs(Im) - 1 < epsilon) ? $"i" : $"{Im:0.##}i";
            } else if (Math.Abs(Im) < epsilon)
            {
                if (Re < 0)
                    res += "-";
                res += $"{Math.Abs(Re):0.##}";
            }
            else
            {
                res += $"{Re:0.##} ";
                if (Im < 0)
                    res += (Math.Abs(Im) - 1 < epsilon) ? $"- i" : $"- {Math.Abs(Im):0.##}i";
                else
                    res += (Math.Abs(Im) - 1 < epsilon) ? $"+ i" : $"+ {Im:0.##}i";
            }

            return res;
        }

        public double Abs
        {
            get { return Math.Sqrt(Re * Re + Im * Im); }
        }
    }
}
