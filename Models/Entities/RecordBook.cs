namespace Models.Etnities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RecordBook
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Number { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string StartDate { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string EndDate { get; set; }

        public int GroupID { get; set; }
    }
}
