using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SumObjectAPI.Controllers
{
    public class SumObjectController : ApiController
    {
        public string Get()
        {
            return "\nWelcome to WebAPI"
                + "\n Here pass two parameters as obj1 and obj2"
                + "\n Result will be sum or concatination of these two parmeters based on input types.";
        }
        

        public string Get(string obj1, string obj2)
        {
            double num1 = 0, num2 = 0;
            bool num1OK = double.TryParse(obj1, out num1);
            bool num2OK = double.TryParse(obj2, out num2);

            if(num1OK && num2OK)
            {
                return (num1 + num2).ToString();
            }

            return obj1 + obj2;
        }
    }
}
