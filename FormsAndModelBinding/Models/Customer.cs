using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormsAndModelBinding.Models
{
    public class Customer
    {
        /// <summary>
        /// First legal name of the customer.
        /// </summary>
        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="First name is required.")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last Legal name of the customer
        /// </summary>
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        /// <summary>
        /// Date customer was born
        /// </summary>
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Customer email
        /// ex: customer@someplace.com
        /// </summary>
        [Display(Name = "Primary Email")]
        [DataType(DataType.EmailAddress)]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
