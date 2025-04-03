using SocialNetwork.Domain.Common;

namespace SocialNetwork.Domain.Entities
{
    public class Post : BaseEntity
    {
        public string Content { get; set; }
        public string? ImageUrl { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
