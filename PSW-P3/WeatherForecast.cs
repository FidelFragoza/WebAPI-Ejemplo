namespace PSW_P3 // Define el espacio de nombres para la clase
{
    public class WeatherForecast // Clase que representa un pron�stico del tiempo
    {
        // Propiedad que almacena la fecha del pron�stico
        public DateOnly Date { get; set; }

        // Propiedad que almacena la temperatura en grados Celsius
        public int TemperatureC { get; set; }

        // Propiedad calculada que convierte la temperatura de Celsius a Fahrenheit
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        // Propiedad que almacena un resumen del clima (opcional)
        public string? Summary { get; set; }

        // Nota: Esta clase es utilizada por el WeatherForecastController
        // en el m�todo Get() para generar y devolver pron�sticos del tiempo.
        // Cada instancia de WeatherForecast representa un d�a espec�fico
        // con su correspondiente fecha, temperatura y resumen del clima.
    }
}
