using ChiOngNau.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiOngNau
{
    class ChienTranh
    {
        public List<Ong> DSOng ;
        public ChienTranh()
        {
            DSOng = new List<Ong>();
        }
        public void KhoiTao()
        {
            Ong temp;
            for(int i = 0;i<30;i++)
            {
                temp = new OngChua();
                DSOng.Add(temp);
            }
            for (int i = 0; i < 30; i++)
            {
                temp = new OngTho();
                DSOng.Add(temp);
            }
            for (int i = 0; i < 30; i++)
            {
                temp = new OngDuc();
                DSOng.Add(temp);
            }
        }
        public void BiTanCong()
        {
            Random r = new Random();
            List<Ong> DSOngConSong = DSOng.Where(p => p.TrangThai == "Chua Chet").ToList();
            int sum = DSOngConSong.Count;
            if (DSOngConSong.Count !=0)
            {
                foreach (Ong item in DSOng)
                {
                    if (item.TrangThai == "Chua Chet")
                    {
                        item.BiTanCong(r.Next(0, 80));
                        item.CapNhatTinhTrang();
                    }
                }
                Console.WriteLine("Tan Cong Thanh Cong ");

                List<Ong> DSOngSau = DSOng.Where(p => p.TrangThai == "Chua Chet").ToList();
                
                Console.WriteLine("Ban Ha Guc : {0} ",sum-DSOngSau.Count);
            }
            else
            {
                Console.WriteLine("Tat ca ong da chet ");
            }
        }
        public void Xuat()
        {
            List<Ong> DSOngConSong = DSOng.Where(p => p.TrangThai == "Chua Chet").ToList();
            
            Console.WriteLine("\n\t\tDanh Sach Dan Ong Con Song : {0}",DSOngConSong.Count);
            
            foreach (Ong item in DSOngConSong)
            {
                item.Xuat();
            }
            List<Ong> DSOngDaChet = DSOng.Where(p => p.TrangThai == "Da Chet").ToList();
            Console.WriteLine("\n\t\tDanh Sach Dan Ong Da Chet : {0}",DSOngDaChet.Count);

            foreach (Ong item in DSOngDaChet)
            {
                item.Xuat();
            }
        }
        
    }
}
