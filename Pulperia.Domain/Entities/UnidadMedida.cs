namespace Pulperia.Domain.Entities
{
    public  class UnidadMedida
    {
        public int Id { get; set; }


        public string Nombre {  get; set; }


        public string Siglas {  get; set; }



        public string Descripcion => $"{Nombre}-{Siglas}";

        public UnidadMedida() { }

    }
}
