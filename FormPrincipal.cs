using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace JoKenPo
{
    public partial class FormPrincipal : Form
    {
        public sbyte numeroDePartidas = 0, partidasJogadas = 0, pontuacaoJogador = 0, pontuacaoPC = 0;

        public FormPrincipal()
        {            
            InitializeComponent();
        }

        #region Menu Arquivo

        public void carregarForm(Form child)
        {
            if(numeroDePartidas != 0)
            {
                try
                {
                    limparControles(panelPrincipal);
                    atualizaStatus(1, 0, 0);

                    child.TopLevel = false;
                    child.FormBorderStyle = FormBorderStyle.None;
                    child.StartPosition = FormStartPosition.CenterScreen;
                    child.Dock = DockStyle.Fill;
                    child.Show();
                    panelPrincipal.Controls.Add(child);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, child.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primeiro selecione o número de partidas em Configurações.");
            }
        }

        private void reiniciarJogoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClientSize = new Size(560, 430); 
            Text = "JoKenPo";
            toolStripStatusLabelPartida.Text = "Partida ?";
            toolStripStatusLabelPC.Text = "Você - ...";
            toolStripStatusLabelVoce.Text = "PC - ...";

            limparControles(panelPrincipal);
        }

        private void jogoAvançadoToolStripMenuItem_Click(object sender, EventArgs e) //tamanho, fechar jogo em andamento
        {
            ClientSize = new Size(560, 575);
            Text = "JoKenPo: avançado";
            carregarForm(new FormAvancado(this));
        }

        private void jogoClassicoToolStripMenuItem_Click(object sender, EventArgs e) //tamanho, fechar jogo em andamento
        {
            ClientSize = new Size(560, 460);
            Text = "JoKenPo: clássico";
            carregarForm(new FormClassico(this));
        }

        private void limparControles(Panel panel)
        {
            foreach (Control control in panel.Controls)
                control.Dispose();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Menu Configurações

        public void atualizaStatus(sbyte partida, byte pontoJogador, byte pontoPC)
        {
            if (partida > 0)
            {
                partidasJogadas += +1;
                toolStripStatusLabelPartida.Text = "Partida atual " + partidasJogadas + "/" + numeroDePartidas;
            }
            else
            {
                toolStripStatusLabelPartida.Text = "Partidas selecionadas " + numeroDePartidas;
                toolStripStatusLabelPC.Text = "PC - 0";
                toolStripStatusLabelVoce.Text = "Você - 0";
            }

            if(pontoJogador > 0)
            {
                pontuacaoJogador += +1;
                toolStripStatusLabelVoce.Text = "Você - " + pontuacaoJogador;
            }

            if (pontoPC > 0)
            {
                pontuacaoPC += +1;
                toolStripStatusLabelPC.Text = "PC - " + pontuacaoPC;
            }

            if(partidasJogadas > numeroDePartidas && pontuacaoJogador != pontuacaoPC)
            {
                if(pontuacaoJogador > pontuacaoPC)
                {
                    partidasJogadas += -1;
                    toolStripStatusLabelPartida.Text = "Fim das partidas " + partidasJogadas + "/" + numeroDePartidas;
                    string enderecoImagem = "images/venceu.png";
                    carregarImagem(enderecoImagem);
                }
                else
                {
                    partidasJogadas += -1;
                    toolStripStatusLabelPartida.Text = "Fim das partidas " + partidasJogadas + "/" + numeroDePartidas;
                    string enderecoImagem = "images/derrotado.png";
                    carregarImagem(enderecoImagem);
                }
            }
        }

        private void melhorDe3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            melhorDe3ToolStripMenuItem.Checked = true;
            if (melhorDe3ToolStripMenuItem.Checked)
            {
                melhorDe5ToolStripMenuItem.Checked = false;
                melhorDe10ToolStripMenuItem.Checked = false;
                partidaUnicaToolStripMenuItem.Checked = false;
            }
            numeroDePartidas = 3;
            atualizaStatus(0, 0, 0);
        }

        private void melhorDe5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            melhorDe5ToolStripMenuItem.Checked = true;
            if (melhorDe5ToolStripMenuItem.Checked)
            {
                melhorDe3ToolStripMenuItem.Checked = false;
                melhorDe10ToolStripMenuItem.Checked = false;
                partidaUnicaToolStripMenuItem.Checked = false;
            }
            numeroDePartidas = 5;
            atualizaStatus(0, 0, 0);
        }

        private void melhorDe10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            melhorDe10ToolStripMenuItem.Checked = true;
            if (melhorDe10ToolStripMenuItem.Checked)
            {
                melhorDe3ToolStripMenuItem.Checked = false;
                melhorDe5ToolStripMenuItem.Checked = false;
                partidaUnicaToolStripMenuItem.Checked = false;
            }
            numeroDePartidas = 10;
            atualizaStatus(0, 0, 0);
        }

        private void partidaUnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partidaUnicaToolStripMenuItem.Checked = true;
            if (partidaUnicaToolStripMenuItem.Checked)
            {
                melhorDe3ToolStripMenuItem.Checked = false;
                melhorDe5ToolStripMenuItem.Checked = false;
                melhorDe10ToolStripMenuItem.Checked = false;
            }
            numeroDePartidas = 1;
            atualizaStatus(0, 0, 0);
        }

        #endregion

        #region Menu Sobre

        public void carregarImagem(String enderecoImagem)
        {
            try
            {
                limparControles(panelPrincipal);

                ClientSize = new Size(560, 460);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.ImageLocation = (enderecoImagem);

                panelPrincipal.Controls.Add(pictureBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, enderecoImagem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void modoAvançadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string enderecoImagem = "images/modoAvancado.png";
            carregarImagem(enderecoImagem);
        }

        private void modoClassicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string enderecoImagem = "images/modoClassico.png";
            carregarImagem(enderecoImagem);
        }

        #endregion

    }
}
