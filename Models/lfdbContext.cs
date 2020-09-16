using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ef_async.Models
{
    public partial class lfdbContext : DbContext
    {
        public lfdbContext()
        {
        }

        public lfdbContext(DbContextOptions<lfdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbListaFofa> TbListaFofa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;user id=root;password=1234;database=lfdb", x => x.ServerVersion("5.7.30-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbListaFofa>(entity =>
            {
                entity.HasKey(e => e.IdListaFofa)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsPorque)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmFofura)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
