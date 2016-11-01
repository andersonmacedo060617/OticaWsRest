using OticaModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OticaWS.Controllers
{
    [RoutePrefix("api/Oculos")]
    public class OculosController : ApiController
    {
        [Route("TodasAsGrifes")]
        public IHttpActionResult TodasAsGrifes()
        {
            var grifes = new List<Grife>();
            grifes.Add(new Grife()
            {
                Id = 2,
                Descricao = "Speedo",
                Preco = 79.9
            });
            return Ok(grifes);
        }

       
    }
}
