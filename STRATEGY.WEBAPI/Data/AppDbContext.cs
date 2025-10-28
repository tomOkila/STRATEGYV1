using Microsoft.EntityFrameworkCore;
using STRATEGY.CLIENT.Models;
using STRATEGY.WEBAPI.Contract;

namespace STRATEGY.WEBAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUsers> Users { get; set; }
        public DbSet<AppRoles> Roles { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Pillar> Pillars { get; set; }
        public DbSet<StrategicObjective> StrategicObjectives { get; set; }
        public DbSet<DetailedSO> DetailedSO { get; set; }
        public DbSet<ProgramSchedule> ProgramSchedules { get; set; }
        public DbSet<StrategicPlan> StrategicPlans { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanDocuments> PlanDocuments { get; set; }

        //
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //permisssions
           modelBuilder.Entity<Permissions>().HasData(
               new Permissions { PermissionId = 1, PermissionName = "Admin", Create = true, Update = true, Delete = true, CreateDate=DateTime.Now,UpdatedBy=0, UpdatedDate=DateTime.Now },
               new Permissions { PermissionId = 2, PermissionName = "User", Create = true, Update = true, Delete = true, CreateDate = DateTime.Now, UpdatedBy = 0, UpdatedDate = DateTime.Now },
               new Permissions { PermissionId = 3, PermissionName = "Visitor", Create = false, Update = false, Delete = false, CreateDate = DateTime.Now, UpdatedBy = 0, UpdatedDate = DateTime.Now },
               new Permissions { PermissionId = 4, PermissionName = "Team", Create = false, Update = false, Delete = false, CreateDate = DateTime.Now, UpdatedBy = 0, UpdatedDate = DateTime.Now },
               new Permissions { PermissionId = 5, PermissionName = "Pteam", Create = false, Update = false, Delete = false, CreateDate = DateTime.Now, UpdatedBy = 0, UpdatedDate = DateTime.Now }
            );

            //roles
            modelBuilder.Entity<AppRoles>().HasData(
             new AppRoles { Id = 1, RoleName = "Admin",CreateDate = DateTime.Now, UpdatedBy = 0, UpdatedDate = DateTime.Now },
             new AppRoles { Id = 2, RoleName = "User", CreateDate = DateTime.Now, UpdatedBy = 0, UpdatedDate = DateTime.Now },
             new AppRoles { Id = 3, RoleName = "Visitor", CreateDate = DateTime.Now, UpdatedBy = 0, UpdatedDate = DateTime.Now },
             new AppRoles { Id = 4, RoleName = "Team", CreateDate = DateTime.Now, UpdatedBy = 0, UpdatedDate = DateTime.Now },
             new AppRoles { Id = 5, RoleName = "Pteam", CreateDate = DateTime.Now, UpdatedBy = 0, UpdatedDate = DateTime.Now }
            );


            //department
            modelBuilder.Entity<Department>().HasData(
             new Department { DepartmentId = 1, DepartmentName = "IT Department",DepartmentManager="Head IT", CreateDate = DateTime.Now, UpdatedBy = 0, UpdatedDate = DateTime.Now }
            );
        }

    }
}
