using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookAppDemo.Models
{

    public class Book
    {
        [BindProperty]
        public int Id { get; set; }
        [Required]
        [BindProperty]
        [Display(Name="Book name")]
        public string Name { get; set; }
        [Required]
        [BindProperty]
        public string Author { get; set; }
        [Required]
        [BindProperty]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required]
        [Display(Name="Category")]
        public Category Categories { get; set; }
        [BindProperty]
        [Display(Name ="Date and Time information")]
        public DateTime Regdate { get; set; }
        [BindProperty]
        public DateTime Updatedate { get; set; }

        public Book()
        {
            Regdate = DateTime.Now;
        }
      
    }
}
