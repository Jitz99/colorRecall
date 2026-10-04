namespace colorRecall.Models
{
	public class GameSession
	{
		public long Id { get; set; }
		public long PlayerId { get; set; }

		public GameRound CurrentRound { get; set; }
		public string? status { get; set; }
		public DateTime StartedAt { get; set; }
		public DateTime CompletedAt { get; set; }
		public int FinalScore { get; set; }	
	}
}
