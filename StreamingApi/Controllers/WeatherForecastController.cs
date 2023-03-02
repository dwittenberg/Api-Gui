using Microsoft.AspNetCore.Mvc;

using StreamingApi.Model;

namespace StreamingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private List<Album> Library = new List<Album>();
        private int globalLastTack = -1;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;

        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Album> Get()
        {
            // Todo Add folder Path here
            var folder = new DirectoryInfo(@"C:\Users\...");

            var album = new Album();
            album.Name = folder.Name;
            album.Title = new();


            var files = folder.GetFiles();
            foreach (var file in files)
            {
                var tfile = TagLib.File.Create(file.FullName);

                var title = new Title();
                title.Name = tfile.Tag.Title;
                globalLastTack = globalLastTack + 1;
                //globalLastTack += 1;
                //globalLastTack++;
                title.TrackId = globalLastTack;
                title.TrackNr = (int)tfile.Tag.Track;
                title.Length = tfile.Properties.Duration;

                album.Title.Add(title);

            }

            Library.Add(album);
            Library.Add(album);

            return Library;
        }
    }
}