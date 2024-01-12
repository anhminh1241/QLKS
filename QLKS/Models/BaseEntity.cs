namespace QLKS.Models
{
    public class BaseEntity<T>
    {
        public virtual T Id { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime UpdatedAt { get; set;}
    }
}
