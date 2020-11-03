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
                new UserInfo{UserId=0,UserName="Rolo",Password="Password",Email="samudra.thio@outlook.com"}
            };

            context.UserInfos.AddRange(users);
            context.SaveChanges();

            var characterstat = new CharacterStats[]
            {
                new CharacterStats{CharacterId=0,UserId=0,GuildId=0,Level=160,Class="Genetic",Strength=50,Agility=120,Vitality=159,Intelligence=50,Dexterity=100,Luck=100,HealthPoints=3500000,GoldMedals=2500,GuildContribution=1800000}
            };

            context.CharacterStats.AddRange(characterstat);
            context.SaveChanges();

            var guild = new Guild[]
            {
                new Guild{GuildId=0,GuildName="WorstBehavior"}
            };

            context.Guilds.AddRange(guild);
            context.SaveChanges();

            var adventurebook = AdventureBook[]

        }
    }
}
