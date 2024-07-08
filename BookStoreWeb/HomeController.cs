using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStoreWeb.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
using Google.Protobuf.WellKnownTypes;
public class HomeController : Controller
{
    private readonly IConfiguration _configuration;

    public HomeController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("BookshopContext"));
        connection.Open();
        MySqlCommand commands = connection.CreateCommand();
        MySqlDataReader reader;

        commands.CommandText = "SELECT * FROM books;";
        reader = commands.ExecuteReader();

        reader.Read();

        int i = 0;

        var listBooks = new List<Book>();

        while (reader.Read()){
            Book newBook = new Book((int)reader[i], (string)reader[i + 1], (string)reader[i + 2], (string)reader[i + 3], (decimal)reader[i + 4], (int)reader[i + 5], (DateTime)reader[i + 6], (DateTime)reader[i + 7]);
            listBooks.Add(newBook);
        }

        IEnumerable<Book> listOfBooks = listBooks;

        //f

        return View(listOfBooks);
    }
}
