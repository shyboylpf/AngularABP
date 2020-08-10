using System.ComponentModel.DataAnnotations;

namespace LiusStore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}