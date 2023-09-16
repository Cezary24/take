using Library.Core.Models.Reader;
using Library.Core.Models.Rental;
using Library.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Web
{
   public class RentalService : IRentalService
    {
        private readonly string url;
        private readonly IRestClient restClient;

        public RentalService(IConfiguration configuration, IRestClient restClient)
        {
            this.restClient = restClient;
            url = "http://localhost:8080/rental";
        }

        public async Task<RentalDto> AddRentalAsync(NewRentalDto reader)
        {
            string readerJSON = JsonConvert.SerializeObject(reader, new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() }
            });

            using var client = new HttpClient();
            var response = await client.PostAsync(url, new StringContent(readerJSON, Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                string resultJSON = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RentalDto>(resultJSON);
            }
            else
            {
                // Handle the error case here, e.g., throw an exception or return an error DTO.
                throw new Exception($"HTTP request failed with status code {response.StatusCode}");
            }
        }

        public async Task<RentalDto> GetRentalById(long id)
        {
            var request = new RestRequest($"{url}{id}");
            var rental = await restClient.GetAsync<RentalDto>(request);

            return rental;
        }

        public async Task<RentalsDto> GetRentalsAsync()
        {
            var request = new RestRequest(url);
            var rentals = await restClient.GetAsync<RentalsDto>(request);

            return rentals;
        }
    }
}
