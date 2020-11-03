using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Ragnarok_Mobile_Website.Models
{
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
