using Abp.AspNetCore.Mvc.Authorization;
using Demo.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers;

[AbpMvcAuthorize]
public class HomeController : DemoControllerBase
{
    public ActionResult Index()
    {
        return View();
    }
}
