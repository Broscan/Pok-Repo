using Microsoft.AspNetCore.Mvc.RazorPages;
using PokéRepo.Api;
using static PokéRepo.Models.ApiModels;

namespace PokéRepo.Pages
{
	public class PokemonDetailsModel : PageModel
	{

		public Pokemon? Pokemon { get; set; }
		public async Task OnGet(string pokemonName)
		{
			try
			{
				Pokemon result = await new ApiCaller().MakeCall($"https://pokeapi.co/api/v2/pokemon/{pokemonName.ToLower()}");

				Pokemon = result;

			}
			catch (Exception ex)
			{

			}


			// Gör ett api call och använd namnet för att hämta detaljerad info om den pokemonen
		}
	}
}
