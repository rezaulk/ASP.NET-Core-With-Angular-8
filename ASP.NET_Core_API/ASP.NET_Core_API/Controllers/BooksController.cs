using BookStore.Domain;
using BookStore.Domain.BooksAggregate;
using BookStore.Domain.CatalogueAggregate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BooksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<Books>
        [HttpGet]
        public async Task<IEnumerable<Book>> Get()
        {
            return await _unitOfWork.Books.GetAll();
        }

        // POST api/<Books>
        [HttpPost]
        public IActionResult Post()
        {
            var book = new Book
            {
           //     Id = 1,
                Genre = "Technology",
                Author = "Charles Petzold",
                Title = "Programming Windows 5th Edition",
                Price = 30,
                Publisher = "Microsoft Press"
            };

            var Catalog = new Catalogue
            {
           //     Id = 1,
                Name = "Programming Books",
                Description = "Books on Software development"
            };

            _unitOfWork.Books.Add(book);
            _unitOfWork.Catalogues.Add(Catalog);
            _unitOfWork.Complete();
            return Ok();
        }


    }
}
