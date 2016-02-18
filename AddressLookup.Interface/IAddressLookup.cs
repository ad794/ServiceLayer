﻿using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressLookup.Interface
{
    public interface IAddressLookup : IService
    {
        Task<string> GetAddress(string address);
    }
}