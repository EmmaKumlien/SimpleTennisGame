namespace TennisGameFormsApp
{
	partial class TennisMatch
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TennisMatch));
			Player2 = new PictureBox();
			Player1 = new PictureBox();
			TennisBall = new PictureBox();
			ScoreLabel = new Label();
			ScorePlayer2Label = new Label();
			ScorePlayer1Label = new Label();
			MatchTimer = new System.Windows.Forms.Timer(components);
			((System.ComponentModel.ISupportInitialize)Player2).BeginInit();
			((System.ComponentModel.ISupportInitialize)Player1).BeginInit();
			((System.ComponentModel.ISupportInitialize)TennisBall).BeginInit();
			SuspendLayout();
			// 
			// Player2
			// 
			Player2.BackColor = Color.Transparent;
			Player2.BackgroundImage = (Image)resources.GetObject("Player2.BackgroundImage");
			Player2.BackgroundImageLayout = ImageLayout.Stretch;
			Player2.Location = new Point(702, 172);
			Player2.Name = "Player2";
			Player2.Size = new Size(63, 68);
			Player2.TabIndex = 0;
			Player2.TabStop = false;
			// 
			// Player1
			// 
			Player1.BackColor = Color.Transparent;
			Player1.BackgroundImage = (Image)resources.GetObject("Player1.BackgroundImage");
			Player1.BackgroundImageLayout = ImageLayout.Stretch;
			Player1.Location = new Point(38, 172);
			Player1.Name = "Player1";
			Player1.Size = new Size(69, 68);
			Player1.TabIndex = 1;
			Player1.TabStop = false;
			// 
			// TennisBall
			// 
			TennisBall.BackColor = Color.Transparent;
			TennisBall.BackgroundImage = (Image)resources.GetObject("TennisBall.BackgroundImage");
			TennisBall.BackgroundImageLayout = ImageLayout.Stretch;
			TennisBall.Location = new Point(384, 212);
			TennisBall.Name = "TennisBall";
			TennisBall.Size = new Size(28, 28);
			TennisBall.TabIndex = 2;
			TennisBall.TabStop = false;
			// 
			// ScoreLabel
			// 
			ScoreLabel.AutoSize = true;
			ScoreLabel.BackColor = Color.Transparent;
			ScoreLabel.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ScoreLabel.Location = new Point(337, 20);
			ScoreLabel.Name = "ScoreLabel";
			ScoreLabel.Size = new Size(123, 43);
			ScoreLabel.TabIndex = 3;
			ScoreLabel.Text = "Score";
			// 
			// ScorePlayer2Label
			// 
			ScorePlayer2Label.BackColor = Color.Transparent;
			ScorePlayer2Label.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ScorePlayer2Label.ForeColor = Color.Gold;
			ScorePlayer2Label.Location = new Point(531, 28);
			ScorePlayer2Label.Name = "ScorePlayer2Label";
			ScorePlayer2Label.Size = new Size(116, 50);
			ScorePlayer2Label.TabIndex = 4;
			ScorePlayer2Label.Text = "0";
			ScorePlayer2Label.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// ScorePlayer1Label
			// 
			ScorePlayer1Label.BackColor = Color.Transparent;
			ScorePlayer1Label.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ScorePlayer1Label.ForeColor = Color.Gold;
			ScorePlayer1Label.Location = new Point(166, 28);
			ScorePlayer1Label.Name = "ScorePlayer1Label";
			ScorePlayer1Label.Size = new Size(106, 50);
			ScorePlayer1Label.TabIndex = 5;
			ScorePlayer1Label.Text = "0";
			ScorePlayer1Label.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// MatchTimer
			// 
			MatchTimer.Enabled = true;
			MatchTimer.Interval = 10;
			MatchTimer.Tick += timer1_Tick;
			// 
			// TennisMatch
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.IndianRed;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Zoom;
			ClientSize = new Size(800, 450);
			Controls.Add(Player2);
			Controls.Add(Player1);
			Controls.Add(TennisBall);
			Controls.Add(ScoreLabel);
			Controls.Add(ScorePlayer2Label);
			Controls.Add(ScorePlayer1Label);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximumSize = new Size(818, 497);
			MinimumSize = new Size(818, 497);
			Name = "TennisMatch";
			Text = "TennisMatch";
			Load += TennisMatch_Load;
			KeyDown += TennisMatch_KeyDown;
			KeyUp += TennisMatch_KeyUp;
			((System.ComponentModel.ISupportInitialize)Player2).EndInit();
			((System.ComponentModel.ISupportInitialize)Player1).EndInit();
			((System.ComponentModel.ISupportInitialize)TennisBall).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox Player2;
		private PictureBox Player1;
		private PictureBox TennisBall;
		private Label ScoreLabel;
		private Label ScorePlayer2Label;
		private Label ScorePlayer1Label;
		private System.Windows.Forms.Timer MatchTimer;
	}
}
