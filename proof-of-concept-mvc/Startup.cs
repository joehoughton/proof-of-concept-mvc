using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proof_of_concept_mvc.Startup))]
namespace proof_of_concept_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
