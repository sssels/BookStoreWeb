using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookStoreWeb.Models;

namespace BookStoreWeb.Lists
{
    public class ListOfBooks
    {
        public IList<Book> Bookz { get; set; } = new List<Book>();
    }
}
