namespace proof_of_concept_mvc.Autofac
{
    using global::Autofac;

    using proof_of_concept_mvc.Domain.Organisation;
    using proof_of_concept_mvc.Domain.Users;

    public class AutofacWebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
            .Where(t => t.Name.EndsWith("Service"))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();

            builder.RegisterType<OrganisationRepository>().As<IOrganisationRepository>().InstancePerRequest();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerRequest();

            base.Load(builder);
        }
    }
}