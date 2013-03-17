using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommandQuerySample.Core.Commands;
using CommandQuerySample.Core.Entities;
using CommandQuerySample.Core.Queries;
using CommandQuerySample.Infrastructure;
using CommandQuerySample.Infrastructure.DbContexts;
using CommandQuerySample.Core.NewCommands;

namespace CommandQuerySample.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICommandExecutor _commandExecutor;

        public HomeController(ICommandExecutor commandExecutor)
        {
            _commandExecutor = commandExecutor;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var commands = new List<ICommand>
                {
                    new NewAddUserCommand {User = new User {Name = "Mick Jagger", Department = new Department{Name = "Dept A"}}},
                    new NewAddUserCommand {User = new User {Name = "Steve Mason", Department = new Department{Name = "Dept B"}}},

                    new NewAddUserToDepartmentsCommand
                    { 
                        User = new User{ Name = "Deputy Dave"},
                        Departments = new List<Department>
                            {
                                new Department{Name = "Dept 1"}, 
                                new Department{Name = "Dept 2"}
                            }}
                };

            _commandExecutor.Execute(commands);

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
