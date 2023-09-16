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
        public long id { get; set; }
        public String author { get; set; }
        public DateTime publicationDate { get; set; }
        public DateTime publishingHouse { get; set; }
        public RentalsDto rentals { get; set; }
        public TitleDto title { get; set; }
    }
}
