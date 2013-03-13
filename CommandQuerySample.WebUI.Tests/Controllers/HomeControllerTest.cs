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

namespace CommandQuerySample.WebUI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private Mock<IGetUserByIdQuery> getUserByIdQuery;
        private Mock<IAddDepartmentCommand> addDepartmentCommand;
        private Mock<IAddUserCommand> addUserCommand;
        private Mock<IAddUserToDepartmentsCommand> addUserToDepartmentsCommand;
        [TestInitialize]
        public void Setup()
        {
            getUserByIdQuery = new Mock<IGetUserByIdQuery>();
            addDepartmentCommand = new Mock<IAddDepartmentCommand>();
            addUserCommand = new Mock<IAddUserCommand>();
            addUserToDepartmentsCommand = new Mock<IAddUserToDepartmentsCommand>();
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
            return new HomeController(addDepartmentCommand.Object, 
                addUserCommand.Object, 
                addUserToDepartmentsCommand.Object, 
                getUserByIdQuery.Object);
        }
    }
}
