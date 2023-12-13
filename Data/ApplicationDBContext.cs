using FDFLodsedler.Model;
using Microsoft.EntityFrameworkCore;

namespace FDFLodsedler.Data
{
    public class ApplicationDBContext: DbContext
        
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                
        }

        public DbSet<Bestyrelse> Bestyrelses { get; set; }
        public DbSet<Betaling> Betalings { get; set; }
        public DbSet<Børn> Børns { get; set; }
        public DbSet<Leder> Leders { get; set; }
        public DbSet<BørneGruppe> BørnGruppes { get; set; }
        public DbSet<Lodseldler> Lodsedlers { get; set; }

        public DbSet<Salg> Salgs { get; set; }


    }
}
