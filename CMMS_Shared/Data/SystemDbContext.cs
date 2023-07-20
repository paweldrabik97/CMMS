using CMMS_Shared.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CMMS_Shared.Data
{
    public class SystemDbContext : IdentityDbContext
    {
        public SystemDbContext(DbContextOptions<SystemDbContext> options)
            : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<ItemCycles> ItemCycles { get; set; }

    }
}
