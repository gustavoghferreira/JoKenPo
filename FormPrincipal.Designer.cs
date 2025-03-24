namespace JoKenPo
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            jogoClássicoToolStripMenuItem = new ToolStripMenuItem();
            classicoToolStripMenuItem = new ToolStripMenuItem();
            avancadoToolStripMenuItem = new ToolStripMenuItem();
            reiniciarJogoToolStripMenuItem1 = new ToolStripMenuItem();
            fecharJogoToolStripMenuItem = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            partidasToolStripMenuItem = new ToolStripMenuItem();
            melhorDe1 = new ToolStripMenuItem();
            melhorDe3 = new ToolStripMenuItem();
            melhorDe5 = new ToolStripMenuItem();
            melhorDe10 = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            modoClássicoToolStripMenuItem = new ToolStripMenuItem();
            modoAvançadoToolStripMenuItem = new ToolStripMenuItem();
            panelPrincipal = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelPontuacao = new ToolStripStatusLabel();
            toolStripStatusLabelJogador = new ToolStripStatusLabel();
            toolStripStatusLabelVs = new ToolStripStatusLabel();
            toolStripStatusLabelPC = new ToolStripStatusLabel();
            toolStripStatusLabelPartida = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, configuraçõesToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(564, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jogoClássicoToolStripMenuItem, reiniciarJogoToolStripMenuItem1, fecharJogoToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // jogoClássicoToolStripMenuItem
            // 
            jogoClássicoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { classicoToolStripMenuItem, avancadoToolStripMenuItem });
            jogoClássicoToolStripMenuItem.Name = "jogoClássicoToolStripMenuItem";
            jogoClássicoToolStripMenuItem.Size = new Size(146, 22);
            jogoClássicoToolStripMenuItem.Text = "Jogo";
            // 
            // classicoToolStripMenuItem
            // 
            classicoToolStripMenuItem.Name = "classicoToolStripMenuItem";
            classicoToolStripMenuItem.Size = new Size(127, 22);
            classicoToolStripMenuItem.Text = "Clássico";
            classicoToolStripMenuItem.Click += JogoClassicoToolStripMenuItem_Click;
            // 
            // avancadoToolStripMenuItem
            // 
            avancadoToolStripMenuItem.Name = "avancadoToolStripMenuItem";
            avancadoToolStripMenuItem.Size = new Size(127, 22);
            avancadoToolStripMenuItem.Text = "Avançado";
            avancadoToolStripMenuItem.Click += JogoAvançadoToolStripMenuItem_Click;
            // 
            // reiniciarJogoToolStripMenuItem1
            // 
            reiniciarJogoToolStripMenuItem1.Name = "reiniciarJogoToolStripMenuItem1";
            reiniciarJogoToolStripMenuItem1.Size = new Size(146, 22);
            reiniciarJogoToolStripMenuItem1.Text = "Reiniciar jogo";
            reiniciarJogoToolStripMenuItem1.Click += ReiniciarJogoToolStripMenuItem_Click;
            // 
            // fecharJogoToolStripMenuItem
            // 
            fecharJogoToolStripMenuItem.Name = "fecharJogoToolStripMenuItem";
            fecharJogoToolStripMenuItem.Size = new Size(143, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(146, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += SairToolStripMenuItem_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { partidasToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // partidasToolStripMenuItem
            // 
            partidasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { melhorDe1, melhorDe3, melhorDe5, melhorDe10 });
            partidasToolStripMenuItem.Name = "partidasToolStripMenuItem";
            partidasToolStripMenuItem.Size = new Size(180, 22);
            partidasToolStripMenuItem.Text = "Partidas";
            // 
            // melhorDe1
            // 
            melhorDe1.Checked = true;
            melhorDe1.CheckState = CheckState.Checked;
            melhorDe1.Name = "melhorDe1";
            melhorDe1.Size = new Size(180, 22);
            melhorDe1.Text = "partida única";
            melhorDe1.Click += MelhorDe1ToolStripMenuItem_Click;
            // 
            // melhorDe3
            // 
            melhorDe3.Name = "melhorDe3";
            melhorDe3.Size = new Size(180, 22);
            melhorDe3.Text = "melhor de 3";
            melhorDe3.Click += MelhorDe3ToolStripMenuItem_Click;
            // 
            // melhorDe5
            // 
            melhorDe5.Name = "melhorDe5";
            melhorDe5.Size = new Size(180, 22);
            melhorDe5.Text = "melhor de 5";
            melhorDe5.Click += MelhorDe5ToolStripMenuItem_Click;
            // 
            // melhorDe10
            // 
            melhorDe10.Name = "melhorDe10";
            melhorDe10.Size = new Size(180, 22);
            melhorDe10.Text = "melhor de 10";
            melhorDe10.Click += MelhorDe10ToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modoClássicoToolStripMenuItem, modoAvançadoToolStripMenuItem });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // modoClássicoToolStripMenuItem
            // 
            modoClássicoToolStripMenuItem.Name = "modoClássicoToolStripMenuItem";
            modoClássicoToolStripMenuItem.Size = new Size(160, 22);
            modoClássicoToolStripMenuItem.Text = "Modo clássico";
            modoClássicoToolStripMenuItem.Click += ModoClassicoToolStripMenuItem_Click;
            // 
            // modoAvançadoToolStripMenuItem
            // 
            modoAvançadoToolStripMenuItem.Name = "modoAvançadoToolStripMenuItem";
            modoAvançadoToolStripMenuItem.Size = new Size(160, 22);
            modoAvançadoToolStripMenuItem.Text = "Modo avançado";
            modoAvançadoToolStripMenuItem.Click += ModoAvançadoToolStripMenuItem_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 24);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(564, 432);
            panelPrincipal.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelPontuacao, toolStripStatusLabelJogador, toolStripStatusLabelVs, toolStripStatusLabelPC, toolStripStatusLabelPartida });
            statusStrip1.Location = new Point(0, 434);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(564, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelPontuacao
            // 
            toolStripStatusLabelPontuacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabelPontuacao.Name = "toolStripStatusLabelPontuacao";
            toolStripStatusLabelPontuacao.Size = new Size(77, 17);
            toolStripStatusLabelPontuacao.Text = "Pontuação:";
            // 
            // toolStripStatusLabelJogador
            // 
            toolStripStatusLabelJogador.Name = "toolStripStatusLabelJogador";
            toolStripStatusLabelJogador.Size = new Size(52, 17);
            toolStripStatusLabelJogador.Text = "Você - ...";
            // 
            // toolStripStatusLabelVs
            // 
            toolStripStatusLabelVs.Name = "toolStripStatusLabelVs";
            toolStripStatusLabelVs.Size = new Size(18, 17);
            toolStripStatusLabelVs.Text = "vs";
            // 
            // toolStripStatusLabelPC
            // 
            toolStripStatusLabelPC.Name = "toolStripStatusLabelPC";
            toolStripStatusLabelPC.Size = new Size(42, 17);
            toolStripStatusLabelPC.Text = "PC - ...";
            // 
            // toolStripStatusLabelPartida
            // 
            toolStripStatusLabelPartida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabelPartida.Name = "toolStripStatusLabelPartida";
            toolStripStatusLabelPartida.Size = new Size(360, 17);
            toolStripStatusLabelPartida.Spring = true;
            toolStripStatusLabelPartida.Text = "Partida ?";
            toolStripStatusLabelPartida.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 456);
            Controls.Add(statusStrip1);
            Controls.Add(panelPrincipal);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JoKenPo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripSeparator fecharJogoToolStripMenuItem;
        private ToolStripMenuItem reiniciarJogoToolStripMenuItem1;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem partidasToolStripMenuItem;
        private ToolStripMenuItem melhorDe1;
        private ToolStripMenuItem melhorDe3;
        private ToolStripMenuItem melhorDe5;
        private ToolStripMenuItem melhorDe10;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem modoClássicoToolStripMenuItem;
        private ToolStripMenuItem modoAvançadoToolStripMenuItem;
        private ToolStripMenuItem jogoClássicoToolStripMenuItem;
        private ToolStripMenuItem classicoToolStripMenuItem;
        private ToolStripMenuItem avancadoToolStripMenuItem;
        private Panel panelPrincipal;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelPontuacao;
        private ToolStripStatusLabel toolStripStatusLabelJogador;
        private ToolStripStatusLabel toolStripStatusLabelVs;
        private ToolStripStatusLabel toolStripStatusLabelPC;
        private ToolStripStatusLabel toolStripStatusLabelPartida;
    }
}