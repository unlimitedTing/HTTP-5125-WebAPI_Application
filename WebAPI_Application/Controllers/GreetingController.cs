using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Application.Controllers
{
    public class GreetingController : ApiController
    {
        /**
         * <Summary>
         * return greeting to the input number of people
         * </Summary>
         * <param name="id">the input number of people to greeting</param>
         * <returns>greeting to the input number of people</returns>
         * Get api/greeting/15 -> "Greeting to 15 people!"
         */
        public string Get(int id)
        {
            return $"Greeting to {id} people!";
        }
        /**
         * <Summary>
         * return Hello World
         * </Summary>
         * <param>no input param</param>
         * <returns>String "Hello World"</returns>
         * Post api/greeting -> "Hello World"
         */
        public string Post()
        {
            return "Hello World";
        }
    }
}
