﻿using Catalyst_web.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Catalyst_web.Models
{
    public class FormData : BaseEntity
    {
        public string? PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        public string? Message { get; set; }
    }
}
