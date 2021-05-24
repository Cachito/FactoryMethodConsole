namespace FactoryMethod
{
    // Concrete Creators anula el método de fábrica
    // para cambiar el tipo de producto resultante.
    class ConcreteCreator1 : Creator
    {
        // Tenga en cuenta que la firma del método todavía usa el tipo de producto abstracto,
        // aunque el producto concreto realmente se devuelve del método.
        // De esta manera, el Creador puede permanecer independiente de clases de productos concretas.
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
