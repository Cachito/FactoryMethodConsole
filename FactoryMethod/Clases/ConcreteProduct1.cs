namespace FactoryMethod.Clases
{
    // Concrete Products proporciona varias implementaciones de la interfaz del producto.
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Resultado de ConcreteProduct1}";
        }
    }
}
