using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressLookup.Stateful
{
    public static class Addresses
    {
        public static Dictionary<string, string> addresses = new Dictionary<string, string>();

        public static void CreateAddresses()
        {
            addresses.Add("43me15 6tw", "43 Sheals crescent, Maidstone, Kent, ME15 6TW");
        }

        public static Task<string> HasAddress(string address)
        {
            return Task.FromResult("HEllo");
        }

    }
}
