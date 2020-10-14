namespace CookBook
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Resipes
    {
        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        public int category_id { get; set; }

        public int user_id { get; set; }

        public int hadr_level { get; set; }

        [Column("resipes", TypeName = "text")]
        [Required]
        public string resipes1 { get; set; }

        [Required]
        [StringLength(200)]
        public string image { get; set; }

        public virtual Categories Categories { get; set; }

        public virtual Users Users { get; set; }
    }
}
