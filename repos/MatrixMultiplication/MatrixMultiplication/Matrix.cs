using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    class Matrix
    {
        private static Random myRnd = new Random(Environment.TickCount);
        public int[,] MyMatrix (int height, int lenth)
        {
            int[,] FullMatrix = new int[height, lenth];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < lenth; j++)
                {
                    FullMatrix[i, j] = myRnd.Next(0, 10);
                }
            }
            return FullMatrix;
        }

        public int MultMatrixElem (int[,] matrix1, int[,] matrix2, int i, int j, int lenth1)
        {
            int mme = 0;
            for (int k = 0; k < lenth1; k++)
            {
                mme += matrix1[i, k] * matrix2[k, j];
            }

            return mme;
        }

        public void MatrixOut (int[,] matrix)
        {
            int height = matrix.GetUpperBound(0) + 1;
            int lenth = matrix.GetUpperBound(1) + 1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < lenth; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                 Console.Write("\n");
            }
        }

        
        public int[,] MutrixMult (int[,] matrix1, int[,] matrix2)
        {
            int height1 = matrix1.GetUpperBound(0) + 1;
            int lenth1 = matrix1.GetUpperBound(1) + 1;
            int height2 = matrix2.GetUpperBound(0) + 1;
            int lenth2 = matrix2.GetUpperBound(1) + 1;
           
            Matrix ResultMatrix = new Matrix();
            int[,] MultiplicationResult = new int[height1, lenth2];
            for (int i = 0; i < height1; i++)
            {
             for (int j = 0; j < lenth2; j++)
             {
                MultiplicationResult[i, j] = ResultMatrix.MultMatrixElem(matrix1, matrix2, i, j, lenth1);
             }
            }

            return MultiplicationResult;
        }
        //блок для массивов в массивах
        public int [][] SecondMytrixTye (int height, int lenth)
        {
            int[][] secMatr = new int[height][];

            for (int i = 0; i < height; i++)
            {
                secMatr[i] = new int[lenth];
                for (int j = 0; j < lenth; j++)
                {
                    secMatr[i][j] = myRnd.Next(0, 10);
                }
            }

            return secMatr;
        }
        public int MultMatrixElemNew(int[][] matrix1, int[][] matrix2, int i, int j, int lenth1)
        {
            int mme = 0;
            for (int k = 0; k < lenth1; k++)
            {
                mme += matrix1[i][k] * matrix2[k][j];
            }

            return mme;
        }
        public void MatrixOutNew(int[][] matrix)
        {
            int height = matrix.Length;
            int lenth = matrix[0].Length;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < lenth; j++)
                {
                    Console.Write($"{matrix[i][j]} \t");
                }
                Console.Write("\n");
            }
        }
        public int[][] MutrixMultNew(int[][] matrix1, int[][] matrix2)
        {
            int height1 = matrix1.Length;
            int lenth1 = matrix1[0].Length;
            int height2 = matrix2.Length;
            int lenth2 = matrix2[0].Length;

            Matrix ResultMatrix = new Matrix();
            int[][] MultiplicationResult = new int[height1][];//
            for (int i = 0; i < height1; i++)
            {
                MultiplicationResult[i] = new int[lenth2];
                for (int j = 0; j < lenth2; j++)
                {
                    MultiplicationResult[i][j] = ResultMatrix.MultMatrixElemNew(matrix1, matrix2, i, j, lenth1);
                }
            }

            return MultiplicationResult;
        }
    }
}
