using System;

namespace DesafioJoeslei___2704
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio avançado - Guerreiro Joeslei");
            //atributos Joeslei
            int vidaJoeslei = 20;
            Random ran = new Random();
            int valorMinimo = 3, valorMaximo = 10; //Intervalo de dano de Joeslei
            int danoJoeslei = ran.Next(valorMinimo, valorMaximo);

            //problema a
            int vidaGoblin = 5;
            Random ranGob = new Random();
            int valorMinimoGob = 1, valorMaximoGob = 4; //Intervalo de dano de Goblin
            int danoGoblin = ranGob.Next(valorMinimoGob, valorMaximoGob);

            //resolucao a
            while (vidaGoblin > 0 || vidaJoeslei > 0)
            {
                vidaGoblin = vidaGoblin - danoJoeslei;
                if (danoJoeslei > vidaGoblin)
                {
                    vidaGoblin = 0;
                    break;
                }
                vidaJoeslei = vidaJoeslei - danoGoblin;
                if (danoGoblin > vidaJoeslei)
                {
                    vidaJoeslei = 0;
                    break;
                }
                Console.WriteLine("Vida restante do Goblin: " + vidaGoblin);
                Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
            }
            Console.WriteLine();
            Console.WriteLine("Resolução questão a:");
            Console.WriteLine("Vida restante do Goblin: " + vidaGoblin);
            Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
            Console.WriteLine();

            int vidaOrc = 9;
            Random ranOrc = new Random();
            int valorMinimoOrc = 4, valorMaximoOrc = 8; //Intervalo de dano de Joeslei
            int danoOrc = ranOrc.Next(valorMinimoOrc, valorMaximoOrc);

            int vidaTroll = 20;
            Random ranTroll = new Random();
            int valorMinimoTroll = 9, valorMaximoTroll = 15; //Intervalo de dano de Joeslei
            int danoTroll = ranTroll.Next(valorMinimoTroll, valorMaximoTroll);

            Console.WriteLine("Resolução questão b:");
            Console.WriteLine("Você deseja lutar contra quem?");
            Console.WriteLine("Troll (20 pontos de vida e dano de seu porrete entre 9 e 15)");
            Console.WriteLine("Orc (9 pontos de vida e dano de seu machado entre 4 e 8)");
            string escolha = Console.ReadLine();
            if (escolha == "Troll")
            {
                while (vidaTroll > 0 || vidaJoeslei > 0)
                {
                    //vidaTroll = danoJoeslei - vidaTroll; //Algumas vezes, o valor da vida será maior que o valor do dano, gerando uma incosistência na luta
                    vidaTroll = vidaTroll - danoJoeslei;
                    if (danoJoeslei > vidaTroll)
                    {
                        vidaTroll = 0;
                        break;
                    }
                    vidaJoeslei = vidaJoeslei - danoTroll;
                    if (danoTroll > vidaJoeslei)
                    {
                        vidaJoeslei = 0;
                        break;
                    }
                    Console.WriteLine("Vida restante do Troll: " + vidaTroll);
                    Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
                }
                Console.WriteLine("Vida restante do Troll: " + vidaTroll);
                Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
            }
            else if (escolha == "Orc")
            {
                while (vidaOrc > 0 || vidaJoeslei > 0)
                {
                    vidaOrc = vidaOrc - danoJoeslei;
                    if (danoJoeslei > vidaOrc)
                    {
                        vidaOrc = 0;
                        break;
                    }
                    vidaJoeslei = vidaJoeslei - danoOrc;
                    if (danoOrc > vidaJoeslei)
                    {
                        vidaJoeslei = 0;
                        break;
                    }
                    Console.WriteLine("Vida restante do Orc: " + vidaOrc);
                    Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
                }
                Console.WriteLine();
                Console.WriteLine("Vida restante do Orc: " + vidaOrc);
                Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
            }
        }
    }
}
