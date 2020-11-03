using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Ragnarok_Mobile_Website.Models
{
    public class AdventureBook
    {
        [Key]
        public int CharacterId { get; set; }

        public int MaximumHp { get; set; }
        public int PhysicalAttack { get; set; }
        public int MagicAttack { get; set; }
        public int GachaDeposit { get; set; }
    }
}
