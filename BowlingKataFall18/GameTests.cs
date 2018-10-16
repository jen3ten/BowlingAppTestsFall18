using System;
using Xunit;

namespace BowlingKataFall18
{
    public class GameTests
    {
        [Fact]
        public void Game_Exists()
        {
            var game = new Game();

            Assert.IsType<Game>(game);
        }

        [Fact]
        public void Score_Throws_An_Exception()
        {
            var game = new Game();

            Assert.Throws<GameNotFinishedException>(() =>
            {
                game.Score();
            });
        }

        //Now make the test smarter
        //If we roll 12 strikes, we expect to get a perfect score
        [Fact]
        public void Score_Returns_300_For_Perfect_Game()
        {
            var game = new Game();

            var strike = 10;
            for (int i = 1; i <= 12; i++)
            {
                game.Roll(strike);
            }

            var score = game.Score();

            Assert.Equal(300, score);
        }

        [Fact]
        public void Score_Throws_Exception_When_Scoring_After_One_Roll()
        {
            var game = new Game();

            game.Roll(10);

            Assert.Throws<GameNotFinishedException>(() =>
            {
                game.Score();
            });
        }

        [Fact]
        public void Score_Returns_0_For_10_Gutter_Balls()
        {
            var game = new Game();

            var gutter = 0;
            for (int i = 1; i <= 10; i++)
            {
                game.Roll(gutter);
            }

            var score = game.Score();

            Assert.Equal(0, score);
        }

        [Fact]
        public void Score_Returns_10_For_10_Single_Pin_Games()
        {
            var game = new Game();

            var pins = 1;
            for (int i = 1; i <= 10; i++)
            {
                game.Roll(pins);
            }

            var score = game.Score();

            Assert.Equal(10, score);
        }

    }
}
