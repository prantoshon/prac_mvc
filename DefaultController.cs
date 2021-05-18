using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bootstrap.Models;
using PagedList;

namespace Bootstrap.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ind()
        {
            return View();
        }
        public ActionResult Redirct()
        {
            return View("Index");
        }
        [HttpPost]
        public ActionResult Save(model model)
        {
            if (ModelState.IsValid)
            {
                DdContextDataContext _db = new DdContextDataContext();
                UserInfo obj = _db.UserInfos.Where(x => x.ID == model.ID).FirstOrDefault();
                if (obj != null)
                {
                    obj.Name = model.Name;
                    obj.ActiveUser = model.ActiveUser;
                    obj.Phone = model.Phone;
                    obj.Address = model.Address;
                    obj.Email = model.Email;
                    obj.CreateDate = DateTime.Now;
                    _db.SubmitChanges();
                    ViewBag.msg = "System Msg: Save Changes";
                }
                else
                {
                    obj = new UserInfo();
                    obj.Name = model.Name;
                    obj.ActiveUser = model.ActiveUser;
                    obj.Phone = model.Phone;
                    obj.Address = model.Address;
                    obj.Email = model.Email;
                    obj.CreateDate = DateTime.Now;
                    _db.UserInfos.InsertOnSubmit(obj);
                    _db.SubmitChanges();
                    ViewBag.msg = "System Msg: Saved";
                }

            }
            return View("Ind");

        }
        public ActionResult List( int? page)
        {
            int pageSize = 3;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            DdContextDataContext _db = new DdContextDataContext();
            return View(_db.UserInfos.ToList().ToPagedList(page??1,2));
        }
        public ActionResult Edit(int Id)
        {
            DdContextDataContext _db = new DdContextDataContext();
            var edit = _db.UserInfos.Where(x => x.ID == Id).FirstOrDefault();
            return View(edit);

        }
        public ActionResult Delete(int Id)
        {
            DdContextDataContext _db = new DdContextDataContext();
            var delete = _db.UserInfos.Where(x => x.ID == Id).SingleOrDefault();
            _db.UserInfos.DeleteOnSubmit(delete);
            _db.SubmitChanges();
            //   List();
            return View("Ind");

        }
    }
}