using AutoMapper;
using EventOrganizer.Core.Queries.EventQueries;
using EventOrganizer.Core.Repositories;
using EventOrganizer.Domain.Models;
using Moq;

namespace EventOrganizer.Test.Core.Queries.EventQueries
{
    public class GetEventByIdQueryTest
    {
        private GetEventByIdQuery underTest;

        private Mock<IEventRepository> eventRepositoryMock;

        public Mock<IMapper> mapperMock;

        [SetUp]
        public void Setup()
        {
            eventRepositoryMock = new Mock<IEventRepository>();
            mapperMock = new Mock<IMapper>();

            underTest = new GetEventByIdQuery(eventRepositoryMock.Object, mapperMock.Object);
        }

        [Test]
        public void Execute_Should_Throw_Exception()
        {
            eventRepositoryMock.Setup(x => x.Get(It.IsAny<int>()))
                .Returns(null as EventModel);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
                underTest.Execute(new GetEventByIdQueryParameters { Id = 1 }));
        }
    }
}
