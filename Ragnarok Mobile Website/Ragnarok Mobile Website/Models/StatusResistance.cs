using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Ragnarok_Mobile_Website.Models
{
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
}
