using Autofac;
using System.Reflection;

namespace DIRegistration
{
	public class DependencyRegistrationUtil
	{
		public static void RegisterSingleInstance(ContainerBuilder builder, Assembly assembly)
		{
			builder.RegisterAssemblyTypes(assembly).Where(t => typeof(IDependencyRegistrable).IsAssignableFrom(t))
			.AsImplementedInterfaces().SingleInstance();
		}
	}
}
