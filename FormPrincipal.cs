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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void avançadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "JoKenPo: avançado";
            ClientSize = new Size(560, 575);
            CarregarForm(new FormAvancado());
        }

        private void clássicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "JoKenPo: clássico";
            ClientSize = new Size(575, 450);
            CarregarForm(new FormClassico());
        }

        public void CarregarForm(Form child)
        {
            try
            {
                child.TopLevel = false;
                //child.FormBorderStyle = FormBorderStyle.None;
                //child.StartPosition = FormStartPosition.CenterScreen;
                //child.Dock = DockStyle.Fill;
                LimparControles(panelPrincipal);
                panelPrincipal.Controls.Add(child);
                child.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, child.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void fecharJogoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Text = "JoKenPo";
            ClientSize = new Size(575, 450);
            LimparControles(panelPrincipal);
        }

        private void LimparControles(Panel panel)
        {
            foreach (Control control in panel.Controls)
                control.Dispose();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
