using System.ComponentModel.DataAnnotations;

namespace SciBoard.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
