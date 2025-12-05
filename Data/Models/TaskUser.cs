using Microsoft.AspNetCore.Identity;

namespace TickIt.Data.Models
{
    public class TaskUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        private string _displayName = string.Empty;
        public string DisplayName
        {
            get => string.IsNullOrWhiteSpace(_displayName) ? $"{FirstName} {LastName}".Trim() : _displayName;
            set => _displayName = value;
        }

        public string ProfilePictureUrl { get; set; }

        public System.DateTime CreatedAt { get; set; } = System.DateTime.UtcNow;
        public System.DateTime? LastSeenAt { get; set; }

        public bool IsActive { get; set; } = true;

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string FullName => $"{FirstName} {LastName}".Trim();

        public void TouchLastSeen() => LastSeenAt = System.DateTime.UtcNow;
    }
}