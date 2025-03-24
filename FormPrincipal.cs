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
        private sbyte _numeroDePartidas = 1, _partidasJogadas = 0, _pontuacaoJogador = 0, _pontuacaoPC = 0;

        public FormPrincipal()
        {            
            InitializeComponent();
        }

        #region Menu Arquivo

        public void AtualizarStatusTextos(string partida, string jogador, string pc)
        {
            toolStripStatusLabelPartida.Text = partida;
            toolStripStatusLabelPC.Text = pc;
            toolStripStatusLabelJogador.Text = jogador;
        }

        private void CarregarForm(Form child, string modo)
        {
            HabilitaJogos(false);

            try
            {
                LimparControles(panelPrincipal);
                AtualizaStatus(1, 0, 0);
                DefiniTamanhoForm(modo);

                Text = $"JokenPo: {modo}";

                child.TopLevel = false;
                child.FormBorderStyle = FormBorderStyle.None;
                child.StartPosition = FormStartPosition.CenterScreen;
                child.Dock = DockStyle.Fill;
                child.Show();
                panelPrincipal.Controls.Add(child);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar formulário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DefiniTamanhoForm(string modo)
        {
            var altura = modo == "clássico" ? 460 : 575;
            ClientSize = new Size(560, altura);
        }

        private void HabilitaJogos(bool habilitar)
        {
            avancadoToolStripMenuItem.Enabled = classicoToolStripMenuItem.Enabled = habilitar;
        }

        private void JogoAvançadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarForm(new FormAvancado(this), "avançado");
        }

        private void JogoClassicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarForm(new FormClassico(this), "clássico");
        }

        private void LimparControles(Panel panel)
        {
            panel.Controls.Clear();
        }

        private void ReiniciarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HabilitaJogos(true);
            
            _partidasJogadas = _pontuacaoJogador = _pontuacaoPC = 0;
            Text = "JoKenPo";

            AtualizarStatusTextos("Partida ?", "Jogador - ...", "PC - ...");

            LimparControles(panelPrincipal);
            DefiniTamanhoForm("clássico");
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Menu Configurações

        public void AtualizaStatus(sbyte partida, byte pontoJogador, byte pontoPC)
        {
            if (partida > 0)
            {
                _partidasJogadas++;
                toolStripStatusLabelPartida.Text = $"Partida atual  {_partidasJogadas}/{_numeroDePartidas}";
            }
            else
            {
                AtualizarStatusTextos($"Partidas selecionadas {_numeroDePartidas}", "PC - 0", "Você - 0");
            }

            if(pontoJogador > 0)
            {
                _pontuacaoJogador++;
                toolStripStatusLabelJogador.Text = $"Você - {_pontuacaoJogador}";
            }

            if (pontoPC > 0)
            {
                _pontuacaoPC++;
                toolStripStatusLabelPC.Text = $"PC - {_pontuacaoPC}";
            }

            if(_partidasJogadas > _numeroDePartidas)
            {
                FinalizarPartidas();
            }
        }

        private void FinalizarPartidas()
        {
            var resultado = _pontuacaoJogador > _pontuacaoPC ? "venceu" : "derrotado";
            _partidasJogadas--;

            toolStripStatusLabelPartida.Text = $"Fim das partidas {_partidasJogadas}/{_numeroDePartidas}";
            CarregarImagem(resultado);
        }

        private void MelhorDeSelecionado(sbyte marcado, ToolStripMenuItem checkBoxSelecionado)
        {
            melhorDe1.Checked = melhorDe3.Checked = melhorDe5.Checked = melhorDe10.Checked = false;
            checkBoxSelecionado.Checked = true;
            _numeroDePartidas = marcado;

            AtualizaStatus(0, 0, 0);
        }

        private void MelhorDe1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MelhorDeSelecionado(1, melhorDe1);
        }

        private void MelhorDe3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MelhorDeSelecionado(3, melhorDe3);
        }

        private void MelhorDe5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MelhorDeSelecionado(5, melhorDe5);
        }

        private void MelhorDe10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MelhorDeSelecionado(10, melhorDe10);
        }

        #endregion

        #region Menu Sobre

        private void CarregarImagem(string imagem)
        {
            try
            {
                LimparControles(panelPrincipal);
                DefiniTamanhoForm("clássico");

                PictureBox pictureBox = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    ImageLocation = $"../../../Images/{imagem}.png"
                };

                panelPrincipal.Controls.Add(pictureBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ModoAvançadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarImagem("modoAvancado");
        }

        private void ModoClassicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarImagem("modoClassico");
        }

        #endregion

    }
}
