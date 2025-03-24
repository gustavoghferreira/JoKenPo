using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
    internal class Game
    {
        public Image ImagemJogador { get; private set; }
        public Image ImagemPC { get; private set; }
        public enum Resultado
        {
            Empatar, Ganhar, Perder
        }

        public static Image[] Images { get; private set; } = LoadGame();

        private static Image[] LoadGame()
        {
            const string imagePath = "../../../Images/";
            string[] imageFiles = {"papel", "pedra", "tesoura", "lagarto", "spock"};

            List<Image> images = new List<Image>();

            foreach (string fileName in imageFiles)
            {
                try
                {
                    images.Add(Image.FromFile(Path.Combine(imagePath, $"{fileName}.png")));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar imagem '{fileName}.png': {ex.Message}");
                }
            }

            return images.ToArray();
        }


        private byte JogadaPC(string modoDeJogo)
        {
            Random random = new Random();
            int numero = modoDeJogo == "classico" ? 3 : 5;
            return (byte)random.Next(numero);
        }

        public Resultado Jogar(byte jogador, string modoDeJogo)
        {
            byte pc = JogadaPC(modoDeJogo);

            ImagemJogador = Images[jogador];
            ImagemPC = Images[pc];

            if (jogador == pc)
            {
                return Resultado.Empatar;
            }

            var verificaGanhador = new (byte jogador, byte pc)[]
            {
                (2, 0), (0, 1), (1, 3), (3, 4), (4, 2),
                (2, 3), (3, 0), (0, 4), (4, 1), (1, 2)
            };

            return verificaGanhador.Contains((jogador, pc)) ? Resultado.Ganhar : Resultado.Perder;
        }
    }
}
