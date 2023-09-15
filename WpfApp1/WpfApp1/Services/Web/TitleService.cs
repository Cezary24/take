using Library.Core.Models.Reader;
using Library.Core.Models.Title;
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
using Library.Core.Models.Rental;

namespace Library.Services.Web
{
    class TitleService : ITitleService
    {


        private readonly string url;
        private readonly IRestClient restClient;

        public TitleService(IConfiguration configuration, IRestClient restClient)
        {
            this.restClient = restClient;
            url = "title-service";
        }

        public async Task<TitleDto> AddTitleAsync(NewTitleDto title)
        {
            string titleJSON = JsonConvert.SerializeObject(title, new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() }
            });

            using var client = new HttpClient();
            var response = await client.PostAsync(url, new StringContent(titleJSON, Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                string resultJSON = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TitleDto>(resultJSON); // Deserialize to TitleDto
            }
            else
            {
                // Handle the error case here, e.g., throw an exception or return an error DTO.
                throw new Exception($"HTTP request failed with status code {response.StatusCode}");
            }
        }

        public async Task<TitleDto> GetTitleById(long titleId)
        {
            var request = new RestRequest($"{url}{titleId}");
            var title = await restClient.GetAsync<TitleDto>(request); 

            return title;
        }

        public async Task<TitlesDto> GetTitlesAsync(bool withRemoved)
        {
            var request = new RestRequest(url);
            var titles = await restClient.GetAsync<TitlesDto>(request);

            return titles;
        }
    }
}
