using Library.Core.Models.Title;
using Library.Core.Models.Volume;
using Library.Services.Interfaces;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Microsoft.Extensions.Configuration;

namespace Library.Services.Web
{
    class VolumeService : IVolumeService
    {
        private readonly string url;
        private readonly IRestClient restClient;

        public VolumeService(IConfiguration configuration, IRestClient restClient)
        {
            this.restClient = restClient;
            url = "volume-service";
        }

        public async Task<VolumeDto> AddVolumeAsync(NewVolumeDto reader)
        {
            string titleJSON = JsonConvert.SerializeObject(reader, new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() }
            });

            using var client = new HttpClient();
            var response = await client.PostAsync(url, new StringContent(titleJSON, Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                string resultJSON = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<VolumeDto>(resultJSON); // Deserialize to TitleDto
            }
            else
            {
                // Handle the error case here, e.g., throw an exception or return an error DTO.
                throw new Exception($"HTTP request failed with status code {response.StatusCode}");
            }
        }

        public async Task<VolumeDto> GetVolumeById(long volumeId)
        {
            var request = new RestRequest($"{url}{volumeId}");
            var volume = await restClient.GetAsync<VolumeDto>(request);

            return volume;
        }

        public async Task<VolumesDto> GetVolumesAsync()
        {
            var request = new RestRequest(url);
            var volumes = await restClient.GetAsync<VolumesDto>(request);

            return volumes;
        }
    }
}
