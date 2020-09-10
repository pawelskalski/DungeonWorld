namespace DungeonWorld.Model
{
    using System.Data.Entity;

    public class DWModel : DbContext
    {
        public DWModel()
            : base("name=DungeonWorldModels")
        {
        }

        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Race> Races { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>()
                .HasMany(e => e.Characters)
                .WithRequired(e => e.Class)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Race>()
                .HasMany(e => e.Characters)
                .WithRequired(e => e.Race)
                .WillCascadeOnDelete(false);
        }
    }
}
