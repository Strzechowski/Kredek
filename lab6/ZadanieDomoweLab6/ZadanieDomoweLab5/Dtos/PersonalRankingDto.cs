using System.ComponentModel.DataAnnotations;

namespace ZadanieDomoweLab5.Dtos
{
    /// <summary>
    /// Klasa zawierająca pola rankinków
    /// </summary>
    public class PersonalRankingDto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int Score { get; set; }
        [Required]
        public UserInfoDto User { get; set; }
    }
}