namespace DungeonWorld.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class()
        {
            Characters = new HashSet<Character>();
        }

        [Key]
        public int IDClass { get; set; }

        [Column("Class Name")]
        [Required]
        [StringLength(50)]
        public string Class_Name { get; set; }

        [Column("Class description")]
        public string Class_description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Character> Characters { get; set; }
    }
}
