using EventOrganizer.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Moq;
using System.Security;

namespace EventOrganizer.Test.WebApi.Services
{
    public class UserContextAccessorTest
    {
        private UserContextAccessor underTest;

        private Mock<IHttpContextAccessor> httpContextAccessorTest;

        [SetUp]
        public void Setup()
        {
            httpContextAccessorTest = new Mock<IHttpContextAccessor>();

            underTest = new UserContextAccessor(httpContextAccessorTest.Object);
        }

        [Test]
        public void GetUserContext_Should_Throw_Exception()
        {
            Assert.Throws<SecurityException>(() =>
                underTest.GetUserContext());
        }
    }
}
