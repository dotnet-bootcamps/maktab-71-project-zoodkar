using System.ComponentModel.DataAnnotations;
using Xunit;
using Xunit.Sdk;

namespace App.EndPoints.UI.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public int PictureFileId { get; set; }
        [Required]
        [Display(Name = "آدرس")]
        public string HomeAddress { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} حداقل {2} کاراکتر و حداکتر {1} باشد", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز عبور")]
        [Compare(nameof(Password), ErrorMessage = "رمز عبور و تکرار رمز هبور باید یکسان باشند")]
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
        public IFormFile File { get; set; }

    }
}
