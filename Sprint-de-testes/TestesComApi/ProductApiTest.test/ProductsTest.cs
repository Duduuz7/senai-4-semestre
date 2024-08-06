using Moq;
using ProductsApiTest.Domains;
using ProductsApiTest.Interfaces;
using ProductsApiTest.Repositories;

namespace ProductApiTest.test
{
    public class ProductsTest
    {
        /// <summary>
        /// Teste para a funcionalidade de listar todos os produtos
        /// </summary>
        [Fact]
        public void Get()
        {
            //AAA = 3 As

            //ARRANGE

            //Lista de objetos
            List<Products> productList = new List<Products>
            {
                new Products  { IdPRoduct = Guid.NewGuid(), Name="Produto 1", Price=78 },
                new Products { IdPRoduct = Guid.NewGuid(), Name = "Produto 1", Price = 78 },
                new Products  { IdPRoduct = Guid.NewGuid(), Name = "Produto 1", Price = 78 }

            };

            //Cria um objeto de simulação do tipo IProductRepository
            var mockRepository = new Mock<IProductsRepository>();
            
            //Configura o método "Get" para que quando for acionado retorne a lista mockada.
            mockRepository.Setup(x => x.Get()).Returns(productList);



            //ACT

            //Executando o método "Get" e atribue a resposta em result
            var result = mockRepository.Object.Get();


            //ASSERT

            Assert.Equal(3, result.Count());

        }

        /// <summary>
        /// Teste para a funcionalidade de cadastrar um produto
        /// </summary>
        [Fact]
        public void Post()
        {
            List<Products> productList = new List<Products>();


            Products product = new Products
            {
                IdPRoduct= Guid.NewGuid(),
                Name= "Óculos da Catarina",
                Price= 32
            };


            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Post(product)).Callback<Products> ( p => {
                productList.Add(product);
            });


            mockRepository.Object.Post(product);


            Assert.Contains(product, productList);
        }

        /// <summary>
        /// Teste para a funcionalidade de deletar um produto
        /// </summary>
        [Fact]
        public void Delete()
        {

            List<Products> productList = new List<Products>();


            Products product = new Products
            {
                IdPRoduct = Guid.NewGuid(),
                Name = "Óculos da Catarina",
                Price = 32
            };

            productList.Add(product);

            var mockRepository = new Mock<IProductsRepository>();

            Assert.NotNull(productList.First());

            mockRepository.Setup(x => x.Delete(product.IdPRoduct)).Callback<Guid>(p =>
            {
                var item = productList.FirstOrDefault(p => p.IdPRoduct == product.IdPRoduct);
                if (item != null)
                {
                    productList.Remove(item);
                }
            });

           

            mockRepository.Object.Delete(product.IdPRoduct);

            Assert.DoesNotContain(product, productList);

        }

        /// <summary>
        /// Teste para a funcionalidade de buscar por id um produto
        /// </summary>
        [Fact]
        public void GetById()
        {

            List<Products> productList = new List<Products>();


            Products product = new Products
            {
                IdPRoduct = Guid.NewGuid(),
                Name = "Óculos da Catarina",
                Price = 32
            };

            productList.Add(product);


            var productBuscado = productList.FirstOrDefault(x => x.IdPRoduct == product.IdPRoduct);


            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.GetById(product.IdPRoduct)).Returns(productBuscado);

            mockRepository.Object.GetById(product.IdPRoduct);

            Assert.Equal(1, productList.Count);
        }

        /// <summary>
        /// Teste para a funcionalidade de atualizar um produto
        /// </summary>
        [Fact]
        public void Put()
        {

            List<Products> productList = new List<Products>();


            Products product = new Products
            {
                IdPRoduct = Guid.NewGuid(),
                Name = "Óculos da Catarina",
                Price = 32
            };

            productList.Add(product);


            var mockRepository = new Mock<IProductsRepository>();


            mockRepository.Setup(x => x.Put(product.IdPRoduct, product)).Callback<Guid, Products>((id, p )=>
            {
                var item = productList.FirstOrDefault(x => x.IdPRoduct == id);

                if (item != null)
                {
                    p.Name = "Óculos do Matheus Lima";
                    p.Price = 35;
                    productList.Add(product);
                }
            });

            mockRepository.Object.Put(product.IdPRoduct, product);

            Assert.Equal("Óculos do Matheus Lima", product.Name);
        }

    }
}