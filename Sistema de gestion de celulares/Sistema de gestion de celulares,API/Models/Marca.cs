namespace Sistema_de_gestion_de_celulares_API.Models
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PaisOrigen { get; set; }

        public ICollection<Producto> Productos { get; set; }
    }
}