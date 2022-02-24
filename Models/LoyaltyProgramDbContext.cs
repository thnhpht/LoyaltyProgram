using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Loyalty_Program
{
    public partial class LoyaltyProgramDbContext : DbContext
    {
        public LoyaltyProgramDbContext()
            : base("name=LoyaltyProgramDbContext")
        {
        }

        public virtual DbSet<Login> Logins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.pass)
                .IsUnicode(false);
        }
    }
}
