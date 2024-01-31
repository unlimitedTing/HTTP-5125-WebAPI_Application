using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Application.Controllers
{
    public class NumberMachineController : ApiController
    {
        /**
         * <Summary>
         * applies four mathematical operations to input number 
         * </Summary>
         * <param name="id">the input number for applly the operations</param>
         * <returns>the result of operations</returns>
         * Get api/numermacchine/15 -> "The input 15 +10 equals 25, minus 10 equals 5, multiple 10 equals 150, divid by 10 equals to 1.5"
         */
        public string Get(int id)
        {
            int add = id + 10;
            int minus = id - 10;
            int multiple = id * 10;
            decimal divid = id / 10;
            return $"The input {id} +10 equals {add}, minus 10 equals {minus}, multiple 10 equals {multiple}, divid by 10 equals to {divid}";
        }
    }
}
