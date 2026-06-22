namespace Pulperia.Domain.DTOS
{
    public class UserSession
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string RoleName { get; set; } = string.Empty;

        public string ContrasenaHash { get; set; } = string.Empty;
    }
}
