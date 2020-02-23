using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace AngularCore31.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CultureController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private IStringLocalizer<SharedResource> _localizer;

        public CultureController(ILogger<WeatherForecastController> logger, IStringLocalizer<SharedResource> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        [HttpPost]
        public IActionResult SetLanguage(string returnUrl, [FromForm]string targetCulture)
        {
            //string targetCulture = Request.Form.
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(targetCulture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
