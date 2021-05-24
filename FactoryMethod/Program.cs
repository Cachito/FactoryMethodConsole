using System;
using FactoryMethod.Clases;
using FactoryMethod.Logistica;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Client().Main();

            new LogisticaClient().Main();

            Console.ReadKey();
        }
    }
}
