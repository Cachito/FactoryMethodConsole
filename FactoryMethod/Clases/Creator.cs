namespace FactoryMethod.Clases
{
    // La clase Creator declara el FactoryMethod que se supone que devuelve
    // un objeto de una clase Product.
    // Las subclases del Creador generalmente proporcionan la implementación de este método.
    abstract class Creator
    {
        // Tenga en cuenta que el Creador también puede proporcionar alguna implementación
        // predeterminada del FactoryMethod.
        public abstract IProduct FactoryMethod();

        // También tenga en cuenta que, a pesar de su nombre, la responsabilidad principal del Creador no es crear productos.
        // Por lo general, contiene cierta lógica de negocio que se basa en objetos Producto,
        // devueltos por FactoryMethod.
        // Las subclases pueden cambiar indirectamente esa lógica de negocio
        // anulando el FactoryMethod y devolviendo un tipo de producto diferente.
        public string SomeOperation()
        {
            // Llamada al FactoryMethod para crear un objeto Producto.
            var product = FactoryMethod();
            // Ahora, uso del producto.
            var result = "Creator: El mismo código de Creator acaba de funciona con " + product.Operation();

            return result;
        }
    }
}
