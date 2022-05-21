using mvc_ProjectCRUD.db_context;
using mvc_ProjectCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_ProjectCRUD.Controllers
{
    public class EmployeeController : Controller
    {
         public ActionResult Show()
        {
            lokeshEntities1 db = new lokeshEntities1();
           List<EmpModel> empmodel = new List<EmpModel>();

            var res = db.Emp_table.ToList();

                foreach(var item in res)
            {
                empmodel.Add(new EmpModel
                { EmpId=item.EmpId,
                 EmpName = item.EmpName,
                 EmpAddress = item.EmpAddress,   
                 EmpEmail = item.EmpEmail,   
                 EmpMobile = item.EmpMobile, 
                 DOB = item.DOB,    

                
                });
            }

            return View(empmodel);
        }
        // GET: Employee
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }  
        [HttpPost]
        public ActionResult Index(EmpModel  obj)
        {
            lokeshEntities1 db = new lokeshEntities1(); 
            Emp_table objtable =  new Emp_table();

            objtable.EmpId = obj.EmpId;
            objtable.EmpName = obj.EmpName;
            objtable.EmpEmail = obj.EmpEmail;
            objtable.EmpMobile = obj.EmpMobile;
            objtable.EmpAddress = obj.EmpAddress;
            objtable.DOB = obj.DOB;

            if (obj.EmpId == 0)
            {

                db.Emp_table.Add(objtable);
                db.SaveChanges();
            }
            else
            {
                db.Entry(objtable).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }


            return RedirectToAction("Show");
        }
        public ActionResult Delete(int EmpId)
                  {
            lokeshEntities1 db = new lokeshEntities1();
            var resDelete = db.Emp_table.Where(m => m.EmpId == EmpId).First();
            db.Emp_table.Remove(resDelete);
            db.SaveChanges();   

            return RedirectToAction("Show");
        }
        public ActionResult Update(int EmpId)
        {
            lokeshEntities1 db = new lokeshEntities1();
            EmpModel  empmodel = new EmpModel();    
            var resUpdate = db.Emp_table.Where(m=>m.EmpId == EmpId).First();
            empmodel.EmpId = resUpdate.EmpId;
            empmodel.EmpName = resUpdate.EmpName;
            empmodel.EmpMobile= resUpdate.EmpMobile;    
            empmodel.EmpEmail= resUpdate.EmpEmail;  
            empmodel.EmpAddress= resUpdate.EmpAddress;
            empmodel.DOB= resUpdate.DOB;

            ViewBag.Edit = "edit";
            ViewBag.Update = "update";
            return View("Index", empmodel);

        }

        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(EmpModel obj)
        {
            return View();
        }
    }
}
