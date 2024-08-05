using ProductsApiTest.Contexts;
using ProductsApiTest.Domains;
using ProductsApiTest.Interfaces;

namespace ProductsApiTest.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductsContext _ctx;

        public ProductsRepository()
        {
            _ctx = new ProductsContext();
        }

        public void Delete(Guid id)
        {
            try
            {
                Products product = _ctx.Products.Find(id)!;

                _ctx.Products.Remove(product);

                _ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Products> Get()
        {
            try
            {
                return _ctx.Products.ToList();
   
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Products GetById(Guid id)
        {
            try
            {
                return _ctx.Products.FirstOrDefault(x => x.IdPRoduct == id)!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Post(Products product)
        {
            try
            {
                _ctx.Products.Add(product);

                _ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Put(Guid id, Products product)
        {
            try
            {
                Products pr = _ctx.Products.Find(id)!;

                _ctx.Products.Update(pr!);

                _ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
