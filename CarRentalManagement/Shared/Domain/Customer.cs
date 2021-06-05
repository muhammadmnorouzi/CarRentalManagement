using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(100 , MinimumLength =2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength (100 , MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [StringLength (15 , MinimumLength = 8)]
        public string TaxId { get; set; }

        public string Address { get; set; }

        [Required]
        [Phone]
        public string ContactNumber { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        
        public List<Booking> Bookings { get; set; }
    }
}