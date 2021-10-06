using DependencyRegistration.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DependencyRegistration.Controllers
{
	public class HomeController : Controller
	{
		private readonly IDesignation _designation;
		private readonly IEmployee _employee;
		public HomeController(IDesignation student, IEmployee employee)
		{
			_designation = student;
			_employee = employee;
		}

		public async Task<IActionResult> Index()
		{
			ViewData["message"]=$"{await _employee.GetEmployeeName()} is a {await _designation.GetDesignation() }";
			return View();
		}
	}
}


