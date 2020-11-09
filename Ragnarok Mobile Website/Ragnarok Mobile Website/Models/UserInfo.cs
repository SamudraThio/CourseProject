using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ragnarok_Mobile_Website.Models
{
    public class UserInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public ICollection<CharacterStat> CharacterStat { get; set; } 

    }
}
