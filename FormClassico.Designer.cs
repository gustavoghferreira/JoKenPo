namespace JoKenPo
{
    partial class FormClassico
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelEscolha = new Label();
            labelPedra = new Label();
            buttonPedra = new Button();
            buttonPapel = new Button();
            buttonTesoura = new Button();
            labelPapel = new Label();
            labelTesoura = new Label();
            pictureJogador = new PictureBox();
            picturePC = new PictureBox();
            pictureResultado = new PictureBox();
            labelVs = new Label();
            labelIgual = new Label();
            labelJogador = new Label();
            labelPC = new Label();
            labelResposta = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureJogador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureResultado).BeginInit();
            SuspendLayout();
            // 
            // labelEscolha
            // 
            labelEscolha.AutoSize = true;
            labelEscolha.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEscolha.Location = new Point(236, 9);
            labelEscolha.Name = "labelEscolha";
            labelEscolha.Size = new Size(89, 30);
            labelEscolha.TabIndex = 0;
            labelEscolha.Text = "Escolha:";
            // 
            // labelPedra
            // 
            labelPedra.AutoSize = true;
            labelPedra.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPedra.Location = new Point(55, 87);
            labelPedra.Name = "labelPedra";
            labelPedra.Size = new Size(67, 30);
            labelPedra.TabIndex = 1;
            labelPedra.Text = "Pedra";
            // 
            // buttonPedra
            // 
            buttonPedra.BackgroundImage = Properties.Resources.pedra;
            buttonPedra.Location = new Point(30, 120);
            buttonPedra.Name = "buttonPedra";
            buttonPedra.Size = new Size(120, 120);
            buttonPedra.TabIndex = 2;
            buttonPedra.TabStop = false;
            buttonPedra.UseVisualStyleBackColor = true;
            // 
            // buttonPapel
            // 
            buttonPapel.BackgroundImage = Properties.Resources.papel;
            buttonPapel.Location = new Point(220, 120);
            buttonPapel.Name = "buttonPapel";
            buttonPapel.Size = new Size(120, 120);
            buttonPapel.TabIndex = 3;
            buttonPapel.TabStop = false;
            buttonPapel.UseVisualStyleBackColor = true;
            // 
            // buttonTesoura
            // 
            buttonTesoura.BackgroundImage = Properties.Resources.tesoura;
            buttonTesoura.Location = new Point(409, 120);
            buttonTesoura.Name = "buttonTesoura";
            buttonTesoura.Size = new Size(120, 120);
            buttonTesoura.TabIndex = 4;
            buttonTesoura.TabStop = false;
            buttonTesoura.UseVisualStyleBackColor = true;
            // 
            // labelPapel
            // 
            labelPapel.AutoSize = true;
            labelPapel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPapel.Location = new Point(249, 87);
            labelPapel.Name = "labelPapel";
            labelPapel.Size = new Size(64, 30);
            labelPapel.TabIndex = 5;
            labelPapel.Text = "Papel";
            // 
            // labelTesoura
            // 
            labelTesoura.AutoSize = true;
            labelTesoura.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTesoura.Location = new Point(434, 87);
            labelTesoura.Name = "labelTesoura";
            labelTesoura.Size = new Size(67, 30);
            labelTesoura.TabIndex = 6;
            labelTesoura.Text = "Pedra";
            // 
            // pictureJogador
            // 
            pictureJogador.BorderStyle = BorderStyle.FixedSingle;
            pictureJogador.Location = new Point(30, 256);
            pictureJogador.Name = "pictureJogador";
            pictureJogador.Size = new Size(120, 120);
            pictureJogador.TabIndex = 7;
            pictureJogador.TabStop = false;
            // 
            // picturePC
            // 
            picturePC.BorderStyle = BorderStyle.FixedSingle;
            picturePC.Location = new Point(220, 256);
            picturePC.Name = "picturePC";
            picturePC.Size = new Size(120, 120);
            picturePC.TabIndex = 8;
            picturePC.TabStop = false;
            // 
            // pictureResultado
            // 
            pictureResultado.BorderStyle = BorderStyle.FixedSingle;
            pictureResultado.Location = new Point(409, 256);
            pictureResultado.Name = "pictureResultado";
            pictureResultado.Size = new Size(120, 120);
            pictureResultado.TabIndex = 9;
            pictureResultado.TabStop = false;
            // 
            // labelVs
            // 
            labelVs.AutoSize = true;
            labelVs.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVs.Location = new Point(168, 297);
            labelVs.Name = "labelVs";
            labelVs.Size = new Size(33, 30);
            labelVs.TabIndex = 10;
            labelVs.Text = "vs";
            // 
            // labelIgual
            // 
            labelIgual.AutoSize = true;
            labelIgual.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIgual.Location = new Point(363, 297);
            labelIgual.Name = "labelIgual";
            labelIgual.Size = new Size(28, 30);
            labelIgual.TabIndex = 11;
            labelIgual.Text = "=";
            // 
            // labelJogador
            // 
            labelJogador.AutoSize = true;
            labelJogador.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJogador.Location = new Point(64, 297);
            labelJogador.Name = "labelJogador";
            labelJogador.Size = new Size(58, 30);
            labelJogador.TabIndex = 12;
            labelJogador.Text = "você";
            // 
            // labelPC
            // 
            labelPC.AutoSize = true;
            labelPC.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPC.Location = new Point(261, 297);
            labelPC.Name = "labelPC";
            labelPC.Size = new Size(38, 30);
            labelPC.TabIndex = 13;
            labelPC.Text = "PC";
            // 
            // labelResposta
            // 
            labelResposta.AutoSize = true;
            labelResposta.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResposta.Location = new Point(460, 297);
            labelResposta.Name = "labelResposta";
            labelResposta.Size = new Size(22, 30);
            labelResposta.TabIndex = 14;
            labelResposta.Text = "?";
            // 
            // FormClassico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 410);
            Controls.Add(labelResposta);
            Controls.Add(labelPC);
            Controls.Add(labelJogador);
            Controls.Add(labelIgual);
            Controls.Add(labelVs);
            Controls.Add(pictureResultado);
            Controls.Add(picturePC);
            Controls.Add(pictureJogador);
            Controls.Add(labelTesoura);
            Controls.Add(labelPapel);
            Controls.Add(buttonTesoura);
            Controls.Add(buttonPapel);
            Controls.Add(buttonPedra);
            Controls.Add(labelPedra);
            Controls.Add(labelEscolha);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormClassico";
            ((System.ComponentModel.ISupportInitialize)pictureJogador).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEscolha;
        private Label labelPedra;
        private Button buttonPedra;
        private Button buttonPapel;
        private Button buttonTesoura;
        private Label labelPapel;
        private Label labelTesoura;
        private PictureBox pictureJogador;
        private PictureBox picturePC;
        private PictureBox pictureResultado;
        private Label labelVs;
        private Label labelIgual;
        private Label labelJogador;
        private Label labelPC;
        private Label labelResposta;
    }
}
