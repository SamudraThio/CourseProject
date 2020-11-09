using Ragnarok_Mobile_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ragnarok_Mobile_Website.Data
{
    public class DbInitializer
    {
        public static void Initialize(PlayerContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Users.
            if (context.UserInfos.Any())
            {
                return;   // DB has been seeded
            }

            var users = new UserInfo[]
            {
                new UserInfo{UserID=0,UserName="Rolo",Password="Password",Email="samudra.thio@outlook.com"}
            };

            context.UserInfos.AddRange(users);
            context.SaveChanges();

            var characterstat = new CharacterStat[]
            {
                new CharacterStat{CharacterId=0,UserId=0,GuildId=0,Level=160,JobLevel=80,Class="Genetic",Strength=50,Agility=120,Vitality=159,Intelligence=50,Dexterity=100,Luck=100,HealthPoints=3500000,GoldMedals=2500,GuildContribution=1800000}
            };

            context.CharacterStats.AddRange(characterstat);
            context.SaveChanges();

            var guild = new Guild[]
            {
                new Guild{GuildId=0,GuildName="WorstBehavior"}
            };

            context.Guilds.AddRange(guild);
            context.SaveChanges();

            var adventurebook = new AdventureBook[]
            {
                new AdventureBook {CharacterId=0,MaximumHp=38000,PhysicalAttack=1400,MagicAttack=800,GachaDeposit=14}
            };

            context.AdventureBooks.AddRange(adventurebook);
            context.SaveChanges();


            var classstat = new ClassStat[]
            {
                new ClassStat {ClassID=0}
            };

            context.ClassStats.AddRange(classstat);
            context.SaveChanges();

            var goddessprayer = new GoddessPrayer[]
            {
                new GoddessPrayer {CharacterId=0,MaximumHp=200,PhysicalAttack=200,MagicAttack=200,PhysicalDefense=200,MagicalDefense=200}
            };

            context.GoddessPrayers.AddRange(goddessprayer);
            context.SaveChanges();


            var statusresistance = new StatusResistance[]
            {
                new StatusResistance {CharacterId=0,FearResistance=98,FreezeResistance=40,PetrifyResistance=40,SleepResistance=100,StunResistance=114}
            };

            context.StatusResistances.AddRange(statusresistance);
            context.SaveChanges();

            var equipment = new Equipment[]
            {
                new Equipment {CharacterId=0,
                               WeaponName="Hurricane Fury",WeaponRefine=15,WeaponCard1="Spashire Star Card",WeaponCard2="Mega Ant Egg Card",
                               ShieldName="Stone Buckler",ShieldRefine=8,ShieldCard="Marc Card",
                               ArmorName="Comet Armor",ArmorRefine=15,ArmorCard="Ghostring Card",
                               ManteauName="Diabolus Manteau",ManteauRefine=10,ManteauCard="Jakk Card",
                               LeftAccessoryName="Safety Ring",LeftAccessoryRefine=8,LeftAccessoryCard="Fisherman Card",
                               RightAccessoryName="Safety Ring",RightAccessoryRefine=8,RightAccessoryCard="Fisherman Card",
                               HeadgearName="Sheep on Head",HeadgearRefine=4,HeadgearCard="Nightmare Card",
                               FaceName="Goblin Leader Mask",FaceRefine=10,
                               MouthName="Pipe",MouthRefine=10,
                               BackName="Midgard Backpack",BackRefine=8,
                               TailName="Midgard Fairy",TailRefine=10}
            };

            context.Equipments.AddRange(equipment);
            context.SaveChanges();

        }
 
    }
}
