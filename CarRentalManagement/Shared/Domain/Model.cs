using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Model:BaseDomainModel
    {
        [Required]
        [StringLength(100 , MinimumLength =1)]
        public string Name { get; set; }
    }
}