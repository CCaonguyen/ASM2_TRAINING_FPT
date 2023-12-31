﻿using Microsoft.EntityFrameworkCore;
using Training.DataDBContext;

namespace Tranning.DataDBContext
{
    public class TranningDBContext : DbContext
    {
        internal readonly IEnumerable<object> User;

        public TranningDBContext(DbContextOptions<TranningDBContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Trainner_Topic> Trainner_Topics { get; set; }
        public DbSet<Trainee_Course> Trainee_Courses { get; set; }
    }
}

