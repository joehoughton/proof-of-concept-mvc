namespace proof_of_concept_mvc.Autofac
{
    using global::Autofac;

    using proof_of_concept_mvc.Application.Organisation;
    using proof_of_concept_mvc.Application.Users;

    public class AutofacWebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
            .Where(t => t.Name.EndsWith("Service"))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();

            builder.RegisterType<OrganisationService>().As<IOrganisationService>().InstancePerRequest();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerRequest();

            base.Load(builder);
        }
    }
}