using System;
using System.ComponentModel.DataAnnotations;
using Google.Protobuf.WellKnownTypes;

namespace BookStoreWeb.Models {
    public class Book
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime CreateDate { get; set; }

        
        public Book(int id, string author, string genre, string title, decimal price, int inStock, DateTime updated, DateTime created){
            this.ID = id;
            this.Author = author;
            this.Title = title;
            this.Genre = genre;
            this.Price = price;
            this.InStock = inStock;
            this.UpdateDate = updated;
            this.CreateDate = created;
        }

        public Book(){

        }
    }
}

