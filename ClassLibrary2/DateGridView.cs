using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMatrix
{
    public class DateGridViewVisualizer
    {
        protected DateGridView DateGrid;
        public DateGridViewVisualizer(DateGridView dateGrid);
        {
        DateGrid=dateGrid;
        }
    public void Initialize(int rowCount, int colCount)
    {
        dateGrid.RowCount = rowCount;
        dateGrid.ColumnCount = colCount;
        for (int i = 0; i < dateGrid.ColumnCount; i++)
            dateGrid.Columns[i].Width = 80;
    }
    public static void NumerateRowsAndCols()
    {
        for (int i = 0; i < dateGrid.ColumnCount; i++)
            dateGrid.columns[i].HeaderText = i.ToString();
        for (int i = 0; i < dateGrid.RownCount; i++)
            dateGrid.Rows[i].headerCell = i.ToString();
        DateGrid.RowHeaderWidth = 80;
    }
    public void Fill(Class1 class1)
    {
        double[,] matr = class1.GetMatrix();
        Initialize(matr.GetLength(0), matr.GetLength(1));
        NumerateRowsAndCols();
        for (int i = 0; i < matr.GetLength(0); i++)
            for (int j = 0; j < matr.GetLength(1); j++)
                DateGrid[j, i].Value = matr[i, j];

    }
    public void UpdateMatrix(Class1 class1)
    {
        double[,] matr = class1.GetMatrix();
        for (int i = 0; i < matr.GetLength(0); i++)
            for (int j = 0; j < matr.GetLength(1); j++)
                matr[i, j] = int.Parse(DateGrid[j, i].Value.ToString());
    }
    public double[,] GetMatrix()
        {
        return ClassMatrix;
        }
    }
}
