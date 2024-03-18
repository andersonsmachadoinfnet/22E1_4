using GestaoDeLaboratorios.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeLaboratorios.DAL
{
    public class INFNETContexto : DbContext
    {
        public INFNETContexto(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Computadores> Computadores { get; set; }
    }
}
