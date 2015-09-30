using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcDapperTest.Core;
using MvcDapperTest.Repository;

namespace MvcDapperTest.Web.Controllers
{
    public class BaseController : Controller
    {
        protected string connectionString;
        protected IUserRepository _repository;

        public BaseController()
        {
            connectionString = "...";
            _repository = new UserRepository(connectionString);
        }
    }
}