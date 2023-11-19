using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cuoiki.Controller;
using cuoiki.Utils;

namespace cuoiki.Model
{
    internal class BangXe
    {
        public String maxe;
        public String tenxe;
        public Int32 gia;
        public Int32 soluong;

        public BangXe() { }
        public BangXe(string maxe, string tenxe, int gia, int soluong)
        {
            this.maxe = maxe;
            this.tenxe = tenxe;
            this.gia = gia;
            this.soluong = soluong;
        }
        public String getMaxe()
        { 
            return maxe;
        }
        public String getTenxe()
        {
            return tenxe;
        }
        public Int32 getGia()
        {
            return gia;
        }
        public Int32 getSoluong()
        {
            return soluong;
        }
        public void setMaxe(String maxe)
        {
            this.maxe = maxe;
        }
        public void setTenxe(String tenxe)
        {
            this.tenxe = tenxe;
        }
        public void setGia(Int32 gia)
        {
            this .gia = gia;
        }
        public void setSoluong(Int32 soluong)
        {
            this .soluong = soluong;
        }
        public String toString()
        {
            return maxe + tenxe;
        }
    }
}
