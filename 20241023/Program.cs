using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5-1
            //int[] A = new int[10];
            //int[] B = new int[10];
            //Console.WriteLine("請輸入10個數字");
            //for(int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine($"第{i+1}個數為:");
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i=0;i<A.Length; i++)
            //{
            //    if (A[i] > 5)
            //    {
            //        B[i] = A[i] - 5;
            //    }
            //    else
            //    {
            //        B[i] = A[i];
            //    }
            //}
            //string original = "原本的10個數為:";
            //foreach (int a in A)
            //{
            //    original += a.ToString() + ",";
            //}
            //original = original.Substring(0, original.Length - 1);
            //string final = "最終的10個數為:";
            //foreach (int b in B)
            //{
            //    final += b.ToString() + ",";
            //}
            //final = final.Substring(0, final.Length - 1);
            //Console.WriteLine($"{ original }");
            //Console.WriteLine($"{final}");
            //Console.ReadKey();

            //5-2
            //int[] A = new int[10];
            //int[] B = new int[10];
            //Console.WriteLine("請輸入10個數字");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine($"第{i + 1}個數為:");
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < A.Length; i++)
            //{
            //        B[i] = A[i]-i-1;
            //}
            //string original = "原本的10個數為:";
            //foreach (int a in A)
            //{
            //    original += a.ToString() + ",";
            //}
            //original = original.Substring(0, original.Length - 1);
            //string final = "最終的10個數為:";
            //foreach (int b in B)
            //{
            //    final += b.ToString() + ",";
            //}
            //final = final.Substring(0, final.Length - 1);
            //Console.WriteLine($"{original}");
            //Console.WriteLine($"{final}");
            //Console.ReadKey();

            ////5 - 1
            //int[] A = new int[10];
            //int[] B = new int[10];
            //Console.WriteLine("請輸入10個數字");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine($"第{i + 1}個數為:");
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] >=0)
            //    {
            //        B[i] = 0;
            //    }
            //    else
            //    {
            //        B[i] = 1;
            //    }
            //}
            //string original = "原本的10個數為:";
            //foreach (int a in A)
            //{
            //    original += a.ToString() + ",";
            //}
            //original = original.Substring(0, original.Length - 1);
            //string final = "最終的10個數為:";
            //foreach (int b in B)
            //{
            //    final += b.ToString() + ",";
            //}
            //final = final.Substring(0, final.Length - 1);
            //Console.WriteLine($"{original}");
            //Console.WriteLine($"{final}");
            //Console.ReadKey();

            ////5-4
            //int[,] A = new int[3,5];
            //for(int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {

            //            Console.WriteLine($"請輸入[{i},{j}]的值;");
            //            A[i, j] = Convert.ToInt32(Console.ReadLine());


            //    }
            //}
            //Console.WriteLine("二維陣列 A 的內容:");
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0;  j< A.GetLength(1); j++)
            //    {
            //        Console.Write(A[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("\n每一行的和:");
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    int rowSum = 0;
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        rowSum += A[i, j];
            //    }
            //    Console.WriteLine($"第 {i + 1} 行的和: {rowSum}");
            //}

            //Console.WriteLine("\n每一列的和:");
            //for (int j = 0; j < A.GetLength(1); j++)
            //{
            //    int colSum = 0;
            //    for (int i = 0; i < A.GetLength(0); i++)
            //    {
            //        colSum += A[i, j];
            //    }
            //    Console.WriteLine($"第 {j + 1} 列的和: {colSum}");
            //}
            //Console.ReadKey();
            ////5-5
            //int[,] A = new int[3, 5];
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {

            //        Console.WriteLine($"請輸入[{i},{j}]的值;");
            //        A[i, j] = Convert.ToInt32(Console.ReadLine());


            //    }
            //}
            //Console.WriteLine("二維陣列 A 的內容:");
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        Console.Write(A[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("\n每一行的和:");
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    int rowMin =  A[i, 0];
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if (A[i, j]< rowMin)
            //        {
            //            rowMin = A[i, j];
            //        }
            //    }
            //    Console.WriteLine($"第 {i + 1} 行的最小值: {rowMin}");
            //}

            //Console.WriteLine("\n每一列的和:");
            //for (int j = 0; j < A.GetLength(1); j++)
            //{
            //    int colMin = A[0,j];
            //    for (int i = 0; i < A.GetLength(0); i++)
            //    {
            //        if (A[i, j] < colMin)
            //        {
            //            colMin = A[i, j];
            //        }
            //    }
            //    Console.WriteLine($"第 {j + 1} 列的和: {colMin}");
            //}
            //Console.ReadKey();

            ////5-6
            //int[] A = new int[5];
            //int[] B = new int[5];
            //int[] C = new int[5];
            //Console.WriteLine("請輸入5個數字");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine($"A{i + 1}為:");
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < B.Length; i++)
            //{
            //    Console.WriteLine($"B{i + 1}為:");
            //    B[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < C.Length; i++)
            //{
            //    C[i] = A[i] + B[i];
            //    Console.WriteLine($"C{i+1}:{C[i]}");
            //}

            //Console.ReadKey();
            //5-7
            int[] A = new int[5];
            int[] B = new int[5];
            int[] C = new int[5];
            int x, y;
            Console.WriteLine("請輸入5個數字");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"A{i + 1}為:");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine($"B{i + 1}為:");
                B[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(A);
            Array.Sort(B);
            x = A[4];
            y = B[0];
            if (x > y)
            {
                Console.WriteLine("x比y大");
            }
            else if (x<y)
            {
                Console.WriteLine("x比y小");
            }
            else
            {
                Console.WriteLine("x.y相等");
            }
            Console.ReadKey();
        }
    }
}
