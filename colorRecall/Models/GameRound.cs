namespace colorRecall.Models
{
	public class GameRound
	{
		public long id { get; set; }
		public long GameSessionId { get; set; }
		public int RoundNumber { get; set; }
		public int TargetHue { get; set; }
		public int TargetSaturation { get; set; }	
		public int TargetLightness { get; set; }
		public int GuessHue { get; set; }
		public int GuessSaturation { get; set; }
		public int GuessLightness { get; set; }
		public int Score { get; set; }
		public DateTime SubmittedAt { get; set; }
	}
}
