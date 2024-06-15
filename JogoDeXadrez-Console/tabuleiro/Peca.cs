﻿namespace JogoDeXadrez_Console.tabuleiro;

public class Peca
{
    public Posicao posicao { get; set; }
    public Cor cor { get; protected set; }
    public int qntDeMovimentos { get; protected set; }
    public Tabuleiro tab { get; protected set; }

    public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
    {
        this.posicao = posicao;
        this.tab = tab;
        this.cor = cor;
        this.qntDeMovimentos = 0;
    }
}