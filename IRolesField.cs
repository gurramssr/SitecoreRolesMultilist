using Sitecore.Security.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sc8.Services.SitecoreCustomEmailAction.RolesMultiListField
{
    public interface IRolesField
    {
        IEnumerable<Role> GetSelectedRoles();

        IEnumerable<Role> GetUnselectedRoles();

        string GetProviderRoleKey(Role role);
    }
}
