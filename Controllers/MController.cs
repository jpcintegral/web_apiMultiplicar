using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webApiV1.Helper;

namespace webApiV1.Controllers
{
    public class MController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public string Get()
        {
            Tablas tab = new Tablas();
            string result = string.Empty;
       
            for (int i = 0; i < 9; i++)
            {
                result += multiplicar(i);

            }
            return result;
        }

       
        private string multiplicar(int num) {
            string result = string.Empty;
            for (int i = 0; i < 9; i++)
            {
              result = result += " " + num.ToString() + "*" + " " + i.ToString() + "="+ (num *i).ToString()+ "\n\r |         ";

            }
            return result;
        }
    }
}