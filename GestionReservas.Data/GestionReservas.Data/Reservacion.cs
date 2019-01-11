namespace GestionReservas.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservacion")]
    public partial class Reservacion
    {
        public int Id { get; set; }

        public int IdSalon { get; set; }

        public int IdCliente { get; set; }

        [StringLength(50)]
        public string HoraInicio { get; set; }

        [StringLength(50)]
        public string HoraFin { get; set; }

        public double? Valor { get; set; }

        public bool? Paga { get; set; }

        public bool? Confimada { get; set; }

        [Column("_created")]
        public DateTime? C_created { get; set; }

        [Column("_updated")]
        public DateTime? C_updated { get; set; }

        [Column("_deleted")]
        public DateTime? C_deleted { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Sala Sala { get; set; }
    }
}
