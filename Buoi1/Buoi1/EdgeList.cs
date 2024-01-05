using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class EdgeList
    {
        LinkedList<Tuple<int, int>> g;
        int n; 
        int m; 
        // Propeties
        public int N { get => n; set => n = value; }
        public int M { get => m; set => m = value; }
        public LinkedList<Tuple<int, int>> G { get => g; set => g = value; }
        public EdgeList()
        {
            g = new LinkedList<Tuple<int, int>>();
        }
        public void FileToEdgeList(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string[] s = sr.ReadLine().Split();
            n = int.Parse(s[0]);
            m = int.Parse(s[1]);
            for (int i = 0; i < m; i++)
            {
                s = sr.ReadLine().Split();
                Tuple<int, int> e = new Tuple<int, int>(int.Parse(s[0]), int.Parse(s[1]));
                g.AddLast(e);
            }
            sr.Close();
        }
        public void Output()
        {
            Console.WriteLine("Danh sách cạnh của đồ thị với số đỉnh n = " + n);
            foreach (Tuple<int, int> e in g)
                Console.WriteLine("      (" + e.Item1 + "," + e.Item2 + ")");
        }
        public void DegV(string filePath)
        {
            StreamWriter sw = new StreamWriter(filePath);
            int[] deg = new int[n];
            foreach (Tuple<int, int> e in g)
            {
                deg[e.Item1]++;
                if (e.Item1 != e.Item2)
                {
                    deg[e.Item2]++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                sw.WriteLine("Đỉnh {0} có bậc {1}", i, deg[i]);
            }
            sw.Close();
        }

    }
}
