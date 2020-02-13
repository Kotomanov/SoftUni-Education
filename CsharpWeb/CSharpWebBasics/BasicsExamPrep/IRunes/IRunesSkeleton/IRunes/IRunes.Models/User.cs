﻿using System;
using System.ComponentModel.DataAnnotations;

namespace IRunes.Models
{
    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        //[MaxLength(20)] because of the SHA256
        public string Password { get; set; }
    }
}
