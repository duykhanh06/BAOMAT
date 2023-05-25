using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_BookStore2.Models;

using PagedList;
using PagedList.Mvc;
namespace MVC_BookStore2.Controllers
{
    public class BookStoreController : Controller
    {
        dbQLBansachDataContext data = new dbQLBansachDataContext();

        public dbQLBansachDataContext Data { get => data; set => data = value; }

        // GET: BookStore
        private List<SACH> laysachmoi(int count)
        {
            return Data.SACHes.OrderByDescending(a => a.Ngaycapnhat).Take(count).ToList();
        }

        public ActionResult Index(int ? page)
        {
            //tao bien quy dinh so san pham tren moi trang
            int pageSize = 5;
            //tao bien so trang
            int pageNum = (page ?? 1);
            //lay top 5 album ban chyaj nhất
            var sachmoi = laysachmoi(15);
            return View(sachmoi.ToPagedList(pageNum,pageSize));
        }

        public ActionResult Chude()
        {
            var chude = from cd in data.CHUDEs select cd;
            return PartialView(chude);
        }
        public ActionResult Nhaxuatban()
        {
            var nhaxuatban = from cd in data.NHAXUATBANs select cd;
            return PartialView(nhaxuatban);
        }
        public ActionResult SPTheochude(int id)
        {
            var sach = from s in data.SACHes where s.MaCD == id select s;
            return View(sach);
        }
        public ActionResult SPTheoNXB(int id)
        {
            var sach = from s in data.SACHes where s.MaNXB == id select s;
            return View(sach);
        }
        public ActionResult Details(int id)
        {
            var sach = from s in data.SACHes
                       where s.Masach == id
                       select s;
            return View(sach.Single());
        }
    }
}