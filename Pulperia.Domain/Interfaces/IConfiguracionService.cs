using Pulperia.Domain.Entities;

namespace Pulperia.Domain.Interfaces
{
    public interface IConfiguracionService
    {
        ConfiguracionSistema Cargar();
        void Guardar(ConfiguracionSistema configuracion);
        
    }
}
