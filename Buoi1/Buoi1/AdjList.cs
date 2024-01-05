using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class AdjList
    {
        LinkedList<int>[] v;
        int n; 
        public int N { get => n; set => n = value; }
        public LinkedList<int>[] V
        {
            get { return v; }
            set { v = value; }
        }
        public AdjList() { }
        public AdjList(int k)
        {
            v = new LinkedList<int>[k];
        }
        public AdjList(LinkedList<int>[] g)
        {
            v = g;
        }
        public void FileToAdjList(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            n = int.Parse(sr.ReadLine());
            v = new LinkedList<int>[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = new LinkedList<int>();
                string st = sr.ReadLine();
                if (st != "")
                {
                    string[] s = st.Split();
                    for (int j = 0; j < s.Length; j++)
                    {
                        int x = int.Parse(s[j]);
                        v[i].AddLast(x);
                    }
                }
            }
            sr.Close();
        }
        public void Output()
        {
            Console.WriteLine("Đồ thị danh sách kề - số đỉnh : " + n);
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("   Đỉnh {0} ->", i);
                foreach (int x in v[i])
                    Console.Write("{0, 3}", x);
                Console.WriteLine();
            }
        }
        public void DegV(string filePath)
        {
                StreamWriter sw = new StreamWriter(filePath);
                for (int i = 0; i < n; i++)
                {
                    int deg = v[i].Count;
                    sw.WriteLine("Đỉnh {0} có bậc {1}", i, deg);
                    Console.WriteLine("Đỉnh {0} có bậc {1}", i, deg);
                }
                sw.Close();
        }

    }
}
