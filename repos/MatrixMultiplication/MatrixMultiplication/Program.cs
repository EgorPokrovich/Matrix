using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
           
            int height1, lenth1, height2, lenth2;
            height1 = lenth1 = height2 = lenth2 = 0; 

            try
            {
                height1 = Convert.ToInt32(args[0]);
                lenth1 = Convert.ToInt32(args[1]);
                height2 = Convert.ToInt32(args[2]);
                lenth2 = Convert.ToInt32(args[3]);
            }
            catch
            {
                Console.WriteLine("Не заданы параметры матрицы, запустите программу с 4-мя числовыми параметрами");
            }

            Matrix FirstMatrix = new Matrix();

            if (height1 != 0)
            {
                int[,] fm = FirstMatrix.MyMatrix(height1, lenth1);
                int[,] sm = FirstMatrix.MyMatrix(height2, lenth2);

                if (fm.GetUpperBound(1) + 1 == sm.GetUpperBound(0) + 1)
                {
                    sw.Start();                    
                    int[,] res = FirstMatrix.MutrixMult(fm, sm);
                    sw.Stop();
                    long duration = sw.ElapsedMilliseconds;
                    Console.WriteLine($"Вычисление умножения прямоугольных матриц заняли: {duration}");
                    Console.WriteLine();

                    
                        int[][] MultiMatr1 = FirstMatrix.SecondMytrixTye(height1, lenth1);
                        //FirstMatrix.MatrixOutNew(MultiMatr1);
                        int[][] MultiMatr2 = FirstMatrix.SecondMytrixTye(height2, lenth2);
                        // FirstMatrix.MatrixOutNew(MultiMatr2);
                        sw.Reset();
                        sw.Start();
                        int[][] resNew = FirstMatrix.MutrixMultNew(MultiMatr1, MultiMatr2);
                        sw.Stop();
                        long duration2 = sw.ElapsedMilliseconds;
                        Console.WriteLine($"Вычисление умножения вложенных матриц заняли: {duration2}");
                    
                }
                else
                {
                    Console.WriteLine("Ошибка при перемножении матриц!");
                }
            }       
            Console.ReadLine();
        }
    }
}
