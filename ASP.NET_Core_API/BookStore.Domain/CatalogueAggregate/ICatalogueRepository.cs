using BookStore.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.CatalogueAggregate
{
    public interface ICatalogueRepository: IGenericRepository<Catalogue>
    {
    }
}
