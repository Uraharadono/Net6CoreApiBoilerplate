using Microsoft.AspNetCore.Identity;
using Net6CoreApiBoilerplate.Infrastructure.DbUtility;

namespace Net6CoreApiBoilerplate.DbContext.Entities.Identity
{
    public class ApplicationRole : IdentityRole<long>, IIdentityEntity
    {
        public ApplicationRole() { }
        public ApplicationRole(string name) { Name = name; }
    }
}
