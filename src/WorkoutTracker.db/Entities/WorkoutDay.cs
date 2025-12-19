using System.Collections.Generic;

namespace WorkoutTracker.db.Entities
{
    /// <summary>
    /// Represents a single training day within a workout plan.
    /// Example: "Day 1 - Chest & Triceps"
    /// </summary>
    public class WorkoutDay
    {
        /// <summary>
        /// Primary key of the workout day.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Display name of the training day.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Order of the day inside the plan (1, 2, 3, ...).
        /// This allows comparing Day 1 between different weeks.
        /// </summary>
        public int DayOrder { get; set; }

        /// <summary>
        /// Foreign key to the workout plan.
        /// </summary>
        public int WorkoutPlanId { get; set; }

        /// <summary>
        /// Parent workout plan.
        /// </summary>
        public WorkoutPlan WorkoutPlan { get; set; } = null!;

        /// <summary>
        /// Exercises assigned to this training day.
        /// </summary>
        public ICollection<WorkoutExercise> Exercises { get; set; } = new List<WorkoutExercise>();
    }
}