using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace frontend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Name { get; set; }
        public WeatherForecast[] Forecasts { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet([FromServices]WeatherClient client)
        {
            Name = "Tye 5";
            Forecasts = await client.GetWeatherAsync();

            _logger.LogDebug("Index.html visited!");
        }
    }
}
