//POR FILIPE STEFFAN E VITOR PINHEIRO

using System;

Random ronaldinho = new();
int vitória = 0;
int empate = 0;
int derrota = 0;
while (true)
{
    Console.Clear();
    Console.WriteLine("PEDRA, PAPEL, TESOURA... VAI!");
    Console.WriteLine();
GetInput:
    Console.WriteLine("Escolha:");
    Console.WriteLine("<P> para pedra");
    Console.WriteLine("<A> para papel");
    Console.WriteLine("<T> para tesoura");
    Console.WriteLine("<S> para sair");
    Move jogador;
    switch (Console.ReadLine()!.ToLower())
    {
        case "pedra" or "p": jogador = Move.pedra; break;
        case "papel" or "a": jogador = Move.papel; break;
        case "tesoura" or "t": jogador = Move.tesoura; break;
        case "sair" or "s": Console.Clear(); return;
        default: Console.WriteLine("Comando errado, tente novamente..."); goto GetInput;
    }
    Move computador = (Move)ronaldinho.Next(3);
    Console.WriteLine($"O computador escolheu {computador}.");
    switch (jogador, computador)
    {
        case (Move.pedra, Move.papel):
        case (Move.papel, Move.tesoura):
        case (Move.tesoura, Move.pedra):
            Console.WriteLine("Você perdeu.");
            Console.WriteLine();
            derrota++;
            break;
        case (Move.pedra, Move.tesoura):
        case (Move.papel, Move.pedra):
        case (Move.tesoura, Move.papel):
            Console.WriteLine("Você ganhou.");
            Console.WriteLine();
            vitória++;
            break;
        default:
            Console.WriteLine("Empate!");
            Console.WriteLine();
            empate++;
            break;
    }
    Console.WriteLine($"Placar: {vitória} vitórias, {derrota} derrotas, {empate} empates");
    Console.WriteLine($"Pressione <enter> para continuar...");
    Console.ReadLine();
}

enum Move
{
    pedra = 0,
    papel = 1,
    tesoura = 2,
}