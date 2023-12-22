using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Getri_MVC_Consume_API.ViewModel
{
    public class UsersViewModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string ContactNo { get; set; }

        [HiddenInput]
        public long Id { get; set; }

        [Display(Name = "Created Date")]
        public DateTime ModifiedDate { get; set; }

        public string IPAddress { get; set; }
    }
}
