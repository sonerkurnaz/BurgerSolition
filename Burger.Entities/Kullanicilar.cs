namespace Burger.Entities
{
    public class Kullanicilar : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string? TcNo { get; set; }
        public string EMail { get; set; }
        public string? Gsm { get; set; }
        #region Kullanıcı girisi icin gerekli        
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        #endregion
        public IList<Adres> Adresler { get; set; }
    }
}
