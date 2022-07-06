namespace Burger.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        private DateTime _CreateDate = DateTime.Now;

        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }


    }
}
