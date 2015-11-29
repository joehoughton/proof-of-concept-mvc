namespace proof_of_concept_mvc.Autofac
{
    using global::Autofac;
    using proof_of_concept.Application.Organisation;

    public class AutofacWebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
            .Where(t => t.Name.EndsWith("Service"))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();

            builder.RegisterType<OrganisationService>().As<IOrganisationService>().InstancePerRequest();

            base.Load(builder);
        }
    }
}