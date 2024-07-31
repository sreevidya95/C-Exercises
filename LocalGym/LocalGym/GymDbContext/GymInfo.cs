using LocalGym.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalGym.GymDbContext
{
    public class GymInfo:DbContext
    {
        public GymInfo(DbContextOptions<GymInfo> options):base(options){ }
        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
       public  DbSet<Session> Sessions { get; set; }

    }
}
