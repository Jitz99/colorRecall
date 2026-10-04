using colorRecall.Models;

namespace colorRecall.DTOs
{
	public class StartRoundResponse
	{
		public int RoundNumber { get; set; }
		public HSLColorModel TargetColor { get; set; }

	}
}
