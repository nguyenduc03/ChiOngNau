using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiOngNau
{
    class Program
    {
        static void Main(string[] args)
        {
            GiaoDien();


        }
        public static void GiaoDien()
        {
            ChienTranh temp = new ChienTranh();
            temp.KhoiTao();
            int key;
            do {
                Console.Clear();
                key = menu();
                switch (key)
                {
                    case 1:
                        temp.BiTanCong();
                        break;
                    case 2:
                        temp.Xuat();
                        break;
                    case 3:
                        temp = new ChienTranh();
                        temp.KhoiTao();
                        break;
                    default:
                        break;
                }

                Console.Write("Nhan enter de tiep tuc ........");
                Console.ReadLine();
            }
            while (key != 0);
           

        }
        public static int menu()
        {
            int key = 0;
            do
            {
                Console.WriteLine("---------Menu------");
                Console.WriteLine("\t1 : Tan Cong");
                Console.WriteLine("\t2 : Hien Danh Sach Ong");
                Console.WriteLine("\t3 : Choi Lai");
                Console.WriteLine("\t0 : Thoat");
                Console.Write("Nhap Chuc Nang : ");
                key = int.Parse(Console.ReadLine());
            } while (key < 0 || key > 3);
            return key;
        }
    }
}
