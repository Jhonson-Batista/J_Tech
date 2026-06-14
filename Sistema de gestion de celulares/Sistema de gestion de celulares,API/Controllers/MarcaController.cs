using Microsoft.AspNetCore.Mvc;
using Sistema_de_gestion_de_celulares_API.DTOs;
using Sistema_de_gestion_de_celulares_API.Models;

namespace Sistema_de_gestion_de_celulares_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarcaController : ControllerBase
    {
        private static List<Marca> marcas = new List<Marca>();
        private static int nextId = 1;

        [HttpGet]
        public ActionResult<List<Marca>> GetAll()
        {
            return Ok(marcas);
        }

        [HttpGet("{id}")]
        public ActionResult<Marca> GetById(int id)
        {
            var marca = marcas.FirstOrDefault(m => m.Id == id);
            if (marca == null) return NotFound();
            return Ok(marca);
        }

        [HttpPost]
        public ActionResult<Marca> Create(MarcaDto dto)
        {
            var marca = new Marca
            {
                Id = nextId++,
                Nombre = dto.Nombre,
                PaisOrigen = dto.PaisOrigen
            };
            marcas.Add(marca);
            return CreatedAtAction(nameof(GetById), new { id = marca.Id }, marca);
        }

        [HttpPut("{id}")]
        public ActionResult<Marca> Update(int id, MarcaDto dto)
        {
            var marca = marcas.FirstOrDefault(m => m.Id == id);
            if (marca == null) return NotFound();
            marca.Nombre = dto.Nombre;
            marca.PaisOrigen = dto.PaisOrigen;
            return Ok(marca);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var marca = marcas.FirstOrDefault(m => m.Id == id);
            if (marca == null) return NotFound();
            marcas.Remove(marca);
            return NoContent();
        }
    }
}