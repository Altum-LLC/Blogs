using DependencyRegistration.Interfaces;
using DIRegistration;
using System.Threading.Tasks;

namespace DependencyRegistration.Services
{
	public class DesignationService : IDesignation,IDependencyRegistrable
	{
		public DesignationService()
		{}
		public async Task<string> GetDesignation()
		{
			return Task.Run(() => "Developer").Result;
		}
	}
}
