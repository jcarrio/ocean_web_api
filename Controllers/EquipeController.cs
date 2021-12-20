using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ocean_ejogos_api.Controllers
{
    //padrão de rota, dominio/api/nomecontroller
    [Route("api/[controller]")]
    [ApiController]
    // herança ControllerBase, heranças já prontas
    public class EquipeController : Controller
    {
        // verbo (estará disponível para consulta)
        [HttpGet]
        public IActionResult qualquercoisa()
        {
            return Ok("Localizar equipes");
        }

/*
        [HttpGet]
        public IActionResult localizar()
        {
            return Ok("localizar as equipes");
        }

        public IActionResult Index()
        {
            return View();
        }
*/
    }
}
