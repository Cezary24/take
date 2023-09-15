using Library.Core.Models.Reader;
using Library.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.Design;

namespace Library.Services.Web
{
    class ReaderService : IReaderService
    {
        private readonly string url;
        private readonly IRestClient restClient;

        public ReaderService(IConfiguration configuration, IRestClient restClient)
        {
            this.restClient = restClient;
            url = "reader-service";
        }

        public async Task<ReaderDto> AddReaderAsync(NewReaderDto reader)
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
                return JsonConvert.DeserializeObject<ReaderDto>(resultJSON);
            }
            else
            {
                // Handle the error case here, e.g., throw an exception or return an error DTO.
                throw new Exception($"HTTP request failed with status code {response.StatusCode}");
            }
        }

        public async Task<ReaderDto> GetReaderByIndex(string index)
        {
            var request = new RestRequest($"{url}{index}");
            var reader = await restClient.GetAsync<ReaderDto>(request);

            return reader;
        }

        public async Task<ReadersDto> GetReadersAsync()
        {
            var request = new RestRequest(url);
            var readers = await restClient.GetAsync<ReadersDto>(request);

            return readers;
        }
    }
}
