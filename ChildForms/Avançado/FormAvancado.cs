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

        private void buttonLagarto_Click(object sender, EventArgs e)
        {
            starGame(3);
        }
        private void buttonPapel_Click(object sender, EventArgs e)
        {
            starGame(0);
        }

        private void buttonPedra_Click(object sender, EventArgs e)
        {
            starGame(1);
        }

        private void buttonSpock_Click(object sender, EventArgs e)
        {
            starGame(4);
        }

        private void buttonTesoura_Click(object sender, EventArgs e)
        {
            starGame(2);
        }

        public void starGame(byte opcao)
        {
            labelJogador.Visible = false;
            labelPC.Visible = false;
            labelResposta.Visible = false;

            Game jogo = new Game();
            string modo = "avancado";

            switch (jogo.jogar(opcao, modo))
            {
                case Game.Resultado.Empatar:
                    pictureResultado.BackgroundImage = Image.FromFile("images/empatou.png");
                    goto default;
                case Game.Resultado.Ganhar:
                    pictureResultado.BackgroundImage = Image.FromFile("images/ganhou.png");
                    status.atualizaStatus(1, 1, 0);
                    goto default;
                case Game.Resultado.Perder:
                    pictureResultado.BackgroundImage = Image.FromFile("images/perdeu.png");
                    status.atualizaStatus(1, 0, 1);
                    goto default;
                default:
                    pictureJogador.Image = jogo.ImagemJogador;
                    picturePC.Image = jogo.ImagemPC;
                break;
            }
        }       
    }
}
