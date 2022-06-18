using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookAppDemo.Datas;
using BookAppDemo.Models;

namespace BookAppDemo.Pages.BookList
{
    public class EditModel : PageModel
    {
        private readonly BookAppDemo.Datas.ApplicationDbContext _context;

        public EditModel(BookAppDemo.Datas.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var book =  await _context.Books.FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            Book = book;
            return Page();
        }

       
        public async Task<IActionResult> OnPostAsync(Book book)
        {   
            if(book == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                 var bookDb = _context.Books.FirstOrDefault(m => m.Id == Book.Id);
            if(bookDb == null)
            {
                return NotFound();
            }
            bookDb.Name = book.Name;
            bookDb.Author = book.Author;
            bookDb.Categories = book.Categories;
            bookDb.Price = book.Price;
            bookDb.Updatedate =DateTime.Now;
            TempData["SweetEdit"] = "";
            await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }

    }
}
