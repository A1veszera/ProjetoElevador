using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    class Elevador
    {
        //Operações do elevador
        public static void Inicializar()
        {
            Console.WriteLine("Voçê está no térreo \n");
            Console.WriteLine("Quantos andares tem o predio? \n");
            int andar = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Qual a capacidade do elevador? \n");
            int capacidade = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quantas pessoas irão entrar no elevador? \n");
            int pessoas = Int32.Parse(Console.ReadLine());
            if (pessoas > capacidade)
            {
                Console.WriteLine("O elevador não suporta essa capacidade! \nSão permitodo apenas " + capacidade + " pessoas");
            }



            int subirDescer = 0;
            int terreo = 0;


            Console.WriteLine(@"Selecione uma opção!
                1-Entrar
                2-Sair
                3-Subir
                4-Descer");


            do
            {

                int opcao = Int32.Parse(Console.ReadLine());


                if (opcao == 1)
                {
                    Console.WriteLine("Uma pessoa entrou no levador" + " Quantidade: " + pessoas);
                    pessoas = Entrar(pessoas);
                    if (pessoas > capacidade)
                    {
                        pessoas = capacidade;
                        Console.WriteLine(" Não é permitido exceder a capacidade do elevador");
                    }
                }
                if (opcao == 2)
                {
                    pessoas = Sair(pessoas);
                    Console.WriteLine("Uma pessoa saiu do elevador" + " Quantidade: " + pessoas);
                    if (pessoas < terreo)
                    {
                        pessoas = terreo;
                        Console.WriteLine(" Elevador Vazio");
                    }
                }
                if (opcao == 3)
                {
                    Console.WriteLine("Subiu 1 andar" + " Andar: " + subirDescer);
                    subirDescer = Subir(subirDescer);
                    if (subirDescer > andar)
                    {
                        subirDescer = andar;
                        Console.WriteLine(" Voçê já está no último andar");
                    }
                }
                if (opcao == 4)
                {
                    subirDescer = Descer(subirDescer);
                    Console.WriteLine("Desceu 1 andar" + " Andar: " + subirDescer);
                    if (subirDescer < terreo)
                    {
                        subirDescer = 0;
                        Console.WriteLine("Não da para descer além do térreo");
                    }
                }
            } while (true);
        }
        public static int Entrar(int pessoas)
        {
            pessoas++;
            return pessoas;
        }
        public static int Sair(int pessoas)
        {
            pessoas--;
            return pessoas;
        }

        public static int Subir(int andar)
        {
            andar++;
            return andar;
        }
        public static int Descer(int andar)
        {
            andar--;
            return andar;
        }
    }
}
