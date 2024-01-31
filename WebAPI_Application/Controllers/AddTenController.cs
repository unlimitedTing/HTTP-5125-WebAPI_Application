using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Application.Controllers
{
    public class AddTenController : ApiController
    {
        /**
         * <Summary>
         * Add 10 to the input id
         * </Summary>
         * <param name="id">the input number to add on</param>
         * <returns>the input number add 10</returns>
         * Get api/addten/15 -> 25
         */
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
