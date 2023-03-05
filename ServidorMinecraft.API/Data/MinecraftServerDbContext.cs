using Microsoft.EntityFrameworkCore;
using ServidorMinecraft.API.Models.Domain;
using ServidorMinecraft.API.Models.Domain.Authentication;

namespace ServidorMinecraft.API.Data
{
    public class MinecraftServerDbContext : DbContext
    {
        public MinecraftServerDbContext(DbContextOptions<MinecraftServerDbContext> options) : 
            base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Work_Address>()
                .HasOne(wa => wa.Work)
                .WithMany(w => w.WorkAddresses)
                .HasForeignKey(wa => wa.WorkId);

            modelBuilder.Entity<Work_Address>()
                .HasOne(wa => wa.Address)
                .WithMany(a => a.WorkAddresses)
                .HasForeignKey(wa => wa.AddressId);

            modelBuilder.Entity<Users_Roles>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.Users_Roles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<Users_Roles>()
                .HasOne(ur => ur.Role)
                .WithMany(u => u.Users_Roles)
                .HasForeignKey(ur => ur.RoleId);
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetType> PetTypes { get; set; }

        public DbSet<Work_Address> Works_Addresses { get; set; }

        //Authentication

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Users_Roles> Users_Roles { get; set; }
    }
}
