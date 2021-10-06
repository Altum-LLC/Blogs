using System.Threading.Tasks;

namespace DependencyRegistration.Interfaces
{
	public interface IEmployee
	{
		Task<string> GetEmployeeName();
	}
}
