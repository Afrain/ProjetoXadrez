using tabuleiro;

namespace ProjetoXadrez
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int linha = 0; linha < tabuleiro.LinhasTabuleiro; linha++)
            {
                System.Console.Write(8 - linha + " ");
                for (int coluna = 0; coluna < tabuleiro.ColunasTabuleiro; coluna++)
                {
                    if (tabuleiro.RetornarUmaPeca(linha, coluna) == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        imprimePeca(tabuleiro.RetornarUmaPeca(linha, coluna));
                        System.Console.Write(" ");
                    }

                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimePeca(Peca peca) 
        {
            if (peca.Cor == Cor.Branca)
            {
                System.Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}