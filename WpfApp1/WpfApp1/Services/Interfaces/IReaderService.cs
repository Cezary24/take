using Library.Core.Models.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Interfaces
{
    public interface IReaderService
    {

        Task<ReaderDto> AddReaderAsync(NewReaderDto reader);
        Task<ReaderDto> GetReaderByIndex(string index);
        Task<ReadersDto> GetReadersAsync();

   
    }
}
