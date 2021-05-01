using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleIDP
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options)
        {

        }
        
/*        public virtual DbSet<Task> Tasks { get; set; }*/


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
/*            modelBuilder.Entity<Task>().ToTable("Task");*/
           //modelBuilder.Entity<Task>().HasKey(t => t.TaskId);
        }
    }
}
