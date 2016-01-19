namespace proof_of_concept_mvc
{
    using System.Web.Mvc;
    using global::Autofac;
    using global::Autofac.Integration.Mvc;
    using proof_of_concept_mvc.Autofac;
    using proof_of_concept_mvc.Domain.Autofac;

    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register dependencies in filter attributes
            builder.RegisterFilterProvider();

            // Register dependencies in custom views
            builder.RegisterSource(new ViewRegistrationSource());

            // Register our Domain dependencies
            builder.RegisterModule<AutofacDomainModule>();
            builder.RegisterModule<AutofacWebModule>();

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}