using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("api/[controller]")]
    public class CatalogoController : Controller
    {
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return Catalogo.ListarItens();
        }
    }
}