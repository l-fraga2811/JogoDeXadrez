namespace JogoDeXadrez_Console.tabuleiro;

public class Tabuleiro
{
    public int linhas { get; set; }
    public int colunas { get; set; }
    private Peca[,] _pecas;

    //Implementando o tabuleiro
    public Tabuleiro(int linhas, int colunas)
    {
        this.linhas = linhas;
        this.colunas = colunas;
        _pecas = new Peca[linhas, colunas];
    }

    //Retornando um metodo private para poder imprimir o tabuleiro de acordo com as linhas  e colunas
    public Peca peca(int linhas, int colunas)
    {
        return _pecas[linhas, colunas];
    }

    //Faz o posicionamento de uma peça --> precisa fazer uma verificaçao depois 
    public void colocarPeca(Peca p, Posicao pos)
    {
        if (existePeca(pos))
        {
            throw new TabuleiroException("Já existe uma peça aí!");
        }
        _pecas[pos.Linha, pos.Coluna] = p;
        p.posicao = pos;
    }

    public Peca peca(Posicao pos) 
    {
        return _pecas[pos.Linha, pos.Coluna];
    }

    //Funcao para verificar se a peça nao está fora do tabuleiro
    public bool posValida(Posicao pos)
    {
        if (pos.Linha < 0 || pos.Linha > linhas || pos.Coluna < 0 || pos.Coluna > pos.Coluna)
        {
            return false;
        }
        return true;
    }

    //Verifica se a peça existe
    public bool existePeca (Posicao pos)
    {
        validarPos(pos);
        return peca(pos) != null;
    }

    //Se a posicao nao for valida joga uma Exception
    public void validarPos (Posicao pos)
    {
        if (!posValida(pos)){
            throw new TabuleiroException("Posiçao invalida!");
        }
    }
    //Funcao para retirar pecas
    public Peca retirarPeca(Posicao pos) 
    {
        if (peca(pos) == null)
        {
            return null;
        }
        Peca aux = peca(pos);
        aux.posicao = null;
        _pecas[pos.Linha, pos.Coluna] = null;
        return aux;
    }
}