using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class AdjMatrix
    {
        public int n;
        public int[,] a;

        public int N { get => n;set=>n = value; }
        public int[,] A{  get => a; set => a = value;}

        public AdjMatrix() { }
        public AdjMatrix(int k)
        {
            n = k;
            a=new int[n,n];
        }
        public void FileToAdjMatrix(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            n = int.Parse(sr.ReadLine());
            a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] s = sr.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    a[i, j] = int.Parse(s[j]);
            }
            sr.Close();
        }
        public void Output()
        {
            Console.WriteLine("Đồ thị ma trận kề - số đỉnh : " + n);
            Console.WriteLine();
            Console.Write(" Đỉnh |");
            for (int i = 0; i < n; i++) Console.Write("    {0}", i);
            Console.WriteLine(); Console.WriteLine("  " + new string('-', 6 * n));
            for (int i = 0; i < n; i++)
            {
                Console.Write("    {0} |", i);
                for (int j = 0; j < n; j++)
                    Console.Write("  {0, 3}", a[i, j]);
                Console.WriteLine();
            }
        }
        public int DegVi(int i)
        {
            int dem = 0;
            for (int j = 0; j < n; j++)
            {
                if (A[i, j] == 1)
                {
                    dem++;
                }
            }
            return dem;
        }
        public void DegVs(string filePath)
        {
            StreamWriter sw = new StreamWriter(filePath);
            for (int i = 0; i < n; i++)
            {
                int deg = DegVi(i);
                sw.WriteLine("Bật của các đỉnh:");
                sw.WriteLine("{0} : {1}", i, deg);
                Console.WriteLine("Bật của các đỉnh:");
                Console.WriteLine("{0} : {1}", i, deg);
            }
            sw.Close();
        }
        public int DegOut(int i)
        {
            int dem= 0;
            for (int j = 0; j < n; j++)
            {
                if (A[i, j] == 1)
                {
                    dem++;
                }
            }
            return dem;
        }
        public int DegIn(int j)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] == 1)
                {
                    dem++;
                }
            }
            return dem;
        }
        public void DegInOut(string filePath)
        {
            StreamWriter sw = new StreamWriter(filePath);
            for (int i = 0; i < n; i++)
            {
                int degOut = DegOut(i);
                int degIn = DegIn(i);
                sw.WriteLine("Bật vào - Bật ra");
                sw.WriteLine("{0} : {1} - {2}", i,degIn , degOut);
                Console.WriteLine("Bật vào - Bật ra");
                Console.WriteLine("{0} : {1} - {2}", i, degIn, degOut);
            }
            sw.Close();
        }
    }
}
