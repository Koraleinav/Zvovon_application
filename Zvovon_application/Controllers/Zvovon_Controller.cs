using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services;

namespace Zvovon_application.Controllers
{
    public class Zvovon_Controller : ApiController
    {
        public HttpResponseMessage GetCalc(double h, double angle, double v0)
        {
            try
            {
                return this.Request.CreateResponse(HttpStatusCode.OK, Service.calc(h, angle, v0)); //code 200
            }
            catch (Exception ex)
            {

                return this.Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message); //code 400
            }

        }
    }
}
