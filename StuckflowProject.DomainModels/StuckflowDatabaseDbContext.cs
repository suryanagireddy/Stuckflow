using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace StuckflowProject.DomainModels
{
    public class StuckflowDatabaseDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Vote> Votes { get; set; }
    }
}
