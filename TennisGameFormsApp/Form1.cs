using System.Security.Cryptography.X509Certificates;

namespace TennisGameFormsApp
{
	public partial class TennisMatch : Form
	{
		//Location variables
		//int direction = 5;
		int ballXCoordinate = 10;
		int ballYCoordinate = 10;
		

		//Score Variables
		int player1Score = 0;
		int player2Score = 0;

		//Size Variables
		int bottomBoundary;
		//int centerPoint;
		int xMidPoint;
		int yMidPoint;

		//Detection Variables
		bool player1DetectedUp = false;
		bool player2DetectedUp = false;
		bool player1DetectedDown = false;
		bool player2DetectedDown = false;

		//Special Keys
		int spaceBarClicked = 0;
		public TennisMatch()
		{
			InitializeComponent();
			bottomBoundary = ClientSize.Height - Player1.Height;
			xMidPoint = ClientSize.Width / 2;
			yMidPoint = ClientSize.Height / 2;
		}


		private void TennisMatch_Load(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			
			TennisBall.Top -=  ballYCoordinate;
			TennisBall.Left -= ballXCoordinate;
			Random newBallSpot = new Random();
			int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);


			//Check if ball left screen =>  player 2 scores
			if (TennisBall.Left < 0)
			{
				
				TennisBall.Left = xMidPoint;
				TennisBall.Top = newSpot;
				ballXCoordinate = -ballXCoordinate;
				player2Score++;

				string[] pointNames = {"0", "15", "30", "40" };
				ScorePlayer2Label.Text = pointNames[player2Score].ToString();

			}
			//Check if ball left right screen => player 1 scores
			if (TennisBall.Left + TennisBall.Width > ClientSize.Width)
			{

				TennisBall.Left = xMidPoint;
				TennisBall.Top = newSpot;
				ballXCoordinate = - ballXCoordinate;
				player1Score++;

				string[] pointNames = { "0","15", "30", "40" };
				ScorePlayer1Label.Text = pointNames[player1Score].ToString();
			}

			//Ensure the ball is in the boundaries of the screen
			if (TennisBall.Top < 0 || TennisBall.Top + TennisBall.Height > ClientSize.Height)
			{
				ballYCoordinate = - ballYCoordinate;
			}
			
			if(Player1.Top < 0 || Player1.Top + Player1.Height > ClientSize.Height)
			{
				Player1.Top = 0;
			}
			if (Player2.Top < 0 || Player2.Top + Player2.Height > ClientSize.Height)
			{
				Player2.Top = 0;
			}

			//Check if the ball hits a player
			if (TennisBall.Bounds.IntersectsWith(Player1.Bounds) || TennisBall.Bounds.IntersectsWith(Player2.Bounds))
			{
				ballXCoordinate = - ballXCoordinate;
				ballYCoordinate = -ballYCoordinate;
			}
			
			//Move player up
			if (player1DetectedUp == true && Player1.Top > 0)
			{
				Player1.Top -= 20;
			}
			if (player2DetectedUp == true && Player2.Top > 0)
			{
				Player2.Top -= 20;
			}

			//Move player down
			if (player1DetectedDown == true && Player1.Top < bottomBoundary)

			{
				Player1.Top += 20;
			}
			if (player2DetectedDown == true && Player2.Top < bottomBoundary)
			{
				Player2.Top += 20;
			}

			if (player1Score >= 3 || player2Score >= 3)
			{
				MatchTimer.Stop();
			}
		}

		private void TennisMatch_KeyDown(object sender, KeyEventArgs e)
		{
			//If player presses key player move 

			switch (e.KeyCode)
			{
				case Keys.Up:
					player2DetectedUp = true;
					break;

				case Keys.W:
					player1DetectedUp = true;
					break;

				case Keys.Down:
					player2DetectedDown = true;
					break;

				case Keys.S:
					player1DetectedDown = true;
					break;
			}

			
			//If player presses spacebar, pause the game
			if(e.KeyCode== Keys.Space)
			{
				if(spaceBarClicked % 2 == 0)
				{
					MatchTimer.Stop();
				}
				else
				{
					MatchTimer.Start();
				}

			}
			spaceBarClicked++;
		}

		private void TennisMatch_KeyUp(object sender, KeyEventArgs e)
		{

			switch (e.KeyCode)
			{
				case Keys.Up:
					player2DetectedUp = false;
					break;

				case Keys.W:
					player1DetectedUp = false;
					break;

				case Keys.Down:
					player2DetectedDown = false;
					break;

				case Keys.S:
					player1DetectedDown = false;
					break;
			}
		}
	}
}
