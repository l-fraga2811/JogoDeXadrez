using JogoDeXadrez_Console.tabuleiro;

namespace JogoDeXadrez_Console.PecasDeXadrez;

public class Bispo : Peca
{
    public Bispo(Tabuleiro tab, Cor cor) : base(cor, tab)
    {
        
    }

    public override string ToString()
    {
        return "B";
    }
}