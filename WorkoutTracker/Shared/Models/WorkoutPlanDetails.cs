using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTracker.Shared.Models
{
	public class WorkoutPlanDetails
	{
		[Key]
		public int WPDetailsId { get; set; }

		public int WorkoutPlanId { get; set; }

		public int ExcerciseId { get; set; }

		public string Sets { get; set; }

		public string Reps { get; set; }

		public string Rest { get; set; }

		public virtual WorkoutPlan WorkoutPlan { get; set; }

		public virtual ICollection<Excercise> Excercises { get; set; }
	}
}

