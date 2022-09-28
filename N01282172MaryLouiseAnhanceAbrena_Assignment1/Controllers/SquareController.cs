using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01282172MaryLouiseAnhanceAbrena_Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Squares the id
        /// </summary>
        /// <param name="id">The number added to the url which is use to square the total answer</param>
        /// <returns>Return the square of an input number</return>
        /// <example>
        /// GET localhost/api/Square/100 = 10000
        /// GET localhost/api/AddTen/6 = 36
        /// </example>

        public int Get(int id)
        {
            int answer = id * id;
            return answer;
        }
}
}
