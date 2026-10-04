using System.ComponentModel.DataAnnotations;

namespace colorRecall.Models
{
	public class HSLColorModel
	{
		[Range(0, 360, ErrorMessage = "Hue must be between 0 and 360 degrees.")]
		public int Hue { get; set; }
		[Range(0, 100, ErrorMessage = "Saturation must be between 0% and 100%.")]
		public int Saturation { get; set; }
		[Range(0, 100, ErrorMessage = "Lightness must be between 0% and 100%.")]
		public int Lightness { get; set; }
	}
}
