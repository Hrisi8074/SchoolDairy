﻿using SchoolDairy.Data.Model;
using System.ComponentModel.DataAnnotations;
using static SchoolDairy.Common.DataConstants.Parent;

namespace SchoolDairy.Data.Models
{
    public class Parent
    {
        public Parent()
        {
            Students = new List<Student>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(FirstNameParentMaxLenght)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameParentMaxLenght)]
        public string LastName { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string EmailAddres { get; set; } = null!;

        public string? UserNameParent { get; set; }

        public string? Gender { get; set; }

        public virtual ICollection<Student> Students { get; set; } = null!;

    }
}
