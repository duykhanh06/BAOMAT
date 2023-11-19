using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiki.Model
{
    internal class PhieuNhap
    {
        public String maphieunhap;
        public String sophieunhap;
        public DateTime ngaynhap;
        public String manhacungcap;

        public PhieuNhap() { }
        public PhieuNhap(string maphieunhap, string sophieunhap, DateTime ngaynhap, string manhacungcap)
        {
            this.maphieunhap = maphieunhap;
            this.sophieunhap = sophieunhap;
            this.ngaynhap = ngaynhap;
            this.manhacungcap = manhacungcap;
        }
        public String getmaphieunhap()
        {
            return maphieunhap;
        }
        public String getsophieunhap()
        {
            return sophieunhap;
        }
        public DateTime getngaynhap()
        {
            return ngaynhap;
        }
        public String getmanhacungcap()
        {
            return manhacungcap;
        }
        public void setmaphieunhap (String maphieunhap)
        {
            this.maphieunhap= maphieunhap;
        }
        public void setsophieunhap (String sophieunhap)
        {
            this.sophieunhap= sophieunhap;
        }
        public void setngaynhap(DateTime ngaynhap)
        {
            this.ngaynhap= ngaynhap;
        }
        public void setmanhacungcap(String manhacungcap)
        {
            this.manhacungcap= manhacungcap;
        }
    }

}
