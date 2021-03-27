using BookStore.Domain.BooksAggregate;
using BookStore.Domain.CatalogueAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IBooksRepository Books { get; }
        ICatalogueRepository Catalogues { get; }

        int Complete();
    }
}
