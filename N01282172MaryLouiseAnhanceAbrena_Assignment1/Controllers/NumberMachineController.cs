using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01282172MaryLouiseAnhanceAbrena_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {

            /// <summary>
            /// Shows the answer to the operations showed
            /// Adding 10 to the id then dividing the answer to 6 and substracting to 3 and lastly multiplying 4
            /// </summary>
            /// <param name="id">Number input in url</param>
            /// <returns>The answer</returns>
            /// <example>
            /// GET api/numbermachine/8 = -1
            /// GET api/numbermachine/100 = 14
            /// </example>
            public int Get(int id)
            {
                int answer = 10 + id / 6 - 3 * 4;
                return answer;
            }
        }
}
