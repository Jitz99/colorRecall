using colorRecall.Models;

namespace colorRecall.Services
{
	public interface IGameService
	{
		public Task<HSLColorModel> GenerateTargetColor(int userId);
	}
}
