using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker.db.Entities
{
    /// <summary>
    /// Represents a single exercise definition stored in the database.
    /// Each instance of this class corresponds to one row in the Exercises table.
    /// </summary>
    public class Exercise         // entity say what columns
    {
        /// <summary>
        /// Primary key (auto-increment).
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Exercise name (e.g. "Bench Press").
        /// </summary>
        public string Name { get; set; } = null!;  // 

        /// <summary>
        /// Exercise category (strength, stretching, etc.).
        /// </summary>
        public string Category { get; set; } = null!;

        /// <summary>
        /// Equipment required for the exercise.
        /// Can be null if no equipment is needed.
        /// </summary>
        public string? Equipment { get; set; }

        /// <summary>
        /// Difficulty level (beginner, intermediate, advanced).
        /// </summary>
        public string Level { get; set; } = null!;

        /// <summary>
        /// Force type (push, pull, static).
        /// </summary>
        public string ForceType { get; set; } = null!;

        /// <summary>
        /// Primary muscles involved (comma-separated).
        /// </summary>
        public string PrimaryMuscles { get; set; } = null!;

        /// <summary>
        /// Secondary muscles involved (comma-separated, optional).
        /// </summary>
        public string? SecondaryMuscles { get; set; }

        /// <summary>
        /// Exercise instructions (plain text).
        /// </summary>
        public string Instructions { get; set; } = null!;
    }
}

