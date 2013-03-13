using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommandQuerySample.Core.Commands;
using CommandQuerySample.Core.Queries;
using CommandQuerySample.Infrastructure;
using CommandQuerySample.Infrastructure.DbContexts;

namespace CommandQuerySample.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAddDepartmentCommand _addDepartmentCommand;
        private readonly IAddUserCommand _addUserCommand;
        private readonly IAddUserToDepartmentsCommand _addUserToDepartmentsCommand;
        private readonly IGetUserByIdQuery _getUserByIdQuery;

        public HomeController(IAddDepartmentCommand addDepartmentCommand, 
            IAddUserCommand addUserCommand, 
            IAddUserToDepartmentsCommand addUserToDepartmentsCommand,
            IGetUserByIdQuery getUserByIdQuery)
        {
            _addDepartmentCommand = addDepartmentCommand;
            _addUserCommand = addUserCommand;
            _addUserToDepartmentsCommand = addUserToDepartmentsCommand;
            _getUserByIdQuery = getUserByIdQuery;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
