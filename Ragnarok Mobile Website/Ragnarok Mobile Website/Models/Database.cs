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
        public DbSet<PrayerTracker> PrayerTracker { get; set; }
        public DbSet<StatusResistance> StatusResistance { get; set; }
        public DbSet<Equipment> Equipment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=character.db");
    }
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
    public class CharacterStats
    {
        [Key]
        public int CharacterId { get; set; }

        public int UserId { get; set; }
        public int GuildId { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int GoldMedals { get; set; }
        public int GuildContribution { get; set; }
    }
    public class Guild
    {
        [Key]
        public int GuildId { get; set; }
        public string GuildName { get; set; }
    }
    public class AdventureBook
    {
        [Key]
        public int CharacterId { get; set; }

        public int MaximumHp { get; set; }
        public int PhysicalAttack { get; set; }
        public int MagicAttack { get; set; }
    }
    public class ClassStats
    {
        [Key]
        public int ClassId { get; set; }

        public int PhysicalAttack { get; set; }
        public int MagicAttack { get; set; }
        public int PhysicalDefenseIgnore { get; set; }
        public int MagicDefenseIgnore { get; set; }
        public int PhysicalPenetration { get; set; }
        public int MagicPenetration { get; set; }
        public int HealAmount { get; set; }
        public int PhysicalDamageReduction { get; set; }
        public int MagicDamageIgnore { get; set; }

    }
    public class PrayerTracker
    {
        [Key]
        public int CharacterId { get; set; }

        public int MaximumHp { get; set; }
        public int PhysicalAttack { get; set; }
        public int MagicAttack { get; set; }
        public int PhysicalDefense { get; set; }
        public int MagicalDefense { get; set; }

    }
    public class StatusResistance
    {
        [Key]
        public int CharacterId { get; set; }

        public int FearResistance { get; set; }
        public int FreezeResistance { get; set; }
        public int PetrifyResistance { get; set; }
        public int SleepResistance { get; set; }
        public int StunResistance { get; set; }

    }
    public class Equipment
    {
        [Key]
        public int CharacterId { get; set; }

        public string WeaponName { get; set; }
        public int WeaponRefine { get; set; }
        public string WeaponCard { get; set; }

        public string ShieldName { get; set; }
        public int ShieldRefine { get; set; }
        public string ShieldCard { get; set; }

        public string ArmorName { get; set; }
        public int ArmorRefine { get; set; }
        public string ArmorCard { get; set; }

        public string ManteauName { get; set; }
        public int ManteauRefine { get; set; }
        public string ManteauCard { get; set; }

        public string LeftAccessoryName { get; set; }
        public int LeftAccessoryRefine { get; set; }
        public string LeftAccessoryCard { get; set; }

        public string RightAccessoryName { get; set; }
        public int RightAccessoryRefine { get; set; }
        public string RightAccessoryCard { get; set; }
        
        public string HeadgearName { get; set; }
        public int HeadgearRefine { get; set; }
        public string HeadgearCard { get; set; }

        public string FaceName { get; set; }
        public int FaceRefine { get; set; }

        public string MouthName { get; set; }
        public int MouthRefine { get; set; }

        public string BackName { get; set; }
        public int BackRefine { get; set; }

        public string TailName { get; set; }
        public int TailRefine { get; set; }
    }
}
