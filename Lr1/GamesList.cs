using System;

namespace Lr1{
    public class GamesList{
        private Game firstGame;
        private Game lastGame;
        public GamesList(){
            firstGame = null;
            lastGame = null;
        }

        public void addToGameList(int gameId, int ratingAmount, string opponentName, string gameResult){
            Game game = new Game(gameId,ratingAmount,opponentName,gameResult);
            if(firstGame == null){
                firstGame = game;
            }
            else{
                if (lastGame == null){
                    lastGame = game;
                    firstGame.nextGame = lastGame;
                }
                else{
                    lastGame.nextGame = game;
                    lastGame = lastGame.nextGame;
                }
            }
        }

        public void printGameList(){
            Game curGame = firstGame;
            Console.WriteLine("Game history:");
            while(curGame != null){
                Console.WriteLine("|\t Opponent: "+curGame.OpponentName+" \t|\t Game result: "+curGame.GameResult+" \t|\t Game rating:"+curGame.RatingAmount+"  \t|\t Game ID:"+curGame.GameId+" \t|");
                curGame = curGame.nextGame;
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
            GameId = gameId;
            RatingAmount = ratingAmount;
            OpponentName = opponentName;
            GameResult = gameResult;
        }
    }
}