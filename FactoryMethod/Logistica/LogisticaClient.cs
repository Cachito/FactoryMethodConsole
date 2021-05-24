using System;

namespace FactoryMethod.Logistica
{
    class LogisticaClient
    {
        public void Main()
        {
            Console.WriteLine("Aplicación: Transporte por camión.");
            ClientCode(new CamionCreator());

            Console.WriteLine("");

            Console.WriteLine("Aplicación: Transporte por mar.");
            ClientCode(new BarcoCreator());

            Console.WriteLine("");
        }

        public void ClientCode(LogisticaCreator creator)
        {
            // ...
            Console.WriteLine($"Cliente: Estos se la pasan peleando{Environment.NewLine}{creator.Transportar()}");
            // ...
        }
    }
}
