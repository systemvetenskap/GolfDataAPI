﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GolfDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HandicapsController : ControllerBase
    {
        // GET: api/<HandicapsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HandicapsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            // ska fixa detta med en databas
            
            // klara
            return "sträng";
        }

        // POST api/<HandicapsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HandicapsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HandicapsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
