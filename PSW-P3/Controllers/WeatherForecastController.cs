using Microsoft.AspNetCore.Mvc; // Importa el espacio de nombres para crear APIs en ASP.NET Core

namespace PSW_P3.Controllers // Define el espacio de nombres para el controlador
{
    [ApiController] // Indica que esta clase es un controlador de API
    [Route("[controller]")] // Define la ruta base (ej. /weatherforecast)
    public class WeatherForecastController : ControllerBase // Hereda de ControllerBase
    {
        // Array est�tico de res�menes del clima
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild",
            "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger; // Logger para registrar informaci�n

        // Constructor que recibe un logger por inyecci�n de dependencias
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger; // Asigna el logger al campo privado
        }

        // M�todo que responde a solicitudes GET
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            // Genera un pron�stico del tiempo para los pr�ximos 5 d�as
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                // Establece la fecha como el d�a actual m�s el �ndice
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                // Genera una temperatura aleatoria entre -20 y 55 grados Celsius
                TemperatureC = Random.Shared.Next(-20, 55),
                // Selecciona un resumen aleatorio del clima
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray(); // Convierte la colecci�n en un arreglo
        }
    }
}
