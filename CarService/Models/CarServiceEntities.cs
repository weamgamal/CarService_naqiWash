using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarService.Models
{
    public class CarServiceEntities : IdentityDbContext<ApplicationUser>
    {

        public CarServiceEntities() : base()
        {

        }
        //using during injection
        public CarServiceEntities(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Times> Times { get; set; }
        public DbSet<Technican> Technicans { get; set; }
        public DbSet<CallCenter> CallCenter { get; set; }
        public DbSet<CallCenterData> CallCenterData { get; set; }
        public DbSet<CoordinatorData> CoordinatorData { get; set; }
        public DbSet<TechnicanData> TechnicanData { get; set; }
        public DbSet<PreRequst> PreRequst { get; set; }
        public DbSet<Coordinator> Coordinator { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<TechnicalOrderDay> TechnicalOrderDay { get; set; }
        public DbSet<TechnicalOrderDayTime> TechnicalOrderDayTime { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog = NaqiWashV2 ;Integrated Security = True;  Encrypt = False");
        }
    }
}
