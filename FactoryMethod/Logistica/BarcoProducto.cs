namespace FactoryMethod.Logistica
{
    public class BarcoProducto : ITransportProduct
    {
        public string Transportar()
        {
            return "Creator: Vito Dumas es todo lo que está bien. Moyano, no te aguatás las olas";
        }
    }
}