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
            MarsRover marsRover = new MarsRover(0, 0, 10, 10);
            // When
            marsRover.move("");
            // Then
            Assert.Equal(marsRover.position(), "0:0:N");
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveToNorthOneTime0_1_N()
        {
            // Given
            MarsRover marsRover = new MarsRover(0, 0, 10, 10);
            // When
            marsRover.move("M");
            // Then
            Assert.Equal(marsRover.position(), "0:1:N");
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveToNorthTwoTimes0_2_N()
        {
            // Given
            MarsRover marsRover = new MarsRover(0, 0, 10, 10);
            // When
            marsRover.move("MM");
            // Then
            Assert.Equal(marsRover.position(), "0:2:N");
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveToNorthTwoTimesMinus2_0_W()
        {
            // Given
            MarsRover marsRover = new MarsRover(0, 0, 10, 10);
            // When
            marsRover.move("LMM");
            // Then
            Assert.Equal(marsRover.position(), "-2:0:W");
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveToNorthTwoTimes2_0_E()
        {
            // Given
            MarsRover marsRover = new MarsRover(0, 0, 10, 10);
            // When
            marsRover.move("RMM");
            // Then
            Assert.Equal(marsRover.position(), "2:0:E");
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveToNorthTwoTimes0_minus2_S()
        {
            // Given
            MarsRover marsRover = new MarsRover(0, 0, 10, 10);
            // When
            marsRover.move("LLMM");
            // Then
            Assert.Equal(marsRover.position(), "0:-2:S");
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveMMRMMLM2_3_N()
        {
            // Given
            MarsRover marsRover = new MarsRover(0, 0, 10, 10);
            // When
            marsRover.move("MMRMMLM");
            // Then
            Assert.Equal(marsRover.position(), "2:3:N");
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveLLLM1_0_E()
        {
            // Given
            MarsRover marsRover = new MarsRover(0, 0, 10, 10);
            // When
            marsRover.move("LLLM");
            // Then
            Assert.Equal(marsRover.position(), "1:0:E");
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveRRM00_minus1_S()
        {
            // Given
            MarsRover marsRover = new MarsRover(0, 0, 10, 10);
            // When
            marsRover.move("RRM");
            // Then
            Assert.Equal(marsRover.position(), "0:-1:S");
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveRRRMminus1_0_W()
        {
            // Given
            MarsRover marsRover = new MarsRover(0, 0, 10, 10);
            // When
            marsRover.move("RRRM");
            // Then
            Assert.Equal(marsRover.position(), "-1:0:W");
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveRRRRM0_1_N()
        {
            // Given
            MarsRover marsRover = new MarsRover(0, 0, 10, 10);
            // When
            marsRover.move("RRRRM");
            // Then
            Assert.Equal(marsRover.position(), "0:1:N");
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveRMMMMMMMMMMM0_1_N()
        {
            // Given
            MarsRover marsRover = new MarsRover(0, 0, 10, 10);
            // When
            marsRover.move("RMMMMMMMMMMM");
            // Then
            Assert.Equal(marsRover.position(), "1:0:E");
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveWithAnObstacle0_2_N()
        {
            // Given
            MarsRover marsRover = new MarsRover(0, 0, 10, 10);
            // When
            marsRover.move("MMM");
            // Then
            Assert.Equal("0:2:N", marsRover.position());
        }

    }
}