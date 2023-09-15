using Library.Core.Models.Reader;
using Library.Core.Models.Volume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models.Rental
{
    class NewRentalDto
    {

        public DateTime RentalDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public ReaderDto Reader { get; set; }

        public VolumeDto Volume { get; set; }
    }
}
