namespace Domain.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            IsActive = true;
        }
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}