namespace JoKenPo
{
    public partial class FormClassico : Form
    {
        FormPrincipal status;

        public FormClassico(FormPrincipal status)
        {
            this.status = status;
            InitializeComponent();
        }

        private void ButtonPapel_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void ButtonPedra_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }
       
        private void ButtonTesoura_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void StartGame(byte opcao)
        {
            labelJogador.Visible = labelPC.Visible = labelResultado.Visible = false;

            Game jogo = new Game();
            string modo = "classico";            

            switch (jogo.Jogar(opcao, modo))
            {
                case Game.Resultado.Empatar:
                    pictureResultado.BackgroundImage = Image.FromFile("../../../Images/empatou.png");
                    goto default;
                case Game.Resultado.Ganhar:
                    pictureResultado.BackgroundImage = Image.FromFile("../../../Images/ganhou.png");
                    status.AtualizaStatus(1, 1, 0);
                    goto default;
                case Game.Resultado.Perder:
                    pictureResultado.BackgroundImage = Image.FromFile("../../../Images/perdeu.png");
                    status.AtualizaStatus(1, 0, 1);
                    goto default;
                default:
                    pictureJogador.Image = jogo.ImagemJogador;
                    picturePC.Image = jogo.ImagemPC;
                break;
            }
        }
    }
}
