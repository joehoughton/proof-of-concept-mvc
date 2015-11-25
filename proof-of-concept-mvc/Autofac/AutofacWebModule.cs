namespace proof_of_concept_mvc.Autofac
{
    using global::Autofac;
    using proof_of_concept.Application.People;

    public class AutofacWebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
            .Where(t => t.Name.EndsWith("Service"))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();

            builder.RegisterType<PeopleService>().As<IPeopleService>().InstancePerRequest();

            base.Load(builder);
        }
    }
}