using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace miwebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            var alumnos = new List<Student>();
            var A1 = new Student();
            var A2 = new Student();
            var A3 = new Student();
            var A4 = new Student();
            var A5 = new Student();
            var A6 = new Student();

            A1.SetPromedio(8);
            A2.SetPromedio(6);
            A3.SetPromedio(10);
            A4.SetPromedio(3);
            A5.SetPromedio(5);
            A6.SetPromedio(1);
            
            alumnos.Add(A1);
            alumnos.Add(A2);
            alumnos.Add(A3);
            alumnos.Add(A4);
            alumnos.Add(A5);
            alumnos.Add(A6);

            return alumnos.OrderBy(p => p.Promedio).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
