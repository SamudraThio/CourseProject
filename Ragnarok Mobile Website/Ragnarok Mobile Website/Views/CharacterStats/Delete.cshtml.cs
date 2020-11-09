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
    public class DeleteModel : PageModel
    {
        private readonly Ragnarok_Mobile_Website.Data.PlayerContext _context;

        public DeleteModel(Ragnarok_Mobile_Website.Data.PlayerContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CharacterStat = await _context.CharacterStats.FindAsync(id);

            if (CharacterStat != null)
            {
                _context.CharacterStats.Remove(CharacterStat);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
