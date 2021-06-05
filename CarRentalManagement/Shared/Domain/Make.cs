using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Make : BaseDomainModel
    {
        [Required]
        [StringLength (100 , MinimumLength = 1)]
        public string Name { get; set; }
    }
}
