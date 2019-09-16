using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.Core.Models;
using Sample.Service.Interface;

namespace Sample.API.Controllers
{
    [Route("persons")]
    [Controller]
    public class PersonController : Controller
    {
        IPersonService<Person> _service;

        public PersonController(IPersonService<Person> service)
        {
            _service = service;
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult Get([FromRoute]int id)
        {
             var result = _service.Load(id);

             if (result == null) return NotFound();

             return Ok(result);
        }

        [Route("pages/{pageIndex?}/{itemCount?}")]
        [HttpGet]
        public IActionResult GetList([FromRoute]int pageIndex = 0, [FromRoute]int itemCount = 10)
        {
            var result = _service.LoadAll();

            if (result == null) return NotFound();

            return Ok(result);
        }

        [Route("register")]
        [HttpPost]
        public IActionResult Register([FromBody]Person data)
        {
            try
            {
                var result = _service.Insert(data);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [Route("update")]
        [HttpPut]
        public IActionResult Put([FromBody]Person data)
        {
            try
            {
                _service.Update(data);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [Route("delete")]
        [HttpDelete]
        public IActionResult Delete([FromBody]Person data)
        {
            _service.Remove(data);

            return Ok();
        }
    }
}
