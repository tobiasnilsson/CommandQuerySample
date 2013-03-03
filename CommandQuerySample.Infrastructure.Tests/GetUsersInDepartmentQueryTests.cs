using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandQuerySample.Core.Entities;
using CommandQuerySample.Infrastructure.DbContexts;
using CommandQuerySample.Infrastructure.Queries;
using NUnit.Framework;
using Moq;

namespace CommandQuerySample.Infrastructure.Tests
{
    [TestFixture]
    public class GetUsersInDepartmentQueryTests
    {
        private Mock<ISampleDbContext> sampleDbContextMock;

        [SetUp]
        public void Setup()
        {
            sampleDbContextMock = new Mock<ISampleDbContext>();
        }

        [Test]
        public void Should_Return_Users_In_Specific_Department()
        {
            var users = new List<User>
                {
                    new User{DepartmentId = 1}, 
                    new User{DepartmentId = 1}, 
                    new User{DepartmentId = 2}
                };

            //var dbSet = new Mock<IDbSet<User>>();
            //users.ForEach(u => dbSet.Object.Add(u));

            var dbSet = new Mock<InMemoryDbSet<User>>();
            users.ForEach(u => dbSet.Object.Add(u));

            sampleDbContextMock.Setup(s => s.Users).Returns(dbSet.Object);

            var queryToTest = new GetUsersInDepartmentQuery(sampleDbContextMock.Object);

            var result = queryToTest.GetUsers(departmentId:1);

            Assert.That(result.Count() == 2);

        }
    }
}
