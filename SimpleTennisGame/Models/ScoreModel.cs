using SimpleTennisGame.Entities;

namespace SimpleTennisGame.Models;

public class ScoreModel(PlayerEntity player)
{
	
	private readonly PlayerEntity _player = player;
	ScoreEntity _score = new ScoreEntity();

	public ScoreEntity GetScore(string playerScored, string player1, string player2)
	{

		try
		{



			if (playerScored != null)
			{

				if (playerScored == player1)
				{

					_score.Player1Score++; // poäng till spelare 1
				}
				if (playerScored == player2)
				{
					_score.Player2Score++; // poäng till spelare 1
				}
				else if (playerScored != player1 && playerScored!= player2)
				{
					Console.WriteLine("Could not find player, try again!");
				}
					

			}
			


			return (_score);

		}
		catch 
		{
			return null!;
		}
	}
}
