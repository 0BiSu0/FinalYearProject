using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDatVe.Attributes;
using WebDatVe.Models;

namespace WebDatVe.Areas.Admin.Controllers
{
    [AdminAuthorize]
    [PemisitonAttribute("Tin tức")]
    public class TinTucController : BaseController
    {
        // GET: Admin/TinTuc
        public ActionResult Index(string keyword = "")
        {
            var list = Db.TinTucs.Where(x => x.TieuDe.Contains(keyword)).OrderByDescending(x => x.MaTinTuc).ToList();
            ViewBag.TextSearch = keyword;
            return View(list);
        }

        public ActionResult Add()
        {
            return View(new TinTuc());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Add(TinTuc model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var obj = Db.TinTucs.FirstOrDefault(x => x.TieuDe == model.TieuDe);
                    if (obj == null)
                    {
                        model.NgayTao = DateTime.Now;
                        Db.TinTucs.Add(model);
                        Db.SaveChanges();
                        TempData["notice"] = "New added success!";

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["notice"] = "Title already exists! Please choose another name!";
                    }
                }
                catch
                {
                    TempData["notice"] = "Add failed!";
                }
            }

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            try
            {
                var model = Db.TinTucs.FirstOrDefault(x => x.MaTinTuc == id);
                if (model == null)
                {
                    model.MaTinTuc = 0;
                }
                return View(model);
            }
            catch
            {
                TempData["notice"] = "Data does not exist!";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(TinTuc model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var objCheck = Db.TinTucs.FirstOrDefault(x => x.TieuDe == model.TieuDe && x.MaTinTuc != model.MaTinTuc);
                    if (objCheck == null)
                    {
                        var obj = Db.TinTucs.FirstOrDefault(x => x.MaTinTuc == model.MaTinTuc);
                        obj.TieuDe = model.TieuDe;
                        obj.HinhAnh = model.HinhAnh;
                        obj.GioiThieu = model.GioiThieu;
                        obj.NoiDung = model.NoiDung;

                        Db.TinTucs.Attach(obj);
                        Db.Entry(obj).State = EntityState.Modified;
                        Db.SaveChanges();
                        TempData["notice"] = "Repair success!";

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["notice"] = "Title already exists! Please choose another name!";
                    }
                }
                catch
                {
                    TempData["notice"] = "Repair failed!";
                }
            }
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                var model = Db.TinTucs.FirstOrDefault(x => x.MaTinTuc == id);
                Db.TinTucs.Attach(model);
                Db.Entry(model).State = EntityState.Deleted;
                Db.TinTucs.Remove(model);
                Db.SaveChanges();
                TempData["notice"] = "Delete successfully!";
            }
            catch
            {
                TempData["notice"] = "Cause: There is a database constraint!";
            }

            return RedirectToAction("Index");
        }
    }
}