using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bai1.Model
{
    internal class ChiTietNhap
    {

        public Int32 id;
        public String maphieunhap;
        public String mahanghoa;
        public Int32 soluong;
        public float dongia;
        public ChiTietNhap() { }

        public ChiTietNhap(Int32 id, String maphieunhap, String mahanghoa, Int32 soluong, float dongia)
        {
            this.id = id;
            this.maphieunhap = maphieunhap;
            this.mahanghoa = mahanghoa;
            this.soluong = soluong;
            this.dongia = dongia;
        }
        public Int32 getid()
        {
            return id;
        }
        public String getmaphieunhap()
        {
            return maphieunhap;
        }
        public String getmahanghoa()
        {
            return mahanghoa;
        }
        public Int32 getsoluong()
        {
            return soluong;
        }
        public float getdongia()
        {
            return dongia;
        }
        public void setid(Int32 id)
        {
            this.id = id;
        }
        public void setmaphieunhap(String maphieunhap)
        {
            this.maphieunhap = maphieunhap;
        }
        public void setmahanghoa(String mahanghoa)
        {
            this.mahanghoa = mahanghoa;
        }
        public void setsoluong(Int32 soluong)
        {
            this.soluong = soluong;
        }
        public void setdongia(float dongia)
        {
            this.dongia = dongia;
        }
    }
}
