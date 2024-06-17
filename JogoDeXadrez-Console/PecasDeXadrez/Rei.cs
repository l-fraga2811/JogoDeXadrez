using JogoDeXadrez_Console.tabuleiro;

namespace JogoDeXadrez_Console.PecasDeXadrez;

public class Rei : Peca
{
    public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
    {
        
    }

    public override string ToString()
    {
        return "R";
    }
}