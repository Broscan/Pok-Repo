using Microsoft.AspNetCore.Mvc.RazorPages;
using PokéRepo.Api;
using static PokéRepo.Models.ApiModels;

namespace PokéRepo.Pages
{
    public class IndexModel : PageModel
    {
        public List<Result>? Results { get; set; }
        public string? ErrorMessage { get; set; }

        public async Task OnGet()
        {
            try
            {
                Root result = await new ApiCaller().MakeCall("api/v2/pokemon/pikachu/");

                Results = result.Results;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }


        }
    }
}
