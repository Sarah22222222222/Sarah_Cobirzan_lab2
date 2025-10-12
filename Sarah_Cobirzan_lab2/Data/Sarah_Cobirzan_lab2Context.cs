using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sarah_Cobirzan_lab2.Models;

namespace Sarah_Cobirzan_lab2.Data
{
    public class Sarah_Cobirzan_lab2Context : DbContext
    {
        public Sarah_Cobirzan_lab2Context (DbContextOptions<Sarah_Cobirzan_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sarah_Cobirzan_lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Sarah_Cobirzan_lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
