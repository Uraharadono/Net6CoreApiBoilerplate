using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Net6CoreApiBoilerplate.DbContext.Entities.Identity.Util
{
    public class ApplicationRoleStore : RoleStore<ApplicationRole, Microsoft.EntityFrameworkCore.DbContext, long>
    {
        public ApplicationRoleStore(Microsoft.EntityFrameworkCore.DbContext context)
            : base(context)
        {
        }
    }
}
