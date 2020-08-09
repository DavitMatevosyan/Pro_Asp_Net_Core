using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models 
{
    public class GuestResponse
    {
        public int id {get; set;}

        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage="Please enter your email address")]
        [RegularExpression(".+\\@.+\\+", ErrorMessage="Please enter a valid email address")]
        public string email { get; set; }

        [Required(ErrorMessage="Please enter your phone number")]
        public int phone { get; set; }

        [Required(ErrorMessage="Please specify whether you will attend")]
        public bool? WillAttend { get; set; }
        
    }
}