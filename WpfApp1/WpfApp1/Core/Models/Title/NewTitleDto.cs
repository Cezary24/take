using Library.Core.Models.Volume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models.Title
{
    class NewTitleDto
    {
        public String Name { get; set; }

        public VolumesDto Volumes { get; set; }
    }
}
