namespace CookBook
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admins
    {
        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        [Required]
        [StringLength(30)]
        public string surname { get; set; }

        [Required]
        [StringLength(40)]
        public string login { get; set; }

        [Required]
        [StringLength(40)]
        public string password { get; set; }
    }
}
