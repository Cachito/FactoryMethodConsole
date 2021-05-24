using System;

namespace FactoryMethod.Clases
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Aplicación: lanzada con ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("Aplicación: lanzada con ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        // El código del cliente funciona con una instancia de un creador concreto,
        // aunque a través de su interfaz base.
        // Siempre que el cliente siga trabajando con el creador a través de la interfaz base,
        // puede pasarle la subclase de cualquier creador.
        public void ClientCode(Creator creator)
        {
            // ...
            Console.WriteLine("Cliente: No conozco la clase del creador, pero aún así funciona..\n" + creator.SomeOperation());
            // ...
        }
    }
}
