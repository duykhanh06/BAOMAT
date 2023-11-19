using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1.Model
{
    internal class Hanghoa
    {

        public String mahanghoa;
        public String tenhanghoa;
        public String dvt;

        public Hanghoa() { }

        public Hanghoa(String mahanghoa, String tenhanghoa, String dvt)
        {
            this.mahanghoa = mahanghoa;
            this.tenhanghoa = tenhanghoa;
            this.dvt = dvt;
        }
        public String getmahanghoa()
        {
            return mahanghoa;
        }
        public String gettenhanghoa()
        {
            return tenhanghoa;
        }
        public String getdvt()
        {
            return dvt;
        }
        public void setmahanghoa(String mahanghoa)
        {
            this.mahanghoa = mahanghoa;
        }
        public void settenhanghoa(String tenhanghoa)
        {
            this.tenhanghoa = tenhanghoa;
        }
        public void setdvt(String dvt)
        {
            this.dvt = dvt;
        }
    }
}
