using Library.Core.Models.Rental;
using Library.Core.Models.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models.Volume
{
    public  class VolumeDto
    {
        public long Id { get; set; }
        public String Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public DateTime PublishingHouse { get; set; }
        public RentalsDto Rentals { get; set; }
        public TitleDto Title { get; set; }
    }
}
