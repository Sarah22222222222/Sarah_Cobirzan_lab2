using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sarah_Cobirzan_lab2.Data;
using Sarah_Cobirzan_lab2.Models;

namespace Sarah_Cobirzan_lab2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Sarah_Cobirzan_lab2.Data.Sarah_Cobirzan_lab2Context _context;

        public IndexModel(Sarah_Cobirzan_lab2.Data.Sarah_Cobirzan_lab2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}

