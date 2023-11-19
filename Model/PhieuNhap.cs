using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1.Model
{
    internal class PhieuNhap
    {

        public String maphieunhap;
        public DateTime ngayphieunhap;
        public String nguoigiao;
        public String sohoadon;
        public DateTime ngayhoadon;
        public String donviphathanh;
        public Int32 makho;

        public PhieuNhap() { }

        public PhieuNhap(String maphieunhap, DateTime ngayphieunhap, String nguoigiao, String sohoadon, DateTime ngayhoadon, String donviphathanh, Int32 makho)
        {
            this.maphieunhap = maphieunhap;
            this.ngayphieunhap = ngayphieunhap;
            this.nguoigiao = nguoigiao;
            this.sohoadon = sohoadon;
            this.ngayhoadon = ngayhoadon;
            this.donviphathanh = donviphathanh;
            this.makho = makho;
        }
        public String getmaphieunhap()
        {
            return maphieunhap;
        }
        public DateTime getngayphieunhap()
        {
            return ngayphieunhap;
        }
        public String getnguoigiao()
        {
            return nguoigiao;
        }
        public String getsohoadon()
        {
            return sohoadon;
        }
        public DateTime getngayhoadon()
        {
            return ngayhoadon;
        }
        public String getdonviphathanh()
        {
            return donviphathanh;
        }
        public Int32 getmakho()
        {
            return makho;
        }
        public void setmaphieunhap(String maphieunhap)
        {
            this.maphieunhap = maphieunhap;
        }
        public void setngayphieunhap(DateTime ngayphieunhap)
        {
            this.ngayphieunhap = ngayphieunhap;
        }
        public void setnguoigiao(String nguoigiao)
        {
            this.nguoigiao = nguoigiao;
        }
        public void setsohoadon(String sohoadon)
        {
            this.sohoadon = sohoadon;
        }
        public void setngayhoadon(DateTime ngayhoadon)
        {
            this.ngayhoadon = ngayhoadon;
        }
        public void setdonviphathanh(String donviphathanh)
        {
            this.donviphathanh = donviphathanh;
        }
        public void setmakho(Int32 makho)
        {
            this.makho = makho;
        }
    }
}
