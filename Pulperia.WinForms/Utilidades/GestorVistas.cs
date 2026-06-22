namespace Pulperia.WinForms.Utilidades
{
    public class GestorVistas
    {
        // es un diccionario clave: string y valor func
        private readonly Dictionary<string, Func<UserControl>> RecetaVistas = new();

        private readonly Dictionary<string, UserControl> vistas = new();

        

        private Panel _panel;
        public GestorVistas(Panel Panel) {

            

            _panel = Panel;
        }

        public void RegistrarVista(string nombreVista, Func<UserControl> receta)
        {
            RecetaVistas[nombreVista] = receta;
        }

        public void CambiarVista(string nombreVista, bool reutilizar = true) 
        {
            //Si la vista no existe en las recetas, salimos de inmediato
            if (!RecetaVistas.TryGetValue(nombreVista, out var receta)) return;

            // Si el usuario NO quiere reutilizar y ya existía en caché(la cache es otro dicc)
            if (!reutilizar && vistas.TryGetValue(nombreVista, out var vistaVieja))
            {
                vistas.Remove(nombreVista);
                vistaVieja?.Dispose(); // Liberamos la memoria real de esa vista vieja
            }

            
            if (!vistas.TryGetValue(nombreVista, out var vistaALanzar))
            {
                vistaALanzar = receta();     // Ejecuta la receta (Crea la vista)
                vistas[nombreVista] = vistaALanzar; // La guarda en la caché
            }

            
            _panel.Controls.Clear(); // Ahora sí limpiamos de forma segura el panel
            vistaALanzar.Dock = DockStyle.Fill;
            _panel.Controls.Add(vistaALanzar);






        }
    }
}
