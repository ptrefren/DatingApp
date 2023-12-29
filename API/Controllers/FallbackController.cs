using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders.Physical;

namespace API.Controllers
{
    public class FallbackController : Controller
    {
       public ActionResult Index()
       {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), 
                "wwwroot", "index.html"), "text/HTML");
       } 
    }
}