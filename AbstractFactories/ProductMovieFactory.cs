using abstractfactory_mydramalist.Domain;
using abstractfactory_mydramalist.Domain.Base;

namespace abstractfactory_mydramalist.AbstractFactories
{
    public class ProductMovieFactory : ProductFactory
    {
        public override Dorama CreateDorama()
        {
            return new Movie();
        }
    }
}
