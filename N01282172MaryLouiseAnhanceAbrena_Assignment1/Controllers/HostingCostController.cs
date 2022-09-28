using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01282172MaryLouiseAnhanceAbrena_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        public IEnumerable<string> Get(int id)
        {

            /// <summary>
            /// Display the total cost of Fornight
            /// <param name="fNFee">Fortnight fee</param>
            /// <param name="hst">Tax</param>
            /// <param name="days">The total of how many times the fee is needed</param>
            /// <param name="daysTotal">The total fee of the the days and fee</param>
            /// <param name="hstTotal">The total tax</param>
            /// <param name="totalCost">The total fortnight fee with tax</param>
            /// <return>
            /// days fortnights at 5.50 = daysTotal CAD
            /// HST 13% = hstTotal CAD
            /// Total = totalCost CAD
            /// </return>
            /// <example>
            /// GET api/hostingcost/35 =
            /// 3 fortnights at 5.50 = 16.50 CAD
            /// HST 13% = 2.145 CAD
            /// Total = 18.645 CAD
            /// </example>
            /// </summary>

            double fNFee = 5.50;
            double hst = 0.13;
            int days = (id / 14) + 1;
            double daysTotal = days * fNFee;
            double hstTotal = daysTotal * hst;
            double totalCost = daysTotal + hstTotal;

            return new string[]
            {
                days + " fortnights at " + fNFee + " = " + daysTotal + " CAD",
                "HST 13% = " + hstTotal + " CAD",
                "Total = " + totalCost + " CAD"
            };
        }
    }
}
