using Planner.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planner.Controllers
{
    public class HomeController : Controller
    {
        private IMyTaskService _service;

        public HomeController(IMyTaskService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TaskList()
        {           
            var data = _service.Get();
            return PartialView(data);
        }

        public ActionResult AddTask()
        {
            return PartialView();
        }

        public ActionResult EditTask(int id)
        {
            var data = _service.Get(id);
            return PartialView(data);
        }

        [HttpPost]
        public ActionResult AddTask(MyTaskViewModel data)
        {
            _service.Add(data);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult EditTask(MyTaskViewModel data)
        {
            _service.Edit(data);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTask(int id)
        {
            _service.Remove(id);
            return RedirectToAction("TaskList");
        }
    }
}