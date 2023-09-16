using Library.Core.Models.Rental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models.Reader
{
    public class NewReaderDto
    {
        public String name { get; set; }
        public String surname { get; set; }
        public RentalsDto rentals { get; set; }
    }
}
