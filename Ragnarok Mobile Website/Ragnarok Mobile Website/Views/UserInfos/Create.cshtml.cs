using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ragnarok_Mobile_Website.Data;
using Ragnarok_Mobile_Website.Models;

namespace Ragnarok_Mobile_Website.Views.UserInfos
{
    public class CreateModel : PageModel
    {
        private readonly Ragnarok_Mobile_Website.Data.PlayerContext _context;

        public CreateModel(Ragnarok_Mobile_Website.Data.PlayerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public UserInfo UserInfo { get; set; }
        public AdventureBook AdventureBook { get; set; }
        public CharacterStat CharacterStat { get; set; }
        public ClassStat ClassStat { get; set; }
        public Equipment Equipment { get; set; }
        public GoddessPrayer GoddessPrayer { get; set; }
        public Guild Guild { get; set; }
        public StatusResistance StatusResistance { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.UserInfos.Add(UserInfo);
            _context.AdventureBooks.Add(AdventureBook);
            _context.CharacterStats.Add(CharacterStat);
            _context.ClassStats.Add(ClassStat);
            _context.Equipments.Add(Equipment);
            _context.GoddessPrayers.Add(GoddessPrayer);
            _context.Guilds.Add(Guild);
            _context.StatusResistances.Add(StatusResistance);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
