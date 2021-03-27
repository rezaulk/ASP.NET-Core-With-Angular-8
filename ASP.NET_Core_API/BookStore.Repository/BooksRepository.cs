using BookStore.Domain.BooksAggregate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Repository
{
    public class BooksRepository: GenericRepository<Book>, IBooksRepository
    {

        public BooksRepository(BookStoreDbContext context) : base(context)
        {

        }

        public IEnumerable<Book> GetBooksByGenre(string Genre)
        {
            return _context.Books.Where(x => x.Genre == Genre);
        }

    }

  
}
