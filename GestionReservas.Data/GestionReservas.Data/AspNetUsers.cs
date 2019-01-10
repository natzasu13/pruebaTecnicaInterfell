namespace GestionReservas.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetUsers
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string EmailConfirmed { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string RememberMe { get; set; }

        [StringLength(50)]
        public string PasswordHash { get; set; }

        [StringLength(50)]
        public string SecurityStamp { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string PhoneNumberConfirmed { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }
    }
}
