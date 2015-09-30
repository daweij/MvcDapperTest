using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcDapperTest.Core;
using MvcDapperTest.Repository;

namespace MvcDapperTest.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var model = _repository.All();
            return View(model);
        }
    }
}