using System;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Shared.Models;

namespace WorkoutTracker.Server.DataAcessLayer
{
	public class WorkoutDb : DbContext
	{
		public WorkoutDb(DbContextOptions options) : base(options)
		{
		}

		public DbSet<User> Users { get; set; }

		public DbSet<Excercise> Excercises { get; set; }

		public DbSet<WorkoutPlan> WorkoutPlans { get; set; }

		public DbSet<WorkoutPlanDetails> WorkoutPlanDetails { get; set; }
	}
}

