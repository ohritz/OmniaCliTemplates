﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Omnia.Fx.NetCore.Extensions;
using Omnia.Fx.NetCore.Tenants.Extensions;
using System;

namespace $namespace$
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                BuildWebHost(args)
                .Run();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static IWebHost BuildWebHost(string[] args) =>
          WebHost.CreateDefaultBuilder(args)
                .AddOmniaFxClientResourcesHandler()
                .AddOmniaFxNetCoreTenant()
                .AddStartup<Startup>()
                .Build();
    }
}
