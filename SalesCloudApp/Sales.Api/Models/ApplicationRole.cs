using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Sales.Api.Models
{
    public class ApplicationRole : IdentityRole<int, ApplicationUserRole>, IRole<int>
    {
        public ApplicationRole() : base() { }

        public ApplicationRole(string name)
            : this()

        {
            Name = name;
        }
    }

}