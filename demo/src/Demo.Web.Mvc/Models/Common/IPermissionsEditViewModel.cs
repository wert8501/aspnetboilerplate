using Demo.Roles.Dto;
using System.Collections.Generic;

namespace Demo.Web.Models.Common;

public interface IPermissionsEditViewModel
{
    List<FlatPermissionDto> Permissions { get; set; }
}