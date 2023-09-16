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
    public class ReaderDto
    {

        public long id { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public RentalsDto rentals { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
