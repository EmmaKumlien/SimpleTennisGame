using SimpleTennisGame.Entities;
using SimpleTennisGame.Models;


namespace SimpleTennisGame.ViewModels;

public class InterfaceViewModel(ScoreModel scoreModel, ScoreEntity entity)
{
	private readonly ScoreModel _scoreModel = scoreModel;
	private readonly ScoreEntity _scoreEntity = entity;

	
	PlayerEntity _playerEntity = new PlayerEntity();
	ScoreEntity _entity = new ScoreEntity();

	public void MenuService()
	{
		Console.WriteLine("#Welcome to a match of tennis#");
		Console.Write("Write the name of player 1:");
		_playerEntity.Player1Name = Console.ReadLine()!;
		Console.Write("Write the name of player 2:");
		_playerEntity.Player2Name = Console.ReadLine()!;
		


		while (_entity.Player1Score <4 && _entity.Player2Score <4)
		{
			Console.WriteLine("Who Scored");
			var result = Console.ReadLine(); 
											 
			var Scores = _scoreModel.GetScore(result!, _playerEntity.Player1Name, _playerEntity.Player2Name); //Skickar vidare resultatet

			if (Scores != null)
			{
				
				var scorePlayer1 = Scores.Player1Score;
				var scorePlayer2 = Scores.Player2Score;

				var Player1ScoreName = _scoreEntity.ScoreNames[scorePlayer1];
				var Player2ScoreName = _scoreEntity.ScoreNames[scorePlayer2];

				
				if (Scores.Player1Score <= 3 && Scores.Player2Score <= 3)
					Console.WriteLine($"{Player1ScoreName} - {Player2ScoreName}");

				if (Scores.Player1Score == 3 && Scores.Player2Score== 3)
				{
					Console.WriteLine("Deuce");

					
				}
				if (Scores.Player1Score == 4 || Scores.Player2Score == 4)
				{
					Console.WriteLine("Advantage");

					if (_entity.Player1Score > _entity.Player2Score)
					{
						Console.WriteLine($"Winner is: {_playerEntity.Player1Name}");
					}
					if (_entity.Player2Score > _entity.Player1Score)
					{
						Console.WriteLine($"Winner is: {_playerEntity.Player2Name}");
					}
					Console.WriteLine("##Game over##");

				}


				


			}
			else
			{
				Console.WriteLine("Something went wrong, try again!");
			}

			_entity = Scores!; // Uppdaterar värdet 

		}

		



		
		
	}
}
