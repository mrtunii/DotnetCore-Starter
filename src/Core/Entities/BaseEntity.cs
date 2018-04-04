using System;
namespace Core.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            DateCreated = DateTime.Now;
        }


        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

    }
}
