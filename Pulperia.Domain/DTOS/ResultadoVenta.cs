namespace Pulperia.Domain.DTOS
{
    public class ResultadoVenta
    {
        public bool EsExitosa {  get; set; }

        public string RutaPdf { get; set; } = string.Empty;

        public string MensajeError { get; set; } = string.Empty ;



    }
}
