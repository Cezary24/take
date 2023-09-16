using Library.Core.Models.Volume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models.Title
{
    public class TitleDto
    {

        public long id { get; set; }
        public String name { get; set; }

        public VolumesDto volumes { get; set; }
    }
}
