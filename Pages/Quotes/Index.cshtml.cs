#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk3.Data;
using MegaDesk3.Models;

namespace MegaDesk3.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk3.Data.MegaDesk3Context _context;

        public IndexModel(MegaDesk3.Data.MegaDesk3Context context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchFirstName { get; set; }

        [BindProperty(SupportsGet = true)]

        public string SearchLastName { get; set; }
   

        public async Task OnGetAsync()
        {
            var quotes = from m in _context.Quote
                         select m;
            if (!string.IsNullOrEmpty(SearchFirstName))
            {
                quotes = quotes.Where(s => s.FirstName.Contains(SearchFirstName));
            }
            if (!string.IsNullOrEmpty(SearchLastName))
            {
                quotes = quotes.Where(s => s.LastName.Contains(SearchLastName));
            }

            Quote = await quotes.ToListAsync();


        //    Quote = await _context.Quote.ToListAsync();
        }
    }
}
