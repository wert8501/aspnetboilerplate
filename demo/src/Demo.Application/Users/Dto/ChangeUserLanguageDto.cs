using System.ComponentModel.DataAnnotations;

namespace Demo.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}