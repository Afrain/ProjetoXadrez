using tabuleiro.Exceptions;

namespace tabuleiro
{
    public class Tabuleiro
    {
        public int LinhasTabuleiro { get; set; }
        public int ColunasTabuleiro { get; set; }
        public Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            LinhasTabuleiro = linhas;
            ColunasTabuleiro = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca RetornarUmaPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca RetornarUmaPeca(Posicao posicao)
        {
            return Pecas[posicao.Linha, posicao.Coluna];
        }

        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return RetornarUmaPeca(posicao) != null;
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.Linha < 0 || posicao.Linha > LinhasTabuleiro ||
                posicao.Coluna < 0 || posicao.Coluna > ColunasTabuleiro)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao posicao) 
        {
            if (!PosicaoValida(posicao))
            {
                throw new TabuleiroException("Posicão inválida!");
            }
        }
    }
}