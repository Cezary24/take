using Library.Core.Models.Reader;
using Library.Core.Models.Volume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Interfaces
{
    public interface IVolumeService
    {
        Task<VolumeDto> AddVolumeAsync(NewVolumeDto reader);
        Task<VolumesDto> GetVolumesAsync();
        Task<VolumeDto> GetVolumeById(long volumeId);

        Task deleteVolumeByIdAsync(string volumeId);
    }
}
