using Microsoft.AspNetCore.Mvc.RazorPages;
using PokéRepo.Enums;

namespace PokéRepo.Pages
{
    public class IndexModel : PageModel
    {
        //public List<Result> Results { get; set; }
        //public string? ErrorMessage { get; set; }
        public List<string> PokemonNames { get; set; } = new();


        public async Task OnGet()
        {
            PokemonNames = Enum.GetNames(typeof(Pokemons)).ToList();

            //try
            //{
            //    Root result = await new ApiCaller().MakeCall("https://pokeapi.co/api/v2/pokemon/");

            //    Results = result.Results;
            //}
            //catch (Exception ex)
            //{
            //    ErrorMessage = ex.Message;
            //}


        }
    }
}
