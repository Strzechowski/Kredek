using System.ComponentModel.DataAnnotations;

namespace ZadanieDomoweLab5.Dtos
{
    /// <summary>
    /// Klasa opisująca grę
    /// </summary>
	public class GameDto
	{
        [Required]
        public int ID { get; set; }
        [Required]
        public string NameOfGame { get; set; }
        public string LevelOfDifficulty { get; set; }
        [Required]
        public StatisticDto Stats { get; set; }
    }
}