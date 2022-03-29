using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    class Program : Elevador
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Projeto Elevador!");

            //Chama o metodo de inicializar
            Inicializar();
        }
    }
}