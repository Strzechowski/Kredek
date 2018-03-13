using System.ComponentModel.DataAnnotations;

namespace ZadanieDomoweLab5.Dtos
{
    /// <summary>
    /// Klasa zawiera statystki gier
    /// </summary>
	public class StatisticDto
	{
        [Required]
        public int ID { get; set; }
        [Required]
        public int NumberOfViews { get; set; }
        [Required]
        public int TimeSpendInGame { get; set; }
    }
}