namespace FactoryMethod.Logistica
{
    abstract class LogisticaCreator
    {
        public abstract ITransportProduct FactoryMethod();

        public string Transportar()
        {
            var product = FactoryMethod();
            var result = product.Transportar();

            return result;
        }
    }
}