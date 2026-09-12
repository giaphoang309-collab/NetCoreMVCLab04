using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCoreMVCLab04.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book() {
                    Id = 1,
                    Title = "Chí Phèo",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/b1.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                },
                new Book() {
                    Id = 2,
                    Title = "Truyện Kiều",
                    AuthorId = 2,
                    GenreId = 1,
                    Image = "/images/products/b2.jpg",
                    Price = 400000,
                    Sumary = "",
                    TotalPage = 180
                },
                new Book() {
                    Id = 3,
                    Title = "Harry Potter and the Deathly Halloween ",
                    AuthorId = 3,
                    GenreId = 2,
                    Image = "/images/products/b3.jpg",
                    Price = 300000,
                    Sumary = "",
                    TotalPage = 300
                },
                new Book() {
                    Id = 4,
                    Title = "Sherlock Holmes",
                    AuthorId = 4,
                    GenreId = 2,
                    Image = "/images/products/b4.jpg",
                    Price = 250000,
                    Sumary = "",
                    TotalPage = 220
                }
            };
            return books;
        }

        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        public List<SelectListItem> Authors { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Nam Cao" },
            new SelectListItem { Value = "2", Text = "Nguyễn Du" },
            new SelectListItem { Value = "3", Text = "J.K Rowling" },
            new SelectListItem { Value = "4", Text = "Conan Doyle" }
        };

        public List<SelectListItem> Genres { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Văn học cổ điển" },
            new SelectListItem { Value = "2", Text = "Sách kỹ năng / Văn hóa" }
        };
    }
}