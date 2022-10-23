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
            Oleja.decideGameResult(bober,"W");
            kirgo.decideGameResult(bober,"W");
            tilt.decideGameResult(Oleja,"W");
            kirgo.decideGameResult(tilt,"L");
            chokopie.decideGameResult(tilt,"L");
            chokopie.decideGameResult(Oleja,"W");
            chokopie.decideGameResult(bober,"W");
            Oleja.GetStats();
            kirgo.GetStats();
            bober.GetStats();
            tilt.GetStats();
        }
    }
}