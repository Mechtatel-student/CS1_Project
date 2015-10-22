using Domain.Entities.Users;

namespace Domain.Entities.Comments
{
    public enum EntityType
    {
        User,
        Client,
        Product,
        Order,
        Category
    }
    public class Comment: ExtendedEntity
    {
        public Comment()
        {
        }

        public User Author { get; set; }
        public string Text { get; set; }

        public EntityType EntityType { get; set; }
    }
}
