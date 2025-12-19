using Microsoft.EntityFrameworkCore;
using WorkoutTracker.db.Entities;

namespace WorkoutTracker.db.Data
{
    /// <summary>
    /// Entity Framework Core database context. This class manages the connection to the database and maps entities to database tables.
    /// </summary>
    public class WorkoutTrackerDbContext : DbContext  //connect database with VS 
    {
        public WorkoutTrackerDbContext(DbContextOptions<WorkoutTrackerDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Exercises table.
        /// </summary>
        public DbSet<Exercise> Exercises => Set<Exercise>();

        protected override void OnModelCreating(ModelBuilder modelBuilder) // shows EF Core how class in C# are changed to tables in SQL
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WorkoutTrackerDbContext).Assembly); //this function finds all classes that implement IEntityTypeConfiguration<T> and execute them automatically.
        }

    }
}
