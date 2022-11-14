namespace abstractfactory_mydramalist.Domain.Base
{
    public abstract class Dorama
    {
        public string Titulo { get; set; }
        public TypeProduct Type { get; set; }

        public Dorama(TypeProduct type)
        {
            Type = type;
        }

        public abstract List<Dorama> SearchDorama();
    }
}
