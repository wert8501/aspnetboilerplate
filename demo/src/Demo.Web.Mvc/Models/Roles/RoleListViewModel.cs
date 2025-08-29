using Demo.Roles.Dto;
using System.Collections.Generic;

namespace Demo.Web.Models.Roles;

public class RoleListViewModel
{
    public IReadOnlyList<PermissionDto> Permissions { get; set; }
}
