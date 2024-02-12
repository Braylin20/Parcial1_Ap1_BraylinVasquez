using Microsoft.EntityFrameworkCore;
using Parcial1_Ap1_BraylinVasquez.Models;

namespace Parcial1_Ap1_BraylinVasquez.Dal
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Metas> Metas { get; set; }
    }
}
