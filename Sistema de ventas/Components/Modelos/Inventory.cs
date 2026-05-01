using System.ComponentModel.DataAnnotations;

namespace Proyect.Components.Modelos
{
    public class Inventory
    {
        public enum Estados
        {
            Bueno,
            Danado,
            Defectuoso
        }

        [Key] public int Id { get; set; }

        [Required] public string Name { get; set; } = string.Empty;
        public int Stock { get; set; } 

        public string Estado { get; set; } = Estados.Bueno.ToString();

        public DateTime FechaCaducidad { get; set; } = DateTime.Now.Date;

        public DateTime Fecha { get; set; } = DateTime.Now.Date;

        public decimal BasePrice { get; set; } = 0;
        public string? Description { get; set; }

        

        

    }
}
