using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Ragnarok_Mobile_Website.Models
{
    public class Guild
    {
        [Key]
        public int GuildId { get; set; }
        public string GuildName { get; set; }
        public bool Application { get; set; }
        public bool CharacterUpdate { get; set; }
    }
}
