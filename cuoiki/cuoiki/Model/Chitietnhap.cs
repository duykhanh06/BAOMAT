using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiki.Model
{
    internal class Chitietnhap
    {
        public Int32 id;
        public String maphieunhap;
        public String maxe;
        public Int32 soluongnhap;
        public Int32 gianhap;

        public Chitietnhap() { }
        public Chitietnhap(int id, string maphieunhap, string maxe, int soluongnhap, int gianhap)
        {
            this.id = id;
            this.maphieunhap = maphieunhap;
            this.maxe = maxe;
            this.soluongnhap = soluongnhap;
            this.gianhap = gianhap;
        }
        public Int32 getid()
        {
            return id;
        }
        public String getmaphieunhap()
        {
            return maphieunhap;
        } 
        public String getmaxe()
        {
            return maxe;
        }
        public Int32 getsoluongnhap()
        {
            return soluongnhap;
        }
        public Int32 getgianhap()
        {
            return gianhap;
        }
        public void setid(Int32 id)
        {
            this.id=id;
        }
        public void setmaphieunhap(String maphieunhap)
        {
            this.maphieunhap = maphieunhap;
        }
        public void setmaxe(String maxe)
        {
            this.maxe = maxe;
        }
        public void setsoluongnhap(Int32 soluongnhap)
        {
            this.soluongnhap = soluongnhap;
        }
        public void setgianhap(Int32 gianhap)
        {
            this.gianhap = gianhap;
        }
    }
}
