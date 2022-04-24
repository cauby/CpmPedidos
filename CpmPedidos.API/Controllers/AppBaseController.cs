using Microsoft.AspNetCore.Mvc;

namespace CpmPedidos.API.Controllers
{
    public class AppBaseController : ControllerBase
    {
        protected readonly IServiceProvider ServiceProvider;
        public AppBaseController(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
    }
}
