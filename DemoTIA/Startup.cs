﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoTIA.Startup))]
namespace DemoTIA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            // add code 1
            // add conde 2
        }
    }
}
