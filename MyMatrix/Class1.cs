using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatrix
{
    public class Class1
    {
        protected double[,] Matr;
        public Class1(int rowCount, int colCount)
        {
            Matr = new double[rowCount, colCount];
        }
        public void FillRandomNumbers(int minValue = 0, int maxValue = 0)
        {
            Random rnd = new Random();
            for (int i = 0; i < Matr.GetLength(0); i++)
                for (int j = 0; j < Matr.GetLength(1); j++)
                    Matr[i, j] = rnd.Next(minValue, maxValue);
        }
        public double[,] GetMatrix()
        {
            return ();
        }
    }
}
