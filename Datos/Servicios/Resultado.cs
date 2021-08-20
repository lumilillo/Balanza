namespace Datos.Servicios
{
    public class Resultado
    {
        public bool isOk { get; set; }
        public string error { get; set; }
        public int id { get; set; }
        public object result { get; set; }
    }
}