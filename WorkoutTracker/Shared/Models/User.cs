using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WorkoutTracker.Shared.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }

		public string Username { get; set; }

		public string Email { get; set; }

		[PasswordPropertyText(true)]
		public string Password { get; set; }
	}
}

