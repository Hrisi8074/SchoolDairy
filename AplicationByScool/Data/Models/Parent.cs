﻿using System.ComponentModel.DataAnnotations;

namespace SchoolDairy.Data.Models
{
    public class Parent
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        public string? UserName { get; set; }

        public string? Gender { get; set; }

        public Student Student { get; set; }

        public int StudentId { get; set; }
        public ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();

    }
}
