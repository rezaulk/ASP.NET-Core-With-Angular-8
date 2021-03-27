using BookStore.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.BooksAggregate
{
    public interface IBooksRepository: IGenericRepository<Book>
    {
        IEnumerable<Book> GetBooksByGenre(string Genre);

    }
}
