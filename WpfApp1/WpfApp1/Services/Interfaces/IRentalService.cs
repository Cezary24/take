using Library.Core.Models.Rental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Interfaces
{
    public interface IRentalService
    {

        Task<RentalDto> AddRentalAsync(NewRentalDto rental);
        Task<RentalDto> GetRentalById(long rentalId);
        Task<RentalsDto> GetRentalsAsync();
    }
}
