using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace WebApi.Controllers {
    [ApiController]
    [Route("[controller]s")]

    public class BookController : ControllerBase
    {
        private static List <Book> BookList = new List<Book>() {
                new Book {
                    Id = 1, 
                    Title = "Lean Startup",
                    GenreId =1, 
                    PageCount  =200, 
                    PublishDate = new DateTime(2001,06,12)
                },
                new Book {
                    Id = 1, 
                    Title ="Herland",
                    GenreId = 2, //science fiction
                    PageCount = 250, 
                    PublishDate = new DateTime(2010,05,23)
                },
                new Book {
                    Id  =3,
                    Title= "Dune", 
                    GenreId = 2,
                    PageCount = 540, 
                    PublishDate = new DateTime(2001,12,21) 
                }

        };
        [HttpGet]
        public List<Book> GetBooks() 
        {
            var bookList = BookList.OrderBy( x => x.Id).ToList<Book>();
            return bookList; 
        }
    }
}