using System.ComponentModel.DataAnnotations;

namespace ZadanieDomoweLab5.Dtos
{
    /// <summary>
    /// Klasa informacji o uzytkowniku
    /// </summary>
    public class UserInfoDto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        public string EyeColor { get; set; }
        public string FavouriteAnimal { get; set; }
    }
}