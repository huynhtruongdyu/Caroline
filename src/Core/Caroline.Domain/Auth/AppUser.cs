using System.ComponentModel.DataAnnotations.Schema;

namespace Caroline.Domain.Auth
{
    public class AppUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NotMapped]
        public string Fullname { get => string.Join(" ", FirstName, LastName); }
    }
}