using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using CommandQuerySample.Core.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommandQuerySample.WebUI;
using CommandQuerySample.WebUI.Controllers;
using Moq;
using CommandQuerySample.Core.Commands;
using CommandQuerySample.Core.NewCommands;

namespace CommandQuerySample.WebUI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private Mock<ICommandExecutor> _commandExecutor;
            
        [TestInitialize]
        public void Setup()
        {
            _commandExecutor = new Mock<ICommandExecutor>();
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = GetController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", result.ViewBag.Message);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = GetController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = GetController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        public HomeController GetController()
        {
            return new HomeController(_commandExecutor.Object);
        }
    }
}
