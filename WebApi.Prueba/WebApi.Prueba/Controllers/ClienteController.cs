using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Prueba.Models;
using WebApi.Prueba.Services;

namespace WebApi.Prueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        IClienteService _IService;

        public ClienteController(IClienteService service)
        {
            _IService = service;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAll()
        {
            try
            {
                var cliente = _IService.GetClientesList();
                if (cliente == null)
                    return NotFound();
                return Ok(cliente);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("[action]/id")]
        public IActionResult GetById(string id)
        {
            try
            {
                var cliente = _IService.GetClienteDetailsById(id);
                if (cliente == null)
                    return NotFound();
                return Ok(cliente);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Save(Cliente _Cliente)
        {
            try
            {
                var model = _IService.SaveCliente(_Cliente);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("[action]")]
        public IActionResult Upddate(Cliente _Cliente)
        {
            try
            {
                var model = _IService.UpdateCliente(_Cliente);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("[action]/id")]
        public IActionResult Delete(string id)
        {
            try
            {
                var model = _IService.DeleteCliente(id);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
