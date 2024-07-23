using JogoDeXadrez_Console.tabuleiro;

namespace JogoDeXadrez_Console;

public class Tela
{
    public static void imprimirTabuleiro(Tabuleiro tab)
    {
        for (int i = 0; i < tab.linhas; i++)
        {
            
            for (int j = 0; j < tab.colunas; j++)
            {
                if (tab.peca(i, j) == null)
                {
                    Console.Write("- ");
                }
                else
                {
                    imprimirPeca(tab.peca(i, j));
                    Console.Write(" ");
                }
            }
            System.Console.WriteLine(8 - i + " ");
        }
        System.Console.WriteLine("A B C D E F G H");
    }
    public static void imprimirPeca(Peca peca)
    {
        if(peca.cor == Cor.Branca)
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(peca);
            Console.ForegroundColor = aux;
        }else
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(peca);
            Console.ForegroundColor = aux;
        }
       
    } 
    public static PosicoesXadrez lerPosicaoXadrez() {
        string s = Console.ReadLine();
        char coluna = s[0];
        int linha = int.Parse(s[1] + "");
        return new PosicoesXadrez(coluna, linha);
    }
}