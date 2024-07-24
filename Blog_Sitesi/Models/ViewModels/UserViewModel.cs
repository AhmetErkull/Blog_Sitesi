using System.ComponentModel.DataAnnotations;

namespace Blog_Sitesi.Models.ViewModels
{
    public class UserViewModel
    {
        public int UserId { get; set; }

        [Required]
        public string Name  { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password  { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Şifreler eşleşmiyor.")]
        public string ConfirmPassword  { get; set; }
        [Required]
        [EmailAddress]
        public string Email  { get; set; }
    }
}
