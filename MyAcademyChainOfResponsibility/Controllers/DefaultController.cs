using Microsoft.AspNetCore.Mvc;
using MyAcademyChainOfResponsibility.ChainOfResponsibility;
using MyAcademyChainOfResponsibility.Models;

namespace MyAcademyChainOfResponsibility.Controllers
{
	public class DefaultController : Controller
	{
		private readonly Clerk _clerk;
		private readonly AssistantManager _assistantManager;
		private readonly Manager _manager;
		private readonly RegionalManager _regionalManager;

		public DefaultController(Clerk clerk, AssistantManager assistantManager, Manager manager, RegionalManager regionalManager)
		{
			_clerk = clerk;
			_assistantManager = assistantManager;
			_manager = manager;
			_regionalManager = regionalManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(CustomerProcessViewModel model)
		{
			_clerk.SetNextApprover(_assistantManager);
			_assistantManager.SetNextApprover(_manager);
			_manager.SetNextApprover(_regionalManager);

			_clerk.Process(model);
			return NoContent();
		}
	}
}
