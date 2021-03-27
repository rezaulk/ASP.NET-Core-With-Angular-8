using BookStore.Domain.CatalogueAggregate;
using System;

namespace BookStore.Repository
{
    class CatalogueRepository : GenericRepository<Catalogue>, ICatalogueRepository
    {
        public CatalogueRepository(BookStoreDbContext context): base(context)
        {

        }
    }
}
