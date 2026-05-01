using System.ComponentModel.DataAnnotations;

namespace Proyect.Components.Modelos
{
    public class Ventas
    {
        public int Id { get; set; }

        [Required] public int Cantidad { get; set; }

        [Required]public string Description { get; set; }

        public DateTime FechaVenta { get; set; } 

        public decimal precioVenta { get; set; } = 0;

        //Llave foranea que trae el inventario a la tabla ventas

        public int InventarioId { get; set; }

        public Inventory Inventario { get; set; }


    }
}
