using System;
using System.Collections.Generic;
using WorkoutTracker.db.Entities;

namespace WorkoutTracker.db.Entities
{
    /// <summary>
    /// Represents a training plan created by the user.
    /// A workout plan is a template that defines how many days per week
    /// the user trains and what those training days contain.
    /// </summary>
    public class WorkoutPlan
    {
        /// <summary>
        /// Primary key of the workout plan.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the workout plan (e.g. "FBW 4 Days", "Push Pull Legs").
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Number of training days per week (e.g. 3, 4, 5).
        /// </summary>
        public int DaysPerWeek { get; set; }

        /// <summary>
        /// Planned duration of the workout plan in weeks (e.g. 8 or 12).
        /// </summary>
        public int PlannedWeeks { get; set; }

        /// <summary>
        /// Date when the workout plan was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Indicates whether this plan is currently active.
        /// Only one plan should be active at a time.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Collection of training days that belong to this workout plan.
        /// </summary>
        public ICollection<WorkoutDay> Days { get; set; } = new List<WorkoutDay>();
    }
}
