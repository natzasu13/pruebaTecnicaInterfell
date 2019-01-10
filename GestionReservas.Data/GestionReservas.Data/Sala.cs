namespace GestionReservas.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sala")]
    public partial class Sala
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sala()
        {
            Reservacion = new HashSet<Reservacion>();
        }

        public int Id { get; set; }

        public int IdTipoEspacio { get; set; }

        public int IdCualidades { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        public double? Precio { get; set; }

        [Column("_created")]
        public DateTime? C_created { get; set; }

        [Column("_updated")]
        public DateTime? C_updated { get; set; }

        [Column("_deleted")]
        public DateTime? C_deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservacion> Reservacion { get; set; }

        public virtual TipoCualidades TipoCualidades { get; set; }

        public virtual TipoEspacio TipoEspacio { get; set; }
    }
}
