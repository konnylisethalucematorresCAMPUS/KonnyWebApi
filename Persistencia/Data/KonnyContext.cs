using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data;

    public class KonnyContext : DbContext{
        public KonnyContext(DbContextOptions<KonnyContext> options) : base(options){

        }
        public DbSet<>
        
    }
