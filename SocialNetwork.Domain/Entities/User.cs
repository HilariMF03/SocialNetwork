﻿using SocialNetwork.Domain.Common;

namespace SocialNetwork.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public string? Phone { get; set; }
        public string? ProfileImageUrl { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Friendship> Friends { get; set; }
    }
}
