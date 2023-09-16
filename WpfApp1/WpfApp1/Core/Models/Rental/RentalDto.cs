using Library.Core.Models.Reader;
using Library.Core.Models.Volume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models.Rental
{
    public class RentalDto
    {

        public long id { get; set; }
        public DateTime rentalDate { get; set; }

        public DateTime deliveryDate { get; set; }

        public ReaderDto reader { get; set; }

        public VolumeDto volume { get; set; }
    }
}
