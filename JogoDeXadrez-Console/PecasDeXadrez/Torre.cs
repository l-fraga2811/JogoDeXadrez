using JogoDeXadrez_Console.tabuleiro;

namespace JogoDeXadrez_Console.PecasDeXadrez;

public class Torre : Peca
{
    public Torre(Tabuleiro tab, Cor cor) : base(cor, tab)
    {
        
    }

    public override string ToString()
    {
        return "T";
    }
}