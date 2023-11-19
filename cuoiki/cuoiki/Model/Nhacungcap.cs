using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiki.Model
{
    internal class Nhacungcap
    {
        public String manhacungcap;
        public String tennhacungcap;
        public String diachi;
        public Nhacungcap() { }
        public Nhacungcap(string manhacungcap, string tennhacungcap, string diachi)
        {
            this.manhacungcap = manhacungcap;
            this.tennhacungcap = tennhacungcap;
            this.diachi = diachi;
        }
        public String getmanhacungcap()
        {
            return manhacungcap;
        }
        public String gettennhacungcap()
        {
            return tennhacungcap;
        }
        public String getdiachi()
        {
            return diachi;
        }
        public void setmanhacungcap(String manhacungcap)
        {
            this.manhacungcap = manhacungcap;
        }
        public void settennhacungcap(String tennhacungcap)
        {
            this.tennhacungcap = tennhacungcap;
        }
        public void setdiachi(String diachi)
        {
            this.diachi = diachi;
        }
    }
}
