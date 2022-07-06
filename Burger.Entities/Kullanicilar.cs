namespace Burger.Entities
{
    public class Kullanicilar : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string? TcNo { get; set; }
        public string Mail { get; set; }
        public string? Gsm { get; set; }
        public IList<Adres> Adresler { get; set; }
    }
}
