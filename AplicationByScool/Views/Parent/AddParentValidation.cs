using System;
using System.ComponentModel.DataAnnotations;
using static SchoolDairy.Common.DataConstants.Parent;
using static SchoolDairy.Common.EntityValidationMessages;
namespace SchoolDairy.Views.Parent
{
    public class AddParentValidation
    {
        [Required(ErrorMessage = FirstNameMessages)]
        [MaxLength(FirstNameParentMaxLenght)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = LastNameMessages)]
        [MaxLength(LastNameParentMaxLenght)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = PhoneNumberMessages)]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = EmailAddressMessages)]
        public string EmailAddres { get; set; } = null!;

        public string? UserNameParent { get; set; }
    }
}
