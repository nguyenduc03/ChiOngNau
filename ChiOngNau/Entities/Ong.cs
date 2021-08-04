using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiOngNau.Entities
{
    class Ong
    {
        public int Mau ;
        public string Loai;
        public string TrangThai { get; set; }
       
        public void Xuat()
        {
            if(Mau >= 0)
            Console.Write(" Mau : {0}\t", this.Mau);
            else
                Console.Write(" Mau : 0\t");
            Console.Write(" Trang Thai : {0}\t", this.TrangThai);
            Console.Write(" Loai ong : {0}\t", this.Loai);
            Console.WriteLine();
        }
        public void BiTanCong(int GiaTri)
        {
            this.Mau -= GiaTri;
        }
        public virtual void CapNhatTinhTrang()
        {
            
        }
    }
}
