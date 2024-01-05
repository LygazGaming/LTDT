using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /* Tạo menu */
            AdjMatrix g = new AdjMatrix();
            AdjList l=new AdjList();
            EdgeList e=new EdgeList();  
            Menu menu = new Menu();
            string title = "NHẬP, XUẤT & CÁC THAO TÁC CƠ BẢN TRÊN ĐỒ THỊ";
            string[] ms = { "1. Bài 1: Đồ thị vô hướng ma trận kề, tính bậc của của các đỉnh",
                "2. Bài 2: Đồ thị có hướng ma trận kề, bậc vào, tính bậc ra của các đỉnh",
                "3. Bài 3: Đồ thị danh sách kề, tính bậc các đỉnh",
                "4. Bài 4: Đồ thị danh sách cạnh, tính bậc của các đỉnh",
                "0. Thoát" };
            int chon;
            do
            {
                menu.ShowMenu(title, ms);
                Console.Write("     Chọn : ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        {  
                            string fileInput = "../../TextFile/AdjMatrix.txt";
                            g.FileToAdjMatrix(fileInput);
                            g.Output();
                            string fileOutput = "../../TextFile/BacCacDinh.txt";
                            g.DegVs(fileOutput);
                            break;
                        }
                    case 2:
                        {
                            string fileInput = "../../TextFile/DirectedMatrix.txt";
                            g.FileToAdjMatrix(fileInput);
                            string fileOutput = "../../TextFile/output.txt";
                            g.DegInOut(fileOutput);
                            break;
                        }
                    case 3:
                        {
                            string fileInput = "../../TextFile/AdjList.txt";
                            l.FileToAdjList(fileInput);
                            l.Output();
                            string fileOutput = "../../TextFile/Danhsachke.txt";
                            l.DegV(fileOutput);
                            break;
                        }
                    case 4:
                        {
                            string fileInput = "../../TextFile/EdgeList.txt";
                            e.FileToEdgeList(fileInput);
                            e.Output();
                            string fileOutput = "../../TextFile/EdgeListoutput.txt";
                            e.DegV(fileOutput);
                            break;
                        }
                }

                Console.WriteLine(" Nhấn một phím bất kỳ");
                Console.ReadKey();
                Console.Clear();
            } while (chon != 0);
        }
    }
}
