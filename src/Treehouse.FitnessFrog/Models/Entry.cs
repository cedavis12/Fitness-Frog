using System;
using System.ComponentModel.DataAnnotations;

namespace Treehouse.FitnessFrog.Models
{

    /// Represents an activity that has been logged in the Fitness Frog app.
    public class Entry
    {

        /// The intensity level of the activity.
        public enum IntensityLevel
        {
            Low,
            Medium,
            High
        }


        /// Default constructor.
        public Entry()
        {
        }

        /// <summary>
        /// Constructor for easily creating entries.
        /// </summary>
        /// <param name="id">The ID for the entry.</param>
        /// <param name="year">The year (1 through 9999) for the entry date.</param>
        /// <param name="month">The month (1 through 12) for the entry month.</param>
        /// <param name="day">The day (1 through the number of days for the month) for the entry day.</param>
        /// <param name="activityType">The activity type for the entry.</param>
        /// <param name="duration">The duration for the entry (in minutes).</param>
        /// <param name="intensity">The intensity for the entry.</param>
        /// <param name="exclude">Whether or not the entry should be excluded when calculating the total fitness activity.</param>
        /// <param name="notes">The notes for the entry.</param>
        public Entry(int id, int year, int month, int day, Activity.ActivityType activityType, 
            double duration, IntensityLevel intensity = IntensityLevel.Medium,
            bool exclude = false, string notes = null)
        {
            Id = id;
            Date = new DateTime(year, month, day);
            ActivityId = (int)activityType;
            Duration = duration;
            Intensity = intensity;
            Exclude = exclude;
            Notes = notes;
        }


        /// The ID of the entry.
        public int Id { get; set; }


        /// The date of the entry. Should not include a time portion.
        public DateTime Date { get; set; }

    
        /// The activity ID for the entry. The ID value should map to an ID in the activities collection.
        [Display(Name = "Activity")]
        public int ActivityId { get; set; }


        /// The activity for the entry.
        public Activity Activity { get; set; }


        /// The duration for the entry (in minutes).
        public double Duration { get; set; }

  
        /// The level of intensity for the entry.
        public IntensityLevel Intensity { get; set; }

     
        /// Whether or not this entry should be excluded when calculating the total fitness activity.     
        public bool Exclude { get; set; }

        
        /// The notes for the entry.   
        [MaxLength(200, ErrorMessage = "The Notes field cannot be longer than 200 characters.")]
        public string Notes { get; set; }
    }
}