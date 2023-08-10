using System;
using Xunit;

namespace MarsRover.Tests
{

    public class MarsRoverTest
    {
        [Fact]
        public void ShouldGivePositionOfTheStartOnMars0_0_N()
        {
            // Given
            MarsRover marsRover = new MarsRover();
            // When
            marsRover.move("");
            // Then
            Assert.Equal(marsRover.position(), "0:0:N");
        }

    }
}