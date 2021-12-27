
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";
                while (player != "PEDRA" && player != "PAPEL" && player != "TESOURA")
                {
                    Console.WriteLine("Escolha PEDRA, PAPEL ou TESOURA: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "PEDRA";
                        break;
                    case 2:
                        computer = "PAPEL";
                        break;
                    case 3:
                        computer = "TESOURA";
                        break;
                }

                Console.WriteLine("Jogador: " + player);
                Console.WriteLine("Computador: " + computer);

                switch (player)
                {
                    case "PEDRA":
                        if(computer == "PEDRA")
                        {
                            Console.WriteLine("É um empate!");
                        }
                        else if(computer == "PAPEL")
                        {
                            Console.WriteLine("Você perdeu!");
                        }
                        else
                        {
                            Console.WriteLine("Você ganhou!");
                        }
                        break;
                    case "PAPEL":
                        if(computer == "PAPEL")
                        {
                            Console.WriteLine("É um empate!");
                        }
                        else if(computer == "TESOURA")
                        {
                            Console.WriteLine("Você perdeu!");
                        }
                        else
                        {
                            Console.WriteLine("Você ganhou!");
                        }
                        break;
                    case "TESOURA":
                        if (computer == "TESOURA")
                        {
                            Console.WriteLine("É um empate!");
                        }
                        else if (computer == "PEDRA")
                        {
                            Console.WriteLine("Você perdeu!");
                        }
                        else
                        {
                            Console.WriteLine("Você ganhou!");
                        }
                        break;

                }
                Console.Write("Você gostaria de jogar novamente? (S/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "S")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Obrigado pro Jogar ;)");

            Console.ReadKey();
        }
    }
}
