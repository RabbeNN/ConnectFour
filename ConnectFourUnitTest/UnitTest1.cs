using ConnectFour;

namespace ConnectFourUnitTest
{
	public class UnitTest
	{
		[Fact]
		public void ChecksForWin_NoWinner_EmptyBoard()
		{
			GameState states = new GameState();
			//arrange
			var expected = GameState.WinState.No_Winner;

			//act
			var actual = states.CheckForWin();
            //assert
			Assert.Equal(expected, actual);
        }
		[Fact]
		public void CheckForWin_TieGame()
		{
			//arrange
			var gameState = new GameState();

			gameState.TheBoard = new List<int>
			{
				1,2,1,2,1,2,1,
				1,2,1,2,1,2,1,
				2,1,2,1,2,1,2,
				2,1,2,1,2,1,2,
				1,2,1,2,1,2,1,
				1,2,1,2,1,2,1,
			};

			//act
			var result = gameState.CheckForWin();

			//assert
			Assert.Equal(GameState.WinState.Tie, result);

		}
	}
}