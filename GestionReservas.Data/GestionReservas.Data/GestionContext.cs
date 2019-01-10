namespace GestionReservas.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GestionContext : DbContext
    {
        public GestionContext()
            : base("name=GestionContext")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Reservacion> Reservacion { get; set; }
        public virtual DbSet<Sala> Sala { get; set; }
        public virtual DbSet<TipoCualidades> TipoCualidades { get; set; }
        public virtual DbSet<TipoEspacio> TipoEspacio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.NumeroIdentificacion)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Reservacion)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.IdCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sala>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Sala>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Sala>()
                .HasMany(e => e.Reservacion)
                .WithRequired(e => e.Sala)
                .HasForeignKey(e => e.IdSalon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoCualidades>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCualidades>()
                .HasMany(e => e.Sala)
                .WithRequired(e => e.TipoCualidades)
                .HasForeignKey(e => e.IdCualidades)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoEspacio>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoEspacio>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TipoEspacio>()
                .HasMany(e => e.Sala)
                .WithRequired(e => e.TipoEspacio)
                .HasForeignKey(e => e.IdTipoEspacio)
                .WillCascadeOnDelete(false);
        }
    }
}
