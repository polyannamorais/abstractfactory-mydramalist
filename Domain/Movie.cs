using abstractfactory_mydramalist.Domain.Base;

namespace abstractfactory_mydramalist.Domain
{
    public class Movie : Dorama
    {
        public Movie() : base(TypeProduct.Movie)
        {
        }

        public override List<Dorama> SearchDorama()
        {
            return new List<Dorama>()
            {
                new Movie() {Titulo = "20th Century Girl"},
                new Movie() {Titulo = "The Pirates: The Last Royal Treasure"},
                new Movie() {Titulo = "Space Sweepers"},
                new Movie() {Titulo = "Your Eyes Tell"},
                new Movie() {Titulo = "Train To Busan"}
            };
        }
    }
}
