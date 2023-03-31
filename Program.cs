using tabuleiro;
using xadrez;
using ProjetoXadrez;

Tabuleiro tabuleiro = new Tabuleiro(8, 8);

tabuleiro.ColocaPeca(new Torre(Cor.preta, tabuleiro), new Posicao(0, 0));
tabuleiro.ColocaPeca(new Torre(Cor.preta, tabuleiro), new Posicao(1, 3));
tabuleiro.ColocaPeca(new Rei(Cor.preta, tabuleiro), new Posicao(2, 4));

Tela.ImprimirTabuleiro(tabuleiro);