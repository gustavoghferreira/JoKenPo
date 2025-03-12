using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Http;

namespace JoKenPo
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region Menu Arquivo

        public void carregarForm(Form child)
        {
            try
            {
                limparControles(panelPrincipal);

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

        private void fecharJogoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Text = "JoKenPo";
            ClientSize = new Size(560, 430);
            limparControles(panelPrincipal);
        }

        private void jogoAvançadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "JoKenPo: avançado";
            ClientSize = new Size(560, 550);
            carregarForm(new FormAvancado());
        }

        private void jogoClassicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "JoKenPo: clássico";
            ClientSize = new Size(560, 430);
            carregarForm(new FormClassico());
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

        #region Menu Sobre

        public void carregarImagem(String enderecoImagem)
        {
            try
            {
                limparControles(panelPrincipal);

                ClientSize = new Size(560, 450);
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
            String enderecoImagem = "image/modoAvancado.png";
            carregarImagem(enderecoImagem);
        }

        private void modoClassicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String enderecoImagem = "image/modoClassico.png";
            carregarImagem(enderecoImagem);
        }

        #endregion
    }
}
