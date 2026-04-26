using Microsoft.EntityFrameworkCore;
using Proyect.Components.Modelos;


namespace Proyect.Data
{
    public class Contexto : DbContext
    {
        
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public Contexto()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data source=SistemaVentas.db");

        public DbSet<Inventory> InventoryDB { get; set; }

        public DbSet<Proveedor> ProveedorsDB { get; set; }
        public DbSet<Ventas> VentasDB { get; set; }


    }

}




