using ProductsApiTest.Domains;

namespace ProductsApiTest.Interfaces
{
    public interface IProductsRepository
    {
        List<Products> Get();

        Products GetById(Guid id);

        void Post(Products product);

        void Put(Guid id, Products product);

        void Delete(Guid id);
    }
}
