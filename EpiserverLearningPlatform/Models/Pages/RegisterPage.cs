using EpiserverLearningPlatform.Models.Pages;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EpiserverLearningPlatform.Models
{
    public class RegisterPage : SitePageData
    {
        [Required]
        [Display(Name = "Username", GroupName = Global.GroupNames.Specialized)]
        [RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "Username can only contain letters a-z, numbers, underscores and hyphens.")]
        [StringLength(20, ErrorMessage ="The {0} field can not be more than {1} characters long.")]

        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email",
            GroupName = Global.GroupNames.Specialized)]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", GroupName = Global.GroupNames.Specialized)]
        [AllowHtml]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password", GroupName = Global.GroupNames.Specialized)]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [AllowHtml]
        public string ConfirmPassword { get; set; }

    }
}
