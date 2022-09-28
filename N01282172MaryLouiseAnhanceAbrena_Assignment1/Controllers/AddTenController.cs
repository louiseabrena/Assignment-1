using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01282172MaryLouiseAnhanceAbrena_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Adds 10 from the input number
        /// <param name="id">The number added in the url which is use to add 10</param>
        /// </summary>
        /// <returns>Return the input number plus 10</return>
        /// <example>
        /// GET localhost/api/AddTen/30 = 40
        /// GET localhost/api/AddTen/70 = 80
        /// </example>


        public int Get(int id)
        {
            int answer = id + 10;
            return answer;
        }
    }
}
