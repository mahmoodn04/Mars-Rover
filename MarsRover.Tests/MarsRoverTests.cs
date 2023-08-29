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
        [Fact]
        public void ShouldGivePositionWhenMarsMoveToNorthOneTime0_1_N()
        {
            // Given
            MarsRover marsRover = new MarsRover();
            // When
            marsRover.move("M");
            // Then
            Assert.Equal(marsRover.position(), "0:1:N");
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveToNorthTwoTimes0_2_N()
        {
            // Given
            MarsRover marsRover = new MarsRover();
            // When
            marsRover.move("MM");
            // Then
            Assert.Equal(marsRover.position(), "0:2:N");
        }

    }
}