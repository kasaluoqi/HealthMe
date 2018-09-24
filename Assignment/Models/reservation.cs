namespace Assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("reservation")]
    public partial class reservation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int location_id { get; set; }

        [Required]
        [StringLength(128)]
        public string user_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime startDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime endDate { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual location location { get; set; }
    }
}
