﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab28_miya.Models
{
    public class ExternalLoginModel
    {
        [Required]
        [EmailAddress]
        public string Email
        {
            get; set;
        }
    }
}
