using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Ragnarok_Mobile_Website.Models
{
    public class CharacterStats
    {
        [Key]
        public int CharacterId { get; set; }

        public int UserId { get; set; }
        public int GuildId { get; set; }
        public int Level { get; set; }
        public string Class { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Luck { get; set; }
        public int HealthPoints { get; set; }
        public int GoldMedals { get; set; }
        public int GuildContribution { get; set; }
    }
}
