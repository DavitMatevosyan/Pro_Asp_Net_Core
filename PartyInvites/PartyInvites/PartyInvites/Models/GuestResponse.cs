﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {

        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter Your Email Address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please Enter a Valid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Specify Whether You Will Attend")]
        public bool? WillAttend { get; set; }
    }
}
