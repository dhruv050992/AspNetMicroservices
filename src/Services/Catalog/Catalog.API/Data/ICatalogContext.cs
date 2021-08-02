using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public interface ICatalogContext
    {
        public IMongoCollection<Product> Products { get;  }
    }
}
