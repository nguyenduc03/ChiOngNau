using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiOngNau.Entities
{
    class OngTho :Ong
    {

        int MauToiThieu = 50;
        public OngTho()
        {
            this.Loai = "Ong Tho ";
            this.Mau = 100;
            this.TrangThai = "Chua Chet";
        }
        public override void CapNhatTinhTrang()
        {
            if (Mau < MauToiThieu)
                this.TrangThai = "Da Chet";
        }

    }
}
