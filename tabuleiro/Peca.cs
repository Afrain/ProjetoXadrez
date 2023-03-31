namespace tabuleiro
{
    public class Peca
    {
        public int QuantidadeMovimentos { get; protected set; }
        public Posicao Posicao { get; set; }      
        public Cor Cor { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }    

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QuantidadeMovimentos = 0;
        }
    }
}