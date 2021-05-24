namespace FactoryMethod.Logistica
{
    public class CamionProducto : ITransportProduct
    {
        public string Transportar()
        {
            return "Creator: Aguante Moyano, Vito Dumas sos un gil.";
        }
    }
}