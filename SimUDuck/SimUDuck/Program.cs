using SimUDuck.Patos;
using System;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PatoSelvagem patoSelvagem = new PatoSelvagem();
            patoSelvagem.Grasnar();
            patoSelvagem.Voar();
            patoSelvagem.Nadar();

            PatoCabecaVermelha patoCabecaVermelha = new PatoCabecaVermelha();
            patoCabecaVermelha.Grasnar();
            patoCabecaVermelha.Voar();
            patoCabecaVermelha.Nadar();

            Console.ReadLine();
        }
    }
}
