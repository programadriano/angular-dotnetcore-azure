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

        public Destaques Get()
        {
            return _destaqueService.GetAll();
        }
    }
}
