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
        public int Stock { get; set; } = 0;

        public string Estado { get; set; } = Estados.Bueno.ToString();

        public DateTime FechaCaducidad { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now.Date;

        public double BasePrice { get; set; } = 0;
        public string? Description { get; set; }

        

        

    }
}
