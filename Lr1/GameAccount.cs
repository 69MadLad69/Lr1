using System;

namespace Lr1{
    public class GameAccount{
        private string UserName;
        private int CurrentRating = 1;
        private int GamesCount = 0;
        public static Random randID = new Random();
        private int Id = randID.Next();
        public static Random randRating = new Random();
        public GamesList gamesList = new GamesList();
        public GameAccount(string userName){
            UserName = userName;
        }
        
        public void WinGame(GameAccount Opponent){
            int RatingAmount = randRating.Next(35);
            CurrentRating += RatingAmount;
            GamesCount++;
            int GameID = Id + 1;
            Id = GameID;
            gamesList.addToGameList(GameID,RatingAmount,Opponent.UserName,"Win");
            if(Opponent.CurrentRating - RatingAmount < 1){
                Opponent.CurrentRating = 1;
            }
            else{
                Opponent.CurrentRating -= RatingAmount;
            }
            Opponent.GamesCount++;
            Opponent.gamesList.addToGameList(GameID,RatingAmount,UserName,"Lose");
        }

        public void LoseGame(GameAccount Opponent){
            int RatingAmount = randRating.Next(35);
            CurrentRating -= RatingAmount;
            if (CurrentRating < 1){
                CurrentRating = 1;
            }
            GamesCount++;
            int GameID = Id + 1;
            Id = GameID;
            gamesList.addToGameList(GameID,RatingAmount,Opponent.UserName,"Lose");
            Opponent.CurrentRating += RatingAmount;
            Opponent.GamesCount++;
            Opponent.gamesList.addToGameList(GameID,RatingAmount,UserName,"Win");
        }

        public void GetStats(){
            Console.WriteLine();
            Console.WriteLine(UserName+" stats:");
            Console.WriteLine("| Current rating: "+CurrentRating+" | Games played: "+GamesCount+" |");
            Console.WriteLine();
            gamesList.printGameList();
        }
    }
}