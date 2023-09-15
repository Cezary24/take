using Library.Core.Models.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Interfaces
{
    interface ITitleService
    {
        Task<TitleDto> AddTitleAsync(NewTitleDto title);
        Task<TitleDto> GetTitleById(long titleId);
        Task<TitlesDto> GetTitlesAsync(bool withRemoved);
    }
}
