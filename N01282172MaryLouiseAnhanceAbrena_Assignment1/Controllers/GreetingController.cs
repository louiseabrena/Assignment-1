using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01282172MaryLouiseAnhanceAbrena_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Display the string "Hello World" 
        /// </summary>
        /// <return>Says "Hello World!" </return>
        /// <example>
        /// using command prompt 
        /// curl -d "" localhost/api/Greeting = Hello World!
        /// </example>

        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Display the "id" in a string
        /// </summary>
        /// <param name="id">Input number</param>
        /// <returns>Return a string to the specific id </return>
        /// <example>
        /// GET localhost/api/Greeting/8 = Greetings to 8 people
        /// </example>

        public string Get(int id)
        {
            return "Greetings to " + id + " people";
        }
}
}
