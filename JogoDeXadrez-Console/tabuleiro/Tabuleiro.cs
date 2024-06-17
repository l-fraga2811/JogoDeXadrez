namespace JogoDeXadrez_Console.tabuleiro;

public class Tabuleiro
{
    public int linhas { get; set; }
    public int colunas { get; set; }
    private Peca[,] _pecas;

    //implementando o construtor
    public Tabuleiro(int linhas, int colunas)
    {
        this.linhas = linhas;
        this.colunas = colunas;
        _pecas = new Peca[linhas, colunas];
    }

    //retornando um metodo private para poder imprimir o tabuleiro de acordo com as linhas  e colunas
    public Peca peca(int linhas, int colunas)
    {
        return _pecas[linhas, colunas];
    }

    public void colocarPeca(Peca p, Posicao pos)
    {
        _pecas[pos.Linha, pos.Coluna] = p;
        p.posicao = pos;
    }
}