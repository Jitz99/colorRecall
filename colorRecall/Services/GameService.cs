using colorRecall.Models;

namespace colorRecall.Services
{
	public class GameService: IGameService
	{
		public IColorScoringService _colorScoringService;
		public GameService(IColorScoringService colorScoringService) { 
			this._colorScoringService = colorScoringService;
		}
		public async Task<HSLColorModel> GenerateTargetColor(int userId)
		{
			// Implement the logic to generate a target color for the user
			return await this._colorScoringService.pickTargetColor();
		}
	}
}
