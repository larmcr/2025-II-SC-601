using System;
using System.Collections.Generic;
using System.Web.Http;

namespace CP2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IList<KeyValuePair<string, string>> Get()
        {
            return new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("Local", DateTime.Now.ToString()),
            };
        }

        // GET api/values/5
        public IList<int> Get(int number)
        {
            var list = new List<int>();

            return list;
        }
    }
}
