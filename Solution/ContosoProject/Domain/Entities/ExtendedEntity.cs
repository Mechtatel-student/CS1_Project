using System;

namespace Domain.Entities
{
    public abstract class ExtendedEntity : Entity
    {
        protected ExtendedEntity() : base()
        {
            Date = DateTime.Now;
        }

        public DateTime Date { get; set; }

     } 
}
