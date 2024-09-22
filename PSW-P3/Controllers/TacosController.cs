using Microsoft.AspNetCore.Mvc; // Importa el espacio de nombres para crear APIs en ASP.NET Core
using PSW_P3.Models;

// Para más información sobre cómo habilitar Web API para proyectos vacíos, visita https://go.microsoft.com/fwlink/?LinkID=397860

namespace PSW_P3.Controllers // Define el espacio de nombres para el controlador
{
    [Route("api/[controller]")] // Define la ruta base (ej. /api/tacos)
    [ApiController] // Indica que esta clase es un controlador de API
    public class TacosController : ControllerBase // Hereda de ControllerBase para funcionalidades de API
    {
        // GET: api/<TacosController>
        [HttpGet] // Método para manejar solicitudes GET a la ruta base
        public IEnumerable<Pedido> Get()
        {

            List<Pedido> list = new List<Pedido>();

            list.Add(new Pedido()
            {
                Id = 1,
                TipoTaco = "Suadero",
                Cantidad = 5

            });

            return list;
        }

        // GET api/<TacosController>/5
        [HttpGet("{id}")] // Método para manejar solicitudes GET con un parámetro id
        public string Get(int id)
        {
            // Devuelve un valor basado en el id (por ejemplo, "value")
            return "value";
        }

        // POST api/<TacosController>
        [HttpPost] // Método para manejar solicitudes POST
        public void Post([FromBody] string value)
        {
            // Aquí se manejaría el valor recibido en el cuerpo de la solicitud (no se implementa)
        }

        // PUT api/<TacosController>/5
        [HttpPut("{id}")] // Método para manejar solicitudes PUT con un parámetro id
        public void Put(int id, [FromBody] string value)
        {
            // Aquí se manejaría la actualización del recurso identificado por id (no se implementa)
        }

        // DELETE api/<TacosController>/5
        [HttpDelete("{id}")] // Método para manejar solicitudes DELETE con un parámetro id
        public void Delete(int id)
        {
            // Aquí se manejaría la eliminación del recurso identificado por id (no se implementa)
        }
    }
}
