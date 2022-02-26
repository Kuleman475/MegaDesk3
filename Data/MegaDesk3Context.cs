#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk3.Models;

namespace MegaDesk3.Data
{
    public class MegaDesk3Context : DbContext
    {
        public MegaDesk3Context (DbContextOptions<MegaDesk3Context> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk3.Models.Quote> Quote { get; set; }
    }
}
