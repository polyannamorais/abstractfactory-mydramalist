using abstractfactory_mydramalist.AbstractFactories;
using abstractfactory_mydramalist.Domain;
using abstractfactory_mydramalist.Domain.Base;

namespace abstractfactory_mydramalist.Clients
{
    public class ProductClient
    {
        private readonly Dorama _dorama;
        public ProductClient(ProductFactory productFactory)
        {
            _dorama = productFactory.CreateDorama();
        }

        public List<Dorama> SearchDorama()
        {
            return _dorama.SearchDorama();
        }

        public static ProductClient CreateProductClient(TypeProduct type)
        {
            switch (type)
            {
                case TypeProduct.Drama:
                    return new ProductClient(new ProductDramaFactory());
                case TypeProduct.Movie:
                    return new ProductClient(new ProductMovieFactory());
                default:
                    throw new Exception("Não houve resultados correspondentes à pesquisa");
            }
        }
    }
}
