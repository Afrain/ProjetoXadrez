using tabuleiro;

namespace ProjetoXadrez
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int linha = 0; linha < tabuleiro.Linhas; linha++)
            {
                for (int coluna = 0; coluna < tabuleiro.Colunas; coluna++)
                {
                    if (tabuleiro.RetornaUmaPeca(linha, coluna) == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        System.Console.Write(tabuleiro.RetornaUmaPeca(linha, coluna) + " ");
                    }

                }
                System.Console.WriteLine();
            }
        }
    }
}