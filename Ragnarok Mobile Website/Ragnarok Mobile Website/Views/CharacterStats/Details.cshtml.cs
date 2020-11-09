using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ragnarok_Mobile_Website.Data;
using Ragnarok_Mobile_Website.Models;

namespace Ragnarok_Mobile_Website.Views.CharacterStats
{
    public class DetailsModel : PageModel
    {
        private readonly Ragnarok_Mobile_Website.Data.PlayerContext _context;

        public DetailsModel(Ragnarok_Mobile_Website.Data.PlayerContext context)
        {
            _context = context;
        }

        public CharacterStat CharacterStat { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CharacterStat = await _context.CharacterStats.FirstOrDefaultAsync(m => m.CharacterId == id);

            if (CharacterStat == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
