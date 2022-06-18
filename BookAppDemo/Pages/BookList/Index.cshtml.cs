using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookAppDemo.Datas;
using BookAppDemo.Models;

namespace BookAppDemo.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            if (_context.Books != null)
            {
                ViewData["GetNumber"] = _context.Books.Count();
                Book = await _context.Books.OrderByDescending(x=>x.Regdate).ToListAsync();
            }
        }

      


    }
}
