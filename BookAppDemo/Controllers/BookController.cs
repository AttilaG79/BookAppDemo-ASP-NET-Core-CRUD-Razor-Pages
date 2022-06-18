using BookAppDemo.Datas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAppDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet] 

        public IActionResult GetBooks()
        {
            return Json(new { data = _context.Books.ToList() });
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var bookInDb = await _context.Books.FindAsync(Id);
            if (bookInDb == null)
            return Json(new { success = false, message = "Error while deleting" });
            _context.Books.Remove(bookInDb);
            await _context.SaveChangesAsync();
            return Json(new { success = false, message = "Successfully Deleted" });

        }
      

    }
}
