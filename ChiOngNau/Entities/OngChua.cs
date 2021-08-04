using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiOngNau.Entities
{
    class OngChua :Ong
    {
        int MauToiThieu = 70;
        public OngChua()
        {
            this.Loai = "Ong Chua ";
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
