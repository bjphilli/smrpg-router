using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using SmrpgRouter.Domain;

namespace SmrpgRouter.DAL
{
    public class SmrpgContext : DbContext
    {
        public SmrpgContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CharacterMap());
        }
    }
}