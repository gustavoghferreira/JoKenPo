namespace JoKenPo
{
    public partial class FormClassico : Form
    {
        public FormClassico()
        {
            InitializeComponent();
        }

        private void buttonPapel_Click(object sender, EventArgs e)
        {
            startGame(0);
        }

        private void buttonPedra_Click(object sender, EventArgs e)
        {
            startGame(1);
        }
       
        private void buttonTesoura_Click(object sender, EventArgs e)
        {
            startGame(2);
        }

        private void startGame(int opcao)
        {
            labelJogador.Visible = false;
            labelPC.Visible = false;
            labelResultado.Visible = false;            

            Game jogo = new Game();
            string modo = "classico";

            switch (jogo.jogar(opcao, modo))
            {
                case Game.Resultado.Empatar:
                    pictureResultado.BackgroundImage = Image.FromFile("images/empatou.png");
                    goto default;
                case Game.Resultado.Ganhar:
                    pictureResultado.BackgroundImage = Image.FromFile("images/ganhou.png");
                    goto default;
                case Game.Resultado.Perder:
                    pictureResultado.BackgroundImage = Image.FromFile("images/perdeu.png");
                    goto default;
                default:
                    pictureJogador.Image = jogo.ImagemJogador;
                    picturePC.Image = jogo.ImagemPC;
                    break;
            }
        }
    }
}
