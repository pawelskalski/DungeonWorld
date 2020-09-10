using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DungeonWorld.Model
{
    public class Race
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Race()
        {
            Characters = new HashSet<Character>();
        }

        [Key]
        public int RaceId { get; set; }

        [Column("Race Name")]
        [StringLength(50)]
        public string RaceName { get; set; }

        [Column("Race description")]
        public string RaceDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Character> Characters { get; set; }
    }
}
