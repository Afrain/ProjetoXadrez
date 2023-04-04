using tabuleiro;
using xadrez;
using ProjetoXadrez;

try
{
    Tabuleiro tabuleiro = new Tabuleiro(8, 8);

    tabuleiro.ColocarPeca(new Torre(Cor.preta, tabuleiro), new Posicao(0, 0));
    tabuleiro.ColocarPeca(new Torre(Cor.preta, tabuleiro), new Posicao(1, 3));
    tabuleiro.ColocarPeca(new Rei(Cor.preta, tabuleiro), new Posicao(2, 4));

    Tela.ImprimirTabuleiro(tabuleiro);
}
catch (Exception ex)
{
    System.Console.WriteLine(ex.Message);
}

PosicaoXadrez posXadr = new PosicaoXadrez('a', 8);
System.Console.WriteLine(posXadr.toPosicao());