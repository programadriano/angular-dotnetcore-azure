using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestaquesController : ControllerBase
    {
        private readonly IDestaqueService _destaqueService;


        public DestaquesController(IDestaqueService destaqueService)
        {
            _destaqueService = destaqueService;
        }

        [HttpGet]
        public Task<Destaques> Get()
        {
            return _destaqueService.GetAll();
        }

        [HttpPost]
        public async Task<IActionResult> Post(Destaques destaque)
        {
            try
            {
                await _destaqueService.Create(destaque);
                return Ok("Destaque cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
