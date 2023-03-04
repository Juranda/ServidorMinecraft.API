using Microsoft.EntityFrameworkCore;
using ServidorMinecraft.API.Models.Domain;

namespace ServidorMinecraft.API.Data
{
    public class MinecraftServerDbContext : DbContext
    {
        public MinecraftServerDbContext(DbContextOptions<MinecraftServerDbContext> options) : 
            base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Work_Address>()
                .HasOne(ur => ur.Work)
                .WithMany(w => w.WorkAddresses)
                .HasForeignKey(ur => ur.WorkId);

            modelBuilder.Entity<Work_Address>()
                .HasOne(ur => ur.Address)
                .WithMany(a => a.WorkAddresses)
                .HasForeignKey(ur => ur.AddressId);
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetType> PetTypes { get; set; }

        public DbSet<Work_Address> Works_Addresses { get; set; }
    }
}
