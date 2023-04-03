using tabuleiro;

namespace ProjetoXadrez
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int linha = 0; linha < tabuleiro.LinhasTabuleiro; linha++)
            {
                for (int coluna = 0; coluna < tabuleiro.ColunasTabuleiro; coluna++)
                {
                    if (tabuleiro.RetornarUmaPeca(linha, coluna) == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        System.Console.Write(tabuleiro.RetornarUmaPeca(linha, coluna) + " ");
                    }

                }
                System.Console.WriteLine();
            }
        }
    }
}