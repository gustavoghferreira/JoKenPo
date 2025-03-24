using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class FormAvancado : Form
    {
        FormPrincipal status;

        public FormAvancado(FormPrincipal status)
        {
            this.status = status;
            InitializeComponent();
        }

        private void ButtonLagarto_Click(object sender, EventArgs e)
        {
            StarGame(3);
        }
        private void ButtonPapel_Click(object sender, EventArgs e)
        {
            StarGame(0);
        }

        private void ButtonPedra_Click(object sender, EventArgs e)
        {
            StarGame(1);
        }

        private void ButtonSpock_Click(object sender, EventArgs e)
        {
            StarGame(4);
        }

        private void ButtonTesoura_Click(object sender, EventArgs e)
        {
            StarGame(2);
        }

        public void StarGame(byte opcao)
        {
            labelJogador.Visible = labelPC.Visible = labelResposta.Visible = false;

            Game jogo = new Game();
            string modo = "avancado";

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
