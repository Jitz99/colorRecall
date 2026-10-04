using colorRecall.DTOs;
using colorRecall.Models;
using colorRecall.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace colorRecall.Controllers
{
	public class SingleColorController : Controller
	{
		public IGameService _gameService { get; set; }
		public SingleColorController(IGameService gameService)
		{
			_gameService = gameService;
		}
		public IActionResult Index()
		{
			return View();
		}
		public async Task<IActionResult> SelectTargetColor(int userId)
		{
			var targetColor = await _gameService.GenerateTargetColor(userId);
			return Ok(targetColor);
		}

		public async Task<IActionResult> SubmitColorSelection(SubmitGuessRequest request)
		{
			var score = await _gameService.SubmitColorSelection(request);
			return Ok(score);
		}
	}
}
