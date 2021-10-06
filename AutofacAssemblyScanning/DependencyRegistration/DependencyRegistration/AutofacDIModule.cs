using Autofac;
using DIRegistration;
namespace DependencyRegistration
{
    public class AutofacDIModule : Module
    {
        public AutofacDIModule()
        {
        }
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            DependencyRegistrationUtil.RegisterSingleInstance(builder, ThisAssembly);
        }
    }
}
