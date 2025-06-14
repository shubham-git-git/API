using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace API.DomainModel
{
    public class User : IdentityUser
    {
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public DateTime? CreatedOn {  get; set; }
        
    }
}
