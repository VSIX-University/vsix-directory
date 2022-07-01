using Microsoft.AspNetCore.Mvc;
using VSIX.University.Directory.Shared;

namespace VSIX.University.Directory.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class HomeController : ControllerBase
	{
		private static readonly string[] PossibleTags = new[]
		{
			"LSP", "Adornments", "Commands", "Editor", "CodeLens"
		};

		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IEnumerable<Repository> Get()
		{
			return Enumerable.Range(1, 5).Select(index => new Repository
			{
				Name = $"Repository #{index} Name",
				Description = $"Description for Repository #{index}",
				Url = "Some Url that doesn't go anywhere",
				Tags = new List<string>
				{
					PossibleTags[Random.Shared.Next(PossibleTags.Length)],
					PossibleTags[Random.Shared.Next(PossibleTags.Length)]
				}
			})
			.ToArray();
		}
	}
}