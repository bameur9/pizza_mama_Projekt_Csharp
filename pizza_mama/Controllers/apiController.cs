using Microsoft.AspNetCore.Mvc;
using pizza_mama.Data;
using pizza_mama.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_mama.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class apiController : Controller
    {
        public DataContext _context;
        public apiController(DataContext context)
        {
            _context = context;

        }

        public IList<Pizza> Pizza { get; set; }

        // GET: api/<apiController>
        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            //var pizza = new Pizza();
            //1- DataContext
            //2 - Récupérer les Pizzas -> Json
            var pizzas =  _context.Pizzas.ToList();

            return Json(pizzas);
        }


        /*

        // GET api/<apiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<apiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<apiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<apiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
