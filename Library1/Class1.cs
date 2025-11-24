//вариант 9
//средний уровень

using System.Diagnostics.CodeAnalysis;

namespace Library1
{
    public class Lib
    {
        public static double[] Vector(double[,] mas)
        {
            double sum = 0;
            double[] diagonal = new double[7];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i + j == 7 - 1) { diagonal[i] = mas[i, j]; }
                    sum += mas[i, j];
                }
            }
            for (int i = 0; i < diagonal.Length; i++)
            {
                diagonal[i] *= sum;
            }
            return diagonal;
        }

        public static double G(double[] mas)
        {
            double realResult = 0;
            for(int i = 1; i < 7; i++)
            {
                double result = 1;
                for (int j = 1; j < i; j++)
                {
                    result *= mas[j] / Math.E;
                }
                realResult += Math.Pow(mas[i], 2) - result;
            }
            return Math.Sqrt(Math.Abs(realResult));
        }
    }
}
