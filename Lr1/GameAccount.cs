using System;
using System.Collections.Generic;

namespace Lr1{
    public class GameAccount{
        private string UserName;
        private int CurrentRating = 1;
        private int GamesCount = 0;
        public static Random randID = new Random();
        private int gameID = randID.Next();
        public static Random randRating = new Random();
        public List<Game> gameList = new List<Game>();
        public GameAccount(string userName){
            UserName = userName;
        }

        public void decideGameResult(GameAccount Opponent,String GameResult){
            int RatingAmount = randRating.Next(35);
            int ID = gameID+GamesCount;
            if (GameResult == "Win" || GameResult == "W"){
                WinGame(RatingAmount);
                Opponent.LoseGame(RatingAmount);
                Game winGame = new Game(ID, RatingAmount, Opponent.UserName, "Win");
                Game loseGame = new Game(ID, RatingAmount, UserName, "Lose");
                gameList.Add(winGame);
                Opponent.gameList.Add(loseGame);
            }else{
                if (GameResult == "Lose" || GameResult == "L"){
                    LoseGame(RatingAmount);
                    Opponent.WinGame(RatingAmount);
                    Game loseGame = new Game(ID, RatingAmount, Opponent.UserName, "Lose");
                    Game winGame = new Game(ID, RatingAmount, UserName, "Win");
                    gameList.Add(loseGame);
                    Opponent.gameList.Add(winGame);
                }
                else{
                    Console.WriteLine("Error! Помилка при вирішенні результату гри!");
                }
            }
        }

        public void WinGame(int RatingAmount){
            GamesCount++;
            CurrentRating += RatingAmount;
        }

        public void LoseGame(int RatingAmount){
            CurrentRating -= RatingAmount;
            if (CurrentRating < 1){
                CurrentRating = 1;
            }
            GamesCount++;
        }

        public void GetStats(){
            Console.WriteLine();
            Console.WriteLine(UserName+" stats:");
            Console.WriteLine("| Current rating: "+CurrentRating+" | Games played: "+GamesCount+" |");
            Console.WriteLine();
            foreach (var Game in gameList){
                Console.WriteLine("|\t Opponent: "+Game.OpponentName+" \t|\t Game result: "+Game.GameResult+" \t|\t Game rating:"+Game.RatingAmount+"  \t|\t Game ID:"+Game.GameId+" \t|");
            }
        }
    }
    public class Game{
        public Game nextGame;
        public int GameId;
        public int RatingAmount;
        public string OpponentName;
        public string GameResult;

        public Game(int gameId, int ratingAmount, string opponentName, string gameResult){
            GameId = gameId+1;
            RatingAmount = ratingAmount;
            OpponentName = opponentName;
            GameResult = gameResult;
        }
    }
}