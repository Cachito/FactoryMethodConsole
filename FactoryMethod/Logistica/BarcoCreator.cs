namespace FactoryMethod.Logistica
{
    class BarcoCreator : LogisticaCreator
    {
        public override ITransportProduct FactoryMethod()
        {
            return new BarcoProducto();
        }
    }
}