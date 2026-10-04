using colorRecall.DTOs;
using colorRecall.Models;

namespace colorRecall.Services
{
	public class ColorScoringService:IColorScoringService
	{
		public async Task<HSLColorModel> pickTargetColor()
		{
			// Implement the logic to pick a target color
			return new HSLColorModel{
				Hue = Random.Shared.Next(0, 361),
				Saturation = Random.Shared.Next(0, 101),
				Lightness = Random.Shared.Next(0, 101)
			};

		}

		public int CalculateScore(HSLColorModel target, HSLColorModel user)
		{
			// 1. Shortest angular distance along the 360-degree circle (max 180)
			int rawHueDiff = Math.Abs(target.Hue - user.Hue) % 360;
			int shortestHueDiff = rawHueDiff > 180 ? 360 - rawHueDiff : rawHueDiff;

			// 2. Normalize each error to a 0.0 - 1.0 range
			double hueError = shortestHueDiff / 180.0;
			double satError = Math.Abs(target.Saturation - user.Saturation) / 100.0;
			double litError = Math.Abs(target.Lightness - user.Lightness) / 100.0;

			// 3. Average total error (0.0 = perfect match, 1.0 = total mismatch)
			double totalError = (hueError + satError + litError) / 3.0;

			// 4. Invert to a 0 - 100 score
			return (int)Math.Round((1.0 - totalError) * 100);
		}

	}
}
