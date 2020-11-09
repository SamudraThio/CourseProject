using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Ragnarok_Mobile_Website.Models
{
    public class ClassStat
    {
        [Key]
        public int ClassID { get; set; }

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
}
