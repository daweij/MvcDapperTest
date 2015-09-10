using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcDapperTest.Core;
using MvcDapperTest.Repository;

namespace MvcDapperTest.Web.Controllers
{
  public class HomeController : Controller
  {
    private string connectionString;
    private IUserRepository _repository;

    public HomeController()
    {
      connectionString = "...";
      _repository = new UserRepository(connectionString);
    }

    public ActionResult Index()
    {
      var model = _repository.All();
      return View(model);
    }
  }
}