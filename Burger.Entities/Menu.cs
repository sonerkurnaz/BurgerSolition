namespace Burger.Entities
{
    internal class Menu : BaseEntity
    {
        public string MenuAdi { get; set; }
        public string Tanimlama { get; set; }

        public decimal Fiyat { get; set; }
        public IList<MenuItem> MenuItem { get; set; }
    }
}
