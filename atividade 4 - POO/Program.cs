using System;

namespace atividade_4___POO
{
    class Program
    {
        static void Main(string[] args)
        {

            Time time1 = new Time("Flamengo");
            time1.contratarJogador(new Jogador("Paulo", 20,94,1));
            time1.contratarJogador(new Jogador("Alex", 20,93,2 ));
            time1.contratarJogador(new Jogador("João", 25,90,3));
            time1.contratarJogador(new Jogador("Douglas", 22,85,4));
            time1.contratarJogador(new Jogador("John", 21,98,5));
            time1.contratarJogador(new Jogador("Pedro", 29,99,6));
            time1.contratarJogador(new Jogador("Carlos", 19,87,7));
            time1.contratarJogador(new Jogador("Xavier" , 27,88,8));
            time1.contratarJogador(new Jogador("Dendi", 26,92,9));
            time1.contratarJogador(new Jogador("Filipe", 33,91,10));
            time1.contratarJogador(new Jogador("Taylor", 32,95,11));



            Time time2 = new Time("Cruzeiro");
            time2.contratarJogador(new Jogador("Creyson", 20, 94, 1));
            time2.contratarJogador(new Jogador("Lesley", 20, 93, 2));
            time2.contratarJogador(new Jogador("Japa", 25, 90, 3));
            time2.contratarJogador(new Jogador("Pele", 22, 85, 4));
            time2.contratarJogador(new Jogador("Marcos", 21, 98, 5));
            time2.contratarJogador(new Jogador("Jean", 29, 99, 6));
            time2.contratarJogador(new Jogador("Rafael", 19, 87, 7));
            time2.contratarJogador(new Jogador("Wagner", 27, 88, 8));
            time2.contratarJogador(new Jogador("Yago", 26, 92, 9));
            time2.contratarJogador(new Jogador("Cassio", 33, 91, 10));
            time2.contratarJogador(new Jogador("Zagal", 32, 95, 11));

            Partida p1 = new Partida(DateTime.Now, time1, time2);
            p1.jogar();
            Console.WriteLine(p1.getPlacar());

            Console.WriteLine(time1.getStatus());
            time1.getDescricaoJogadores();


            Console.WriteLine(time2.getStatus());
            time2.getDescricaoJogadores();

            Console.ReadKey();

        }
    }
}
