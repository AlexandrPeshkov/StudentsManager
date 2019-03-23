namespace Models.Etnities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordBookLine")]
    public partial class RecordBookLine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int RecordBookID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int Mark { get; set; }

        public int SemestrDisciplineID { get; set; }
    }
}
