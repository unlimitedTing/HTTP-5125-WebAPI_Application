using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Application.Controllers
{
    public class HostCostController : ApiController
    {
        /**
         * <Summary>
         * calculate the charge,tax, and total amount based on input id
         * </Summary>
         * <param name="id">the input number reprensent days</param>
         * <returns>the charge, tax, and total amount</returns>
         * Get api/hostcost/1 -> 1 fortnights at $5.50/FN = $5.50 CAD, HST 13% = $0.72 CAD, Total = $ 6.22 CAD"
         */
        public List<string> Get(int id)
        {
            int cnt = (id / 14)+1;
            double charge = Math.Round(cnt * 5.5,2);
            double tax = Math.Round(charge * 0.13,2);
            double total = Math.Round(charge + tax,2);
            string str1 = $"{cnt} fortnights at $5.50/FN = ${charge} CAD";
            string str2 = $"HST 13% = ${tax} CAD";
            string str3 = $"Total = ${total} CAD";
            List<string> strings = new List<string> { str1, str2, str3 };
            
            return strings;
        }
    }
}
