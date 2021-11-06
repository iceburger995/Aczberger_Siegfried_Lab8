using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aczberger_Siegfried_Lab8.Models;

namespace Aczberger_Siegfried_Lab8.Data
{
    public class Aczberger_Siegfried_Lab8Context : DbContext
    {
        public Aczberger_Siegfried_Lab8Context (DbContextOptions<Aczberger_Siegfried_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Aczberger_Siegfried_Lab8.Models.Book> Book { get; set; }

        public DbSet<Aczberger_Siegfried_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Aczberger_Siegfried_Lab8.Models.Category> Category { get; set; }
    }
}
