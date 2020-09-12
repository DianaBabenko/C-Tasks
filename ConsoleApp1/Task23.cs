using System;

namespace ConsoleApp1
{
    public class Task23
    {
        public void Main23()
        {
            double a = 8;
            double b = 4;
            double c = 7;
            if ((a < b + c) || (b < a + c) || (c < a + b)) {
                double per = (a + b + c) / 2;
                double ha = Math.Sqrt(per * (per - a) * (per - b) * (per - c)) * 2 / a;
                double hb = Math.Sqrt(per * (per - a) * (per - b) * (per - c)) * 2 / b;
                double hc = Math.Sqrt(per * (per - a) * (per - b) * (per - c)) * 2 / c;
                Console.WriteLine("Довжина висот ha = " + Math.Round(ha) + " hb = " + Math.Round(hb) + " hc = " + Math.Round(hc));
            }

            double ma = 2 * (Math.Sqrt((Math.Sqrt(b) + Math.Sqrt(c)) - Math.Sqrt(c)));
            double mb = 2 * (Math.Sqrt((Math.Sqrt(c) + Math.Sqrt(c)) - Math.Sqrt(b)));
            double mc = 2 * (Math.Sqrt((Math.Sqrt(c) + Math.Sqrt(b)) - Math.Sqrt(c)));
            Console.WriteLine("Довжина медіан ma = " + Math.Round(ma) + " mb = " + Math.Round(mb) + " mc = " + Math.Round(mc));


            double la = Math.Sqrt(a * b * (a + b + c) * (a + b - c)) / (a + b);
            double lb = Math.Sqrt(a * c * (a + b + c) * (a + b + c)) / (a + c);
            double lc = Math.Sqrt(c * b * (a + b + c) * (a + b - c)) / (c + b);
            Console.WriteLine("Довжина бісектрис la = " + Math.Round(la) + "lb = " + Math.Round(lb) + "lc = " + Math.Round(lc));


            double p = a + b + c / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double rv = a * b * c / (4 * s);
            double ro = s / p;
            Console.WriteLine("Радіус вписаної окружності rv = " + Math.Round(rv) + " радіус описаної окружності ro = " + Math.Round(ro));
        }
    }
}