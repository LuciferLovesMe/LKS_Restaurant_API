using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Restaurant_API.Models;

namespace LKS_Restaurant_API.Controllers
{
    public class FDController : ApiController
    {
        [HttpGet]
        public DataTable get()
        {
            string com = "select * from msmenu";
            return Command.data(com);
        }
    }
}
