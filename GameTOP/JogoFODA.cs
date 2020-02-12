using System;
using GameTOP.Lib;
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFoda
{
    public readonly iJogador _jogadorA;
    public readonly iJogador _jogadorB;

    public JogoFoda(iJogador jogadorA, iJogador jogadorB)
    {
        _jogadorA = jogadorA;
        _jogadorB = jogadorB;
    }
    public void IniciarJogo()
    {
        Console.Write(_jogadorA.Chuta());
        Console.Write(_jogadorA.Corre());
        Console.Write(_jogadorA.Passe());

     Console.Write("Proximo Jogador \n");

        Console.Write(_jogadorB.Chuta());
        Console.Write(_jogadorB.Corre());
        Console.Write(_jogadorB.Passe());
    }
}

}