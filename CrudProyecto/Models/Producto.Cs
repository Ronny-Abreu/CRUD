namespace CrudProyecto.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public Decimal Precio { get; set; }
    }
}
