using SimpleTennisGame.Entities;
using SimpleTennisGame.Models;
using SimpleTennisGame.ViewModels;
using System;
using System.ComponentModel.Design;




ScoreModel score = new ScoreModel(new PlayerEntity
{
	Player1Name = null!,
	Player2Name = null!,
});


InterfaceViewModel gameStarting = new InterfaceViewModel(score, new ScoreEntity
{
	Player1Score = 0,
	Player2Score = 0,
	ScoreNames = new string[] { "Love", "15", "30", "40"}
});

gameStarting.MenuService();




