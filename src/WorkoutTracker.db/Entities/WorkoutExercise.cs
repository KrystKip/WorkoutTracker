using WorkoutTracker.db.Entities;

namespace WorkoutTracker.db.Entities
{
    /// <summary>
    /// Represents a single exercise inside a workout day,
    /// including planned sets, reps and rest time.
    /// </summary>
    public class WorkoutExercise
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Order of the exercise within the workout day.
        /// Determines execution sequence.
        /// </summary>
        public int ExerciseOrder { get; set; }

        /// <summary>
        /// Planned number of sets.
        /// </summary>
        public int PlannedSets { get; set; }

        /// <summary>
        /// Minimum planned repetitions per set.
        /// </summary>
        public int PlannedReps{ get; set; }

        /// <summary>
        /// Planned rest time between sets (in seconds).
        /// </summary>
        public int RestSeconds { get; set; }

        /// <summary>
        /// Optional user note for this exercise
        /// (e.g. "slow tempo", "focus on form").
        /// </summary>
        public string? Note { get; set; }

        // =========================
        // Relations
        // =========================

        /// <summary>
        /// Foreign key to WorkoutDay.
        /// </summary>
        public int WorkoutDayId { get; set; }

        /// <summary>
        /// Parent workout day.
        /// </summary>
        public WorkoutDay WorkoutDay { get; set; } = null!;

        /// <summary>
        /// Reference to exercise definition (read-only dictionary).
        /// </summary>
        public int ExerciseDefinitionId { get; set; }

        /// <summary>
        /// Exercise definition (e.g. Bench Press).
        /// </summary>
        public Exercise Exercise { get; set; } = null!;
    }
}