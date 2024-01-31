using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Application.Controllers
{
    /**
         * <Summary>
         * the square of the input number
         * </Summary>
         * <param name="id">the input number to square</param>
         * <returns>the square of input number</returns>
         * Get api/square/10 -> 100
         */
    public class SquareController : ApiController
    {
        public int Get(int id)
        {
            return (int)Math.Pow(id,2);
        }
    }
}
