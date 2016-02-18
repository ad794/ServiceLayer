using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AddressLookup.Interface;
using Microsoft.ServiceFabric.Services.Remoting.Client;

namespace Web3.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            ICounter counter =
            ServiceProxy.Create<ICounter>(0, new Uri("fabric:/ServiceLayer/Stateful"));

            long count = await counter.GetCountAsync();

            return new string[] { count.ToString() };

            //IAddressLookup addressLookup =
            //ServiceProxy.Create<IAddressLookup>(0, new Uri("fabric:/ServiceLayer/Stateful"));

            //var address = await addressLookup.GetAddress("test");
            //return address;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public void Get(int id)
        {

        }

        // POST api/values
        [HttpPost]
        public string Post(string value)

        {
            IAddressLookup addressLookup =
            ServiceProxy.Create<IAddressLookup>(0, new Uri("fabric:/ServiceLayer/Stateful"));

            //var address = addressLookup.GetAddress(value).Result;

            Dictionary<string, string> addresses = new Dictionary<string, string>();
            addresses.Add("43me15 6tw", "43 sheals. cresent, maidstone, kent, ME15 6TW");
            addresses.Add("103e1 2ha", "103 Ashfield street, Whitechapel, E1 2HA");

            if (addresses.ContainsKey(value))
            {
                return addresses[value];
            }
            else return "Address not found";
        }

        public async Task<string> FuckIt(string val)
        {
            IAddressLookup addressLookup =
            ServiceProxy.Create<IAddressLookup>(0, new Uri("fabric:/ServiceLayer/Stateful"));

            var address = await addressLookup.GetAddress(val);

            return address;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
