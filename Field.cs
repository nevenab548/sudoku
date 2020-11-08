using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sudoku
{
    class Field
    {
        private int[, ] matrix;
        public int[,] Matrixp { get { return matrix; } set { matrix = value; } }
        public Field()
        {
            StreamReader sr = new StreamReader("field.txt");
            matrix = new int[9, 9];
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    matrix[i, j] = Int32.Parse(sr.ReadLine());
            sr.Close();
        }
    }
}
