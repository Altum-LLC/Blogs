using DependencyRegistration.Interfaces;
using DIRegistration;
using System.Threading.Tasks;

namespace DependencyRegistration.Services
{
	public class EmployeeService : IEmployee,IDependencyRegistrable
	{
		public async Task<string> GetEmployeeName()
		{
			return Task.Run(() => "Michael").Result;
		}
	}
}
