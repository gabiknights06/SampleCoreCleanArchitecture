using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.Core.Models;
using Sample.Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sample.API.Controllers
{
    [Route("companies")]
    [Controller]
    public class CompanyController : Controller
    {
        ICompanyService<Company> _service;

        public CompanyController(ICompanyService<Company> service)
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
        public IActionResult Register([FromBody]Company data)
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
        public IActionResult Put([FromBody]Company data)
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
        public IActionResult Delete([FromBody]Company data)
        {
            _service.Remove(data);

            return Ok();
        }

    }
}
