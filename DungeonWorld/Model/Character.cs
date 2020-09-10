namespace DungeonWorld.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class Character
    {
        [Key]
        public int CharacterId { get; set; }

        public int ClassId { get; set; }

        public int RaceId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Damage { get; set; }

        public int CurrentHealth { get; set; }

        public int MaxHealth { get; set; }

        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Constitution { get; set; }

        public int Inteligence { get; set; }

        public int Lore { get; set; }

        public int Charisma { get; set; }

        public virtual Class Class { get; set; }

        public virtual Race Race { get; set; }
    }
}
