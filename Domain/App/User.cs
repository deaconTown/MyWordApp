using Core;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain
{
    public class User : IdentityUser<Guid>, IEntity<Guid>
    {
        public Guid? CreatedById { get; set; }
        public Guid? ModifiedById { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public UserStatus Active { get; set; }
        public ICollection<string> Group { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModificationDate { get; set; }
        [NotMapped]
        public byte[] RowVersion { get; set; }
    }
}