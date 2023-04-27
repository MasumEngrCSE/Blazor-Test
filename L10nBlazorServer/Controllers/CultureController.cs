using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace L10nBlazorServer.Controllers
{
    public class CultureController : Controller
    {
        // This action sets the culture cookie used by the
        // UseRequestLocalization middleware
        [HttpGet("/Culture/SetCulture")]
        public IActionResult SetCulture(string culture, string redirectUri)
        {
            if (culture != null)
            {
                HttpContext.Response.Cookies
                .Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(
                new RequestCulture(culture)));
            }
            return LocalRedirect(redirectUri);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
