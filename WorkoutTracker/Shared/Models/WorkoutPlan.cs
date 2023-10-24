using System;
using System.ComponentModel.DataAnnotations;

namespace WorkoutTracker.Shared.Models
{
	public class WorkoutPlan
	{
		[Key]
		public int WorkoutPlanId { get; set; }

		public string WorkoutPlanName { get; set; }

		public int UserId { get; set; }

		public virtual User User { get; set; }
	}
}

