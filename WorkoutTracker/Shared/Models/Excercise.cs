using System;
using System.ComponentModel.DataAnnotations;

namespace WorkoutTracker.Shared.Models
{
	public class Excercise
	{
		[Key]
		public int ExcerciseId { get; set; }

		public string ExcerciseName { get; set; }

		public string Link { get; set; }

		[DataType(DataType.MultilineText)]
		public string Description { get; set; }
	}
}

