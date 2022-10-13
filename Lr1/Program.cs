using System;

namespace Lr1{
    internal class Program
    {
        public static void Main(string[] args){
            GameAccount tilt = new GameAccount("tilt");
            GameAccount Oleja = new GameAccount("Oleja");
            GameAccount bober = new GameAccount("bober");
            GameAccount kirgo = new GameAccount("kirgo");
            GameAccount chokopie = new GameAccount("chokopie");
            Oleja.WinGame(bober);
            Oleja.LoseGame(tilt);
            Oleja.WinGame(bober);
            kirgo.WinGame(bober);
            kirgo.LoseGame(tilt);
            kirgo.LoseGame(chokopie);
            kirgo.WinGame(bober);
            chokopie.LoseGame(tilt);
            Oleja.GetStats();
            kirgo.GetStats();
            bober.GetStats();
            tilt.GetStats();
        }
    }
}