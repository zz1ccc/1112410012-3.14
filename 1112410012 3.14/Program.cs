using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1112410012_3._14
{
    internal class Program
    {
        //1112410012 鍾承佑
        static double CountPi(int n)
        {
            if (n < 4 || n > 15)
            {
                return -1; // 超出範圍，回傳錯誤值
            }

            double pi = 0.0;
            for (int i = 0; i <= n; i++)
            {
                pi += Math.Pow(-1, i) / (2 * i + 1);
            }
            return 4 * pi;
        }

        // 計算圓週長函式
        static double GetCircumference(double r, double pi)
        {
            return 2 * pi * r;
        }

        // 計算圓面積函式
        static double GetCircleArea(double r, double pi)
        {
            return pi * r * r;
        }

        static void Main()
        // 1112410012 鍾承佑
        {
            // 輸入圓半徑
            Console.Write("請輸入圓的半徑: ");
            if (!double.TryParse(Console.ReadLine(), out double radius) || radius <= 0)
            {
                Console.WriteLine("半徑輸入錯誤，程式結束。");
                return;
            }

            // 輸入圓週率的精度
            Console.Write("請輸入圓週率的精度 (4 <= n <= 15): ");
            if (!int.TryParse(Console.ReadLine(), out int precision))
            {
                Console.WriteLine("精度輸入錯誤，程式結束。");
                return;
            }

            // 計算圓週率
            double pi = CountPi(precision);
            if (pi == -1)
            {
                Console.WriteLine("精度超出範圍 (4 <= n <= 15)，程式結束。");
                return;
            }

            // 印出圓週率
            Console.WriteLine("使用者設定精度: {0}, 計算出的圓週率: {1:g}", precision, pi);

            // 計算並印出圓週長和圓面積
            double circumference = GetCircumference(radius, pi);
            double area = GetCircleArea(radius, pi);
            Console.WriteLine("圓週長: {0:g}", circumference);
            Console.WriteLine("圓面積: {0:g}", area);
            Console.WriteLine();
        }
    }
}
