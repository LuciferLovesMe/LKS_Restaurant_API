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
    public class ViewOrderController : ApiController
    {
        [HttpPost]
        public DataTable data([FromBody] View view)
        {
            string com = "select detailOrder.detailID, detailOrder.orderId, msMember.name as Member_Name, msMenu.name as Menu, msMenu.price as Price, detailOrder.qty, detailOrder.price as Total, detailOrder.status, detailOrder.paymentStatus from headerOrder join detailOrder on headerOrder.orderID = detailOrder.orderId join msMember on headerOrder.memberId = msMember.memberID join msMenu on detailOrder.menuId = msMenu.menuID where headerOrder.memberID = " + view.memberId;
            return Command.data(com);
        }
    }
}
