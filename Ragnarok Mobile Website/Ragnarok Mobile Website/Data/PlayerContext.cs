using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ragnarok_Mobile_Website.Models;

namespace Ragnarok_Mobile_Website.Data
{
    public class PlayerContext : DbContext
    {
        public PlayerContext (DbContextOptions<PlayerContext> options)
            : base(options)
        {
        }

        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<CharacterStat> CharacterStats { get; set; }
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<AdventureBook> AdventureBooks { get; set; }
        public DbSet<ClassStat> ClassStats { get; set; }
        public DbSet<GoddessPrayer> GoddessPrayers { get; set; }
        public DbSet<StatusResistance> StatusResistances { get; set; }
        public DbSet<Equipment> Equipments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>().ToTable("UserInfo");
            modelBuilder.Entity<CharacterStat>().ToTable("CharacterStat");
            modelBuilder.Entity<Guild>().ToTable("Guild");
            modelBuilder.Entity<AdventureBook>().ToTable("AdventureBook");
            modelBuilder.Entity<ClassStat>().ToTable("ClassStat");
            modelBuilder.Entity<GoddessPrayer>().ToTable("GoddessPrayer");
            modelBuilder.Entity<StatusResistance>().ToTable("StatusResistance");
            modelBuilder.Entity<Equipment>().ToTable("Equipment");
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //=> options.UseSqlite("Data Source=character.db");
    }
}
