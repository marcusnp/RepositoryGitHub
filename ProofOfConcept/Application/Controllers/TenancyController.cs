using Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenancyController : ControllerBase
    {
        [HttpPost]
        public HttpResponseMessage Post(TenancyRegister model)
        {
            try
            { 
                if (ModelState.IsValid)
                {
                    //HTTP 200 (Ok) 
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    //retornar status HTTP 400 (invalid) 
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception e)
            { 
                return Request.CreateResponse (HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}