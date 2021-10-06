using System.Threading.Tasks;

namespace DependencyRegistration.Interfaces
{
	public interface IDesignation
	{
		Task<string> GetDesignation();
	}
}
