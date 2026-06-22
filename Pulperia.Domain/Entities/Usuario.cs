namespace Pulperia.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        public  int IdRol {  get; set; }

        public string Nombre { get; set; } = string.Empty;

        public bool EstaActiva { get; set; }

        public string ContrasenaHash { get; set; } = string.Empty;
    }
}
