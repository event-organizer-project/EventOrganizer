using AutoFixture;
using EventOrganizer.Core.Commands.EventCommands;
using EventOrganizer.Core.Repositories;
using Moq;

namespace EventOrganizer.Test.Core.Commands.EventCommands
{
    public class DeleteEventCommandTest
    {
        private DeleteEventCommand underTest;

        private Mock<IEventRepository> eventRepositoryMock;

        private Fixture fixture;

        [SetUp]
        public void Setup()
        {
            fixture = new Fixture();

            eventRepositoryMock = new Mock<IEventRepository>();

            underTest = new DeleteEventCommand(eventRepositoryMock.Object);
        }

        [Test]
        public void Execute_Should_Return_Expected_Result()
        {
            var parameters = fixture.Create<DeleteEventCommandParameters>();

            var actualResult = underTest.Execute(parameters);

            eventRepositoryMock.Verify(x => x.Delete(parameters.EventId), Times.Once);
        }
    }
}
