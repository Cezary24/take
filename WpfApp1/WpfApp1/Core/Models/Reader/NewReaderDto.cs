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
        public String Name { get; set; }
        public String Surname { get; set; }
        public RentalsDto Rentals { get; set; }
    }
}
