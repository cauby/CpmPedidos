using Microsoft.AspNetCore.Mvc;

namespace CpmPedidos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : AppBaseController
    {
        public PedidoController(IServiceProvider serviceProvider): base(serviceProvider)
        {
        }
    }
}
