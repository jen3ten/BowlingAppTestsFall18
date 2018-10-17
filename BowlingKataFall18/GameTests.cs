using System;
using Xunit;

namespace BowlingKataFall18
{
    public class GameTests
    {
        //Setup for all tests
        private Game game;

        public GameTests()
        {
            game = new Game();
        }

        //[Fact]
        //public void Create_A_Game() //#1
        //{
        //    //This test really doesn't do much and passes automatically
        //    //It did have a compile error before Game class was created
        //    //After test 2 this test is no longer needed and can be removed
        //    new Game();
        //}

        [Fact]
        public void Roll_Accepts_Number_Of_Pins() //#2
        {
            //This test also does not have an Assert
            //It was needed to create a Roll method that accepts a parameter
            var game = new Game();

            game.Roll(10);
        }

        [Fact]
        public void Game_Exists() //This is leftover from first coding draft, previously test #1
        {
            var game = new Game();

            Assert.IsType<Game>(game);
        }

        //[Fact]
        //public void Score_Throws_An_Exception() //This is leftover from first coding draft
        //{
        //    var game = new Game();

        //    Assert.Throws<GameNotFinishedException>(() =>
        //    {
        //        game.Score();
        //    });
        //}

        //Now make the test smarter
        //If we roll 12 strikes, we expect to get a perfect score
        //[Fact]
        //public void Score_Returns_300_For_Perfect_Game()
        //{
        //    var game = new Game();

        //    var strike = 10;
        //    for (int i = 1; i <= 12; i++)
        //    {
        //        game.Roll(strike);
        //    }

        //    var score = game.Score();

        //    Assert.Equal(300, score);
        //}

        //[Fact]
        //public void Score_Throws_Exception_When_Scoring_After_One_Roll()
        //{
        //    var game = new Game();

        //    game.Roll(10);

        //    Assert.Throws<GameNotFinishedException>(() =>
        //    {
        //        game.Score();
        //    });
        //}

        [Fact]
        public void Score_Returns_0_For_20_Gutter_Balls() //#3
        {
            //0 pins knocked down after 20 rolls should have a score of 0
            var game = new Game();

            //for (int rolls = 1; rolls <= 20; rolls++) //this is telling me how its doing something, not what; we want something more abstract
            //{
            //    var pinsKnockedDown = 0; //number of pins knocked down, give it a logical name
            //    game.Roll(pinsKnockedDown);
            //}
            //^^ this was refactored
            Roll(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            var score = game.Score();

            Assert.Equal(0, score);
        }

        //Generic Roll method used in multiple tests
        private void Roll(int numberOfRolls, int pinsPerRoll)
        {
            for (int rolls = 1; rolls <= numberOfRolls; rolls++) //this is telling me how its doing something, not what; we want something more abstract
            {
                game.Roll(pinsPerRoll);
            }

        }

        //Overloaded Roll method
        private void Roll(params int[] rolls) //params lets you pass some number of integers and they will be put into an array of ints
        {
            foreach(var pinsPerRoll in rolls)
            {
                game.Roll(pinsPerRoll);
            }
        }

        [Fact]
        public void Score_Returns_20_For_20_Single_Pin_Rolls() //#4
        {
            //We started very specific (score of 0 for all gutter balls), to something more generic
            //1,1  1,1  1,1  1,1  1,1  1,1  1,1  1,1  1,1  1,1 = 20
            //The Roll method has been refactored, we need to pass 20 different rolls into the Roll method
            //Roll(20, 1); 
            Roll(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);

            var score = game.Score();

            Assert.Equal(20, score);
        }

        [Fact]
        public void Score_Returns_12_for_Single_Spare_Followed_By_Single_Pin() //#5
        {
            //7,3  1,0  0,0  0,0  0,0  0,0  0,0  0,0  0,0  0,0 = 12
            //Is it time to refactor?  Yes, look back and rework test #4
        }

    }
}
