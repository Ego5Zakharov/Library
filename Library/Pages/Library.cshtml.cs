using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages
{
    public class LibraryModel : PageModel
    {
        [BindProperty]
        public Book NewBook { get; set; }
        public List<Book> books = new();
        public void OnGet()
        {
            books = LibraryService.LibraryService.GetAll();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            LibraryService.LibraryService.AddBook(NewBook);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            LibraryService.LibraryService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}
