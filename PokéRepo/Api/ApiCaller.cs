using Newtonsoft.Json;
using static PokéRepo.Models.ApiModels;

namespace PokéRepo.Api
{
    public class ApiCaller
    {
        public HttpClient Client { get; set; }
        public ApiCaller()
        {
            Client = new();

            // Lägg till en basadress till klienten eftersom alla calls kommer gå till den sidan

        }

        public async Task<Root> MakeCall(string url)
        {
            HttpResponseMessage reponse = await Client.GetAsync(url);

            if (reponse.IsSuccessStatusCode)
            {
                string json = await reponse.Content.ReadAsStringAsync();

                Root? result = JsonConvert.DeserializeObject<Root>(json);

                if (result != null)
                {
                    return result;
                }
            }
            throw new HttpRequestException("Could not deseriealize json");
        }



    }
}
