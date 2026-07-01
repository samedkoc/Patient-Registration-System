using Microsoft.EntityFrameworkCore;
using Samed_Koç_Fİnal.Models;

namespace Samed_Koç_Fİnal.Data
{
    public class ProjeDBcontext : DbContext
    {
        public DbSet<Hasta> Hastalar { get; set; }
        public ProjeDBcontext(DbContextOptions<ProjeDBcontext>options) : base(options)
        {
               
        }
    }
}
