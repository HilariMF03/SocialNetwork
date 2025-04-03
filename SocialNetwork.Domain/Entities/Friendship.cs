using SocialNetwork.Domain.Common;

namespace SocialNetwork.Domain.Entities
{
    public class Friendship : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int FriendId { get; set; }
        public User Friend { get; set; }
    }
}
