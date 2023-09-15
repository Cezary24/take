using Library.Core.Models.Rental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library.Core.Models.Reader
{
    class ReaderDto
    {

        public long Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public RentalsDto Rentals { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
