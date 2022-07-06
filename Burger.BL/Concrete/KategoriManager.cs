using Burger.BL.Abstract;
using Burger.Entities;

namespace Burger.BL.Concrete
{
    public class KategoriManager : ManagerBase<Kategori>, IKategoriManager
    {
        //Aynı kategori isminden bir daha olmasın
        public bool IsmiKontrolEt(string KategoriAdi)
        {
            var sonuc = base.GetAll(p => p.KategoriAdi == KategoriAdi);
            if (sonuc != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int Add(Kategori input)
        {
            if (!IsmiKontrolEt(input.KategoriAdi))
                return base.Add(input);
            else
                return -1;
        }
    }
}
