using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai1.Controller;
using bai1.Utils;

namespace bai1.Model
{
    internal class Kho
    {
        public String makho;
        public String tenkho;
        public String diachi;

        public Kho() { }

        public Kho(String makho, String tenkho, String diachi)
        {
            this.makho = makho;
            this.tenkho = tenkho;
            this.diachi = diachi;
        }
        public String getMaKho()
        {
            return makho;
        }
        public String getTenKho()
        {
            return tenkho;
        }
        public String getDiaChi()
        {
            return diachi;
        }
        public void setMaKho(String makho)
        {
            this.makho = makho;
        }
        public void setTenKho(String tenkho)
        {
            this.tenkho = tenkho;
        }
        public void setDiaChi(String diachi)
        {
            this.diachi = diachi;
        }
        public String toString()
        {
            return makho + tenkho;
        }
    }
}