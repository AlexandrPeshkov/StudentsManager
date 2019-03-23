namespace Models.Etnities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SemesterDicsipline
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int SemestrID { get; set; }

        public int LectorerID { get; set; }

        public int Hours { get; set; }

        public int DisciplineID { get; set; }
    }
}
