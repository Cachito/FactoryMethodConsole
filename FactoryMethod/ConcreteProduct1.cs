namespace FactoryMethod
{
    // Concrete Products proporciona varias implementaciones de la interfaz del producto.
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
