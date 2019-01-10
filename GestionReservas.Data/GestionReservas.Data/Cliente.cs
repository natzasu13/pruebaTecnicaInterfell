namespace GestionReservas.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Reservacion = new HashSet<Reservacion>();
        }

        public int Id { get; set; }

        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string NumeroIdentificacion { get; set; }

        public double? SaldoActual { get; set; }

        [Column(TypeName = "ntext")]
        public string Telefono { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservacion> Reservacion { get; set; }
    }
}
