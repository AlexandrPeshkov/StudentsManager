namespace Models.Etnities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Name { get; set; }

        public int RecordBookID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Family { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string SecondName { get; set; }

        public int Age { get; set; }
    }
}
