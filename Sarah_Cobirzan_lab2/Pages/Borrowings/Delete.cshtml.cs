using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sarah_Cobirzan_lab2.Data;
using Sarah_Cobirzan_lab2.Models;

namespace Sarah_Cobirzan_lab2.Pages.Borrowings
{
    public class DeleteModel : PageModel
    {
        private readonly Sarah_Cobirzan_lab2.Data.Sarah_Cobirzan_lab2Context _context;

        public DeleteModel(Sarah_Cobirzan_lab2.Data.Sarah_Cobirzan_lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Borrowing Borrowing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Borrowing = await _context.Borrowing
        .Include(b => b.Member)
        .Include(b => b.Book)
        .FirstOrDefaultAsync(m => m.ID == id);

            if (Borrowing == null)
            {
                return NotFound();
            }
            else
            {
                Borrowing = Borrowing;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.FindAsync(id);
            if (borrowing != null)
            {
                Borrowing = borrowing;
                _context.Borrowing.Remove(Borrowing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
