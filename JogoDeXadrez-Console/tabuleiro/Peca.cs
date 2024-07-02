namespace JogoDeXadrez_Console.tabuleiro;

public class Peca
{
    public Posicao posicao { get; set; }
    public Cor cor { get; protected set; }
    public int qntDeMovimentos { get; protected set; }
    public Tabuleiro tab { get; protected set; }

    public Peca(Cor cor, Tabuleiro tab)
    {
        this.posicao = null;
        this.tab = tab;
        this.cor = cor;
        this.qntDeMovimentos = 0;
    }
    public void incrementarQuantidadeDeMovs()
    {
        qntDeMovimentos++;
    }
}