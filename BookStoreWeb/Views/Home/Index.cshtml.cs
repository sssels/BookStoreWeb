using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookStoreWeb.Models;

namespace BookStoreWeb.Views
{
    public class IndexModel : PageModel
    {
        private readonly HomeController _controller;


        public IndexModel(HomeController controller)
        {
            _controller = controller;
        }

        public IList<Book> Books { get; set; } = new List<Book>();

    

        public void OnGet()
        {
            //f
            Console.WriteLine(value: Books.Count);
        }
    }
}
