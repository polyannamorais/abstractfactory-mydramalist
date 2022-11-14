using abstractfactory_mydramalist.Domain.Base;

namespace abstractfactory_mydramalist.AbstractFactories
{
    public abstract class ProductFactory
    {
        public abstract Dorama CreateDorama();
    }
}
