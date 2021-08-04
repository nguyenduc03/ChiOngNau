using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiOngNau.Entities
{
    class OngDuc :Ong
    {

        int MauToiThieu = 20;
        public OngDuc()
        {
            this.Loai = "Ong Duc ";
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
