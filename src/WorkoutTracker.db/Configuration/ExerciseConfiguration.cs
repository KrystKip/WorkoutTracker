using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutTracker.db.Entities;

namespace WorkoutTracker.db.Configurations
{
    /// <summary>
    /// Fluent API configuration for Exercise entity.
    /// </summary>
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>   // its instruction how to configure one table. Here are only this properties that we want to edit, rest of them are configure automatically such as property: Level or Category.
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true); // 

            builder.ToTable("ExerciseDefinition");  // set table's name to Exercies

            builder.HasKey(e => e.Id); // set id as primary key

            builder.Property(e => e.Name)   // can't be null, max length 200
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(e => e.Category)
                 .IsRequired();

            builder.Property(e => e.Equipment)
                   .IsRequired(false);

            builder.Property(e => e.Level)
                   .IsRequired();

            builder.Property(e => e.ForceType)
                   .IsRequired();

            builder.Property(e => e.PrimaryMuscles)
                   .IsRequired();

            builder.Property(e => e.SecondaryMuscles)
                   .IsRequired(false);

            builder.Property(e => e.Instructions)
                   .IsRequired();
        }
    }
}
