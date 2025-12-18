using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using WorkoutTracker.Db.Data;


namespace WorkoutTracker.db.Data
{
    /// <summary>
    /// Factory used by Entity Framework Core at design-time
    /// (for example when creating migrations).
    /// </summary>
    public class WorkoutTrackerDbContextFactory : IDesignTimeDbContextFactory<WorkoutTrackerDbContext>
    {
        public WorkoutTrackerDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsetting.json").Build(); // Build configuration from appsettings.json

            // read connection string
            var connectionString = configuration.GetConnectionString("WorkoutTrackerDb");

            // Configure DbContext options
            var optionsBuilder = new DbContextOptionsBuilder<WorkoutTrackerDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new WorkoutTrackerDbContext(optionsBuilder.Options);

        }
    }
}
