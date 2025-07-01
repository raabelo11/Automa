using Microsoft.AspNetCore.Mvc;

namespace Automa.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("Authenticate")]
        public ActionResult<Retorno> Login()
        {
            return new Retorno
            {
                ok = true,
                data = "Usuário autenticado com sucesso !",
                error = ""
            };
        }



    }

    public class Retorno
    {
        public bool ok { get; set; }
        public string data { get; set; }
        public string error { get; set; }
    }

}
