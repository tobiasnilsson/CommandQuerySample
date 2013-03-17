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
                    new NewAddUserCommand {User = new User {Name = "Mick Jagger"}},
                    new NewAddUserCommand {User = new User {Name = "Bob Dylan"}},
                    new NewAddUserCommand {User = new User {Name = "Steve Mason"}}
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
