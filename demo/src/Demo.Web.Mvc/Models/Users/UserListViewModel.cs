using Demo.Roles.Dto;
using System.Collections.Generic;

namespace Demo.Web.Models.Users;

public class UserListViewModel
{
    public IReadOnlyList<RoleDto> Roles { get; set; }
}
