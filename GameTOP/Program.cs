using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var jogofoda = new JogoFoda(
                new Jogador1("Ronaldo"), 
                new Jogador2("Maradora"));
            jogofoda.IniciarJogo();
            
             
            
        }
    }

}

