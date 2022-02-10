using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Restaurant_API.Models;

namespace LKS_Restaurant_API.Controllers
{
    public class MemberController : ApiController
    {
        LKS_RestaurantPCEntities row = new LKS_RestaurantPCEntities();

        [HttpPost]
        public IHttpActionResult post([FromBody] LoginModel m)
        {
            string sql = "select * from msmember where email = '" + m.email + "' and handphone = '" + m.handPhone + "'";
            var user = row.msMembers.SqlQuery(sql).FirstOrDefault();
            if(user != null)
            {
                LoginModel l = new LoginModel();
                l.email = user.email;
                l.id = user.memberID;
                l.name = user.name;
                l.handPhone = user.handPhone;

                return Ok(l);
            }

            return null;
        }
    }
}
