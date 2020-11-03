using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ragnarok_Mobile_Website.Data;
using Ragnarok_Mobile_Website.Models;

namespace Ragnarok_Mobile_Website.Views.UserInfo
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.UserInfo.Add(UserInfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
