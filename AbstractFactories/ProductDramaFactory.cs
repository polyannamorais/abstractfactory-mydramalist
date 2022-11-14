using abstractfactory_mydramalist.Domain;
using abstractfactory_mydramalist.Domain.Base;

namespace abstractfactory_mydramalist.AbstractFactories
{
    public class ProductDramaFactory : ProductFactory
    {
        public override Dorama CreateDorama()
        {
            return new Drama();
        }
    }
}
