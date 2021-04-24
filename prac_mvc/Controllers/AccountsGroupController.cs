using prac_mvc.dbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prac_mvc.Controllers
{
    public class AccountsGroupController : Controller
    {
        // GET: AccountsGroup
        GPAC_ERPEntities1 _db = new GPAC_ERPEntities1();
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult IndexlIST()
        {
           

            return View();
        }
        [HttpPost]
        public JsonResult AjaxMethod()
        {


            List<Acc_Head> customers =  _db.Acc_Head.ToList();
            return Json(customers);
        }
        public ActionResult Save(Acc_Head model)
        {
            Acc_Head obj = new Acc_Head();
            if (ModelState.IsValid)
            {
              
                obj.Account_Head = model.Account_Head;

                obj.Sl = model.Sl;
                _db.Acc_Head.Add(obj);
                _db.SaveChanges();

                TempData["message"] = "Saved Data";
               
            }
            List();
            return View("List");
        }
        public ActionResult Update(Acc_Head model)
        {
            Acc_Head obj = _db.Acc_Head.Where(x=>x.Account_Code == model.Account_Code).FirstOrDefault();
            obj.Account_Head = model.Account_Head;
            if (Convert.ToInt32(model.Sl) > 500)
            {
                obj.Sl = "5000";
            }
            else
            {
                obj.Sl = model.Sl;
            }
            
            _db.SaveChanges();
            List();
            return View("List");
        }
        public ActionResult List()
        {
            Acc_Head obj = new Acc_Head();
            return View(_db.Acc_Head.ToList());
        }
        public ActionResult Edit(int id)
        {
            Acc_Head obj = _db.Acc_Head.Where(x => x.Account_Code == id).FirstOrDefault();
            return View(obj);
        }
        public ActionResult Delete(int id)
        {
            var obj= _db.Acc_Head.Where(x => x.Account_Code == id).FirstOrDefault();
            _db.Acc_Head.Remove(obj);
            _db.SaveChanges();
            List();
            return View("List");
        }
    }
}