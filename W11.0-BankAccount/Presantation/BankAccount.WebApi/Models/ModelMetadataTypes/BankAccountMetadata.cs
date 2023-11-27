using System.ComponentModel.DataAnnotations;

namespace BankAccount.WebApi.Models.ModelMetadataTypes
{
    public class BankAccountMetadata
    {
        [Required(ErrorMessage = "Please, enter your firstname.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "First Name must be between 3 and 20 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please, enter your Lastname.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 20 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please, enter your phone number.")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Phone number must be 10 digits.")]
        public string PhoneNumber { get; set; }

    }
}
