using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        [Required]
        public int Year { get; set; }

        [Required]
        public int ModelId { get; set; }
        public virtual Model Model { get; set; }

        [Required]
        public int MakeId { get; set; }
        public virtual Make Make { get; set; }
        public virtual Colour Colour { get; set; }

        [Required]
        public int ColourId { get; set; }

        [Required]
        [StringLength(50 , MinimumLength =5)]
        public string Vin { get; set; }
       
        [Required]
        [StringLength (50 , MinimumLength = 5)]
        public string LicensePlateNumber { get; set; }

        [Required]
        public double RentalRate { get; set; }

        public virtual List<Booking> Bookings { get; set; }

        [NotMapped]
        public byte[] Image { get; set; }

        public string ImageName { get; set; }
    }
}
