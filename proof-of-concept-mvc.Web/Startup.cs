﻿using Microsoft.Owin;

[assembly: OwinStartup(typeof(proof_of_concept_mvc.Startup))]
namespace proof_of_concept_mvc
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
