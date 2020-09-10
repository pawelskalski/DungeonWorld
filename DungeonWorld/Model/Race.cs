namespace DungeonWorld.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Race
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Race()
        {
            Characters = new HashSet<Character>();
        }

        [Key]
        public int IDRace { get; set; }

        [Column("Race Name")]
        [StringLength(50)]
        public string Race_Name { get; set; }

        [Column("Race description")]
        public string Race_description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Character> Characters { get; set; }
    }
}
