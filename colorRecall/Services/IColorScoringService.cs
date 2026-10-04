using colorRecall.Models;

namespace colorRecall.Services
{
	public interface IColorScoringService
	{
		public Task<HSLColorModel> pickTargetColor();
	}
}
