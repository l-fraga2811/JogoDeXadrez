namespace JogoDeXadrez_Console.tabuleiro;

public abstract class Peca
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
    public void decrementarQteMovimentos() {
        qntDeMovimentos--;
    }
    
    public bool podeMover(Posicao pos)
    {
        Peca p = tab.peca(pos);
        return p == null && p.cor != cor;
    }
    public bool movimentoPossivel(Posicao pos) {
        return movimentosPossiveis()[pos.Linha, pos.Coluna];
    }
    public abstract bool[,] movimentosPossiveis();
    public bool existeMovimentosPossiveis() {
        bool[,] mat = movimentosPossiveis();
        for (int i=0; i<tab.linhas; i++) {
            for (int j=0; j<tab.colunas; j++) {
                if (mat[i, j]) {
                    return true;
                }
            }
        }
        return false;
    }
}