namespace FactoryMethod.Logistica
{
    class CamionCreator : LogisticaCreator
    {
        public override ITransportProduct FactoryMethod()
        {
            return new CamionProducto();
        }
    }
}