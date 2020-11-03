using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Ragnarok_Mobile_Website.Models
{
    public class Database : DbContext
    {
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<CharacterStats> CharacterStats { get; set; }
        public DbSet<Guild> Guild { get; set; }
        public DbSet<AdventureBook> AdventureBook { get; set; }
        public DbSet<ClassStats> ClassStat { get; set; }
        public DbSet<GoddessPrayer> GoddessPrayer { get; set; }
        public DbSet<StatusResistance> StatusResistance { get; set; }
        public DbSet<Equipment> Equipment { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
            //=> options.UseSqlite("Data Source=character.db");
    }
}
