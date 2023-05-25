using MVC_BookStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.IO;

namespace MVC_BookStore2.Controllers
{
    public class AdminController : Controller
    {
        dbQLBansachDataContext db = new dbQLBansachDataContext();

            // GET: Admin
            public ActionResult Index()
            {
                return View();
            }
            public ActionResult Sach(int? page)
            {
                int pageNumber = (page ?? 1);
                int pageSize = 7;
                return View(db.SACHes.ToList().OrderBy(n => n.Masach).ToPagedList(pageNumber, pageSize));
            }
            [HttpGet]
            public ActionResult Login()
            {
                return View();
            }
            [HttpPost]
            public ActionResult Login(FormCollection collection)
            {
                var tendn = collection["username"];
                var matkhau = collection["password"];
                if (String.IsNullOrEmpty(tendn))
                {
                    ViewData["Loi1"] = "Phải nhập tên đăng nhập";
                }
                else if (String.IsNullOrEmpty(matkhau))
                {
                    ViewData["Loi2"] = "Phải nhập mật khẩu";
                }
                else
                {
                    Admin ad = db.Admins.SingleOrDefault(n => n.UserAdmin == tendn && n.PassAdmin == matkhau);
                    if (ad != null)
                    {
                        Session["Taikhoanadmin"] = ad;
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                        ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";

                }
                return View();
            }

            [HttpGet]
            public ActionResult ThemmoiSach()
            {
                ViewBag.MaCD = new SelectList(db.CHUDEs.ToList().OrderBy(n => n.TenChuDe), "MaCD", "TenChude");
                ViewBag.MaNXB = new SelectList(db.NHAXUATBANs.ToList().OrderBy(n => n.TenNXB), "MaNXB", "TenNXB");
                return View();
            }
            [HttpPost]
            [ValidateInput(false)]
            public ActionResult ThemmoiSach(SACH sach, HttpPostedFileBase fileupload)
            {
                ViewBag.MaCD = new SelectList(db.CHUDEs.ToList().OrderBy(n => n.TenChuDe), "MaCD", "TenChude");
                ViewBag.MaNXB = new SelectList(db.NHAXUATBANs.ToList().OrderBy(n => n.TenNXB), "MaNXB", "TenNXB");
                if (fileupload == null)
                {
                    ViewBag.Thongbao = "Vui lòng chọn ảnh bìa ";
                    return View();
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        var fileName = Path.GetFileName(fileupload.FileName);
                        var path = Path.Combine(Server.MapPath("~/Hinhsanpham"), fileName);
                        if (System.IO.File.Exists(path))
                            ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                        else
                        {
                            fileupload.SaveAs(path);
                        }
                        sach.Anhbia = fileName;
                        db.SACHes.InsertOnSubmit(sach);
                        db.SubmitChanges();
                    }
                    return RedirectToAction("Sach");
                }

            }

            public ActionResult Chitietsach(int id)
            {
                SACH sach = db.SACHes.SingleOrDefault(n => n.Masach == id);
                ViewBag.Masach = sach.Masach;
                if (sach == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                return View(sach);
            }
            [HttpGet]
            public ActionResult Xoasach(int id)
            {
                SACH sach = db.SACHes.SingleOrDefault(n => n.Masach == id);
                ViewBag.Masach = sach.Masach;
                if (sach == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                return View(sach);
            }
            [HttpPost, ActionName("Xoasach")]
            public ActionResult Xacnhanxoa(int id)
            {
                SACH sach = db.SACHes.SingleOrDefault(n => n.Masach == id);
                ViewBag.Masach = sach.Masach;
                if (sach == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                db.SACHes.DeleteOnSubmit(sach);
                db.SubmitChanges();
                return RedirectToAction("Sach");
            }

            [HttpGet]
            public ActionResult Suasach(int id)
            {
                SACH sach = db.SACHes.SingleOrDefault(n => n.Masach == id);
                if (sach == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                ViewBag.MaCDList = new SelectList(db.CHUDEs.ToList().OrderBy(n => n.TenChuDe), "MaCD", "TenChuDe", sach.MaCD);
                ViewBag.MaNXBList = new SelectList(db.NHAXUATBANs.ToList().OrderBy(n => n.TenNXB), "MaNXB", "TenNXB", sach.MaNXB);
                return View(sach);
            }
            [HttpPost]
            [ValidateInput(false)]
            public ActionResult Suasach(SACH sach, HttpPostedFileBase fileUpload, FormCollection f)
            {
                // Đưa dữ liệu vào DropdownList
                ViewBag.MaCDList = new SelectList(db.CHUDEs.ToList().OrderBy(n => n.TenChuDe), "MaCD", "TenChuDe", sach.MaCD);
                ViewBag.MaNXBList = new SelectList(db.NHAXUATBANs.ToList().OrderBy(n => n.TenNXB), "MaNXB", "TenNXB", sach.MaNXB);
                // Kiểm tra đường dẫn file
                if (fileUpload == null)
                {
                    ViewBag.Thongbao = "Vui lòng chọn ảnh bìa!";
                    return View();
                }
                // Thêm vào CSDL
                else
                {
                    if (ModelState.IsValid)
                    {
                        // Lưu tên file, lưu ý bổ sung thư viện System.IO
                        var fileName = Path.GetFileName(fileUpload.FileName);
                        // Lưu đường dẫn của file
                        var path = Path.Combine(Server.MapPath("~/Hinhsanpham"), fileName);
                        // Kiểm tra hình ảnh tồn tại chưa
                        if (System.IO.File.Exists(path))
                        {
                            ViewBag.Thongbao = "Hình ảnh đã tồn tại!";
                        }
                        else
                        {
                            // Lưu hình ảnh vào đường dẫn
                            fileUpload.SaveAs(path);
                        }
                        sach = db.SACHes.SingleOrDefault(s => s.Masach == Int32.Parse(f.Get("Masach")));
                        sach.Anhbia = fileName;
                        sach.Tensach = f.Get("Tensach");
                        sach.Giaban = Decimal.Parse(f.Get("Giaban"));
                        sach.Mota = f.Get("Mota");
                        sach.Ngaycapnhat = DateTime.Parse(f.Get("Ngaycapnhat"));
                        sach.Soluongton = Int32.Parse(f.Get("Soluongton"));
                        sach.MaCD = Int32.Parse(f.Get("MaCD"));
                        sach.MaNXB = Int32.Parse(f.Get("MaNXB"));

                        // Lưu vào CSDL
                        db.SubmitChanges();
                    }
                }
                return RedirectToAction("Sach");
            }
        //hiển thị sản phẩm
      

        }
    }
