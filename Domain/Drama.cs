using abstractfactory_mydramalist.Domain.Base;

namespace abstractfactory_mydramalist.Domain
{
    public class Drama : Dorama
    {
        public Drama() : base(TypeProduct.Drama)
        {
        }

        public override List<Dorama> SearchDorama()
        {
            return new List<Dorama>()
            {
                new Drama() {Titulo = "Goblin"},
                new Drama() {Titulo = "Strong Woman Do Bong Soon"},
                new Drama() {Titulo = "Descendants of the Sun"},
                new Drama() {Titulo = "Weightlifting Fairy Kim Bok Joo"},
                new Drama() {Titulo = "W"}
            };
        }
    }
}
