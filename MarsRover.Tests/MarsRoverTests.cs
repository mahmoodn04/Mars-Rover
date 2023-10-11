using System;
using Xunit;

namespace MarsRover.Tests
{

    public class MarsRoverTest
    {
        private List<Tuple<int, int>> obstacle;
        private Grid grid;

        public MarsRoverTest()
        {
            obstacle = new List<Tuple<int, int>>();
           
            
            grid = new Grid(0, 0, 10, 10, obstacle);
        }
        [Fact]
        public void ShouldGivePositionOfTheStartOnMars0_0_N()
        {
            // Given
            MarsRover marsRover = new MarsRover(grid);

            // When
            marsRover.move("");
            // Then
            Assert.Equal("0:0:N", marsRover.position());
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveToNorthOneTime0_1_N()
        {
            // Given
            MarsRover marsRover = new MarsRover(grid);
            // When
            marsRover.move("M");
            // Then
            Assert.Equal("0:1:N", marsRover.position());
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveToNorthTwoTimes0_2_N()
        {
            // Given
            MarsRover marsRover = new MarsRover(grid);
            // When
            marsRover.move("MM");
            // Then
            Assert.Equal("0:2:N", marsRover.position());
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveToNorthTwoTimesMinus2_0_W()
        {
            // Given
            MarsRover marsRover = new MarsRover(grid);
            // When
            marsRover.move("LMM");
            // Then
            Assert.Equal("-2:0:W", marsRover.position());
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveToNorthTwoTimes2_0_E()
        {
            // Given
            MarsRover marsRover = new MarsRover(grid);
            // When
            marsRover.move("RMM");
            // Then
            Assert.Equal("2:0:E", marsRover.position());
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveToNorthTwoTimes0_minus2_S()
        {
            // Given
            MarsRover marsRover = new MarsRover(grid);
            // When
            marsRover.move("LLMM");
            // Then
            Assert.Equal("0:-2:S", marsRover.position());
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveMMRMMLM2_3_N()
        {
            // Given
            MarsRover marsRover = new MarsRover(grid);
            // When
            marsRover.move("MMRMMLM");
            // Then
            Assert.Equal("2:3:N", marsRover.position());
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveLLLM1_0_E()
        {
            // Given
            MarsRover marsRover = new MarsRover(grid);
            // When
            marsRover.move("LLLM");
            // Then
            Assert.Equal("1:0:E", marsRover.position());
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveRRM00_minus1_S()
        {
            // Given
            MarsRover marsRover = new MarsRover(grid);
            // When
            marsRover.move("RRM");
            // Then
            Assert.Equal("0:-1:S", marsRover.position());
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveRRRMminus1_0_W()
        {
            // Given
            MarsRover marsRover = new MarsRover(grid);
            // When
            marsRover.move("RRRM");
            // Then
            Assert.Equal("-1:0:W", marsRover.position());
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveRRRRM0_1_N()
        {
            // Given
            MarsRover marsRover = new MarsRover(grid);
            // When
            marsRover.move("RRRRM");
            // Then
            Assert.Equal("0:1:N", marsRover.position());
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveRMMMMMMMMMMM0_1_N()
        {
            // Given
            MarsRover marsRover = new MarsRover(grid);
            // When
            marsRover.move("RMMMMMMMMMMM");
            // Then
            Assert.Equal("1:0:E", marsRover.position());
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveWithAnObstacle0_2_N()
        {
            // Given
            obstacle.Add(new Tuple<int, int>(0, 3));
            Grid grid1 = new Grid(0, 0, 10, 10, obstacle);
            MarsRover marsRover = new MarsRover(grid1);
            // When
            marsRover.move("MMMMM");
            // Then
            Assert.Equal("0:2:N", marsRover.position());
        }
        [Fact]
        public void ShouldGivePositionWhenMarsMoveWithAnObstacle0_1_W()
        {
            // Given
            obstacle.Add(new Tuple<int, int>(1, 2));
            obstacle.Add(new Tuple<int, int>(2, 1));
            Grid grid2 = new Grid(0, 0, 10, 10, obstacle);
            MarsRover marsRover = new MarsRover(grid2);

            // When
            marsRover.move("RMMLMLMRMMLM");
            // Then
            Assert.Equal("0:1:W", marsRover.position());
        }

    }
}