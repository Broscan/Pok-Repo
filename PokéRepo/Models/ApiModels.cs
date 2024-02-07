using Newtonsoft.Json;

namespace PokéRepo.Models
{
    public class ApiModels
    {
        public class Root
        {
            [JsonProperty("abilities")]
            public List<Ability> Abilities { get; set; }

            [JsonProperty("base_experience")]
            public int? BaseExperience { get; set; }

            [JsonProperty("forms")]
            public List<Form> Forms { get; set; }


            [JsonProperty("height")]
            public int? Height { get; set; }


            [JsonProperty("id")]
            public int? Id { get; set; }


            [JsonProperty("location_area_encounters")]
            public string LocationAreaEncounters { get; set; }


            [JsonProperty("name")]
            public string Name { get; set; }








            [JsonProperty("sprites")]
            public Sprites Sprites { get; set; }

            [JsonProperty("stats")]
            public List<Stat> Stats { get; set; }

            [JsonProperty("weight")]
            public int? Weight { get; set; }
        }

        public class Sprites
        {
            [JsonProperty("back_default")]
            public string BackDefault { get; set; }

            [JsonProperty("back_female")]
            public string BackFemale { get; set; }

            [JsonProperty("back_shiny")]
            public string BackShiny { get; set; }

            [JsonProperty("back_shiny_female")]
            public string BackShinyFemale { get; set; }

            [JsonProperty("front_default")]
            public string FrontDefault { get; set; }

            [JsonProperty("front_female")]
            public string FrontFemale { get; set; }

            [JsonProperty("front_shiny")]
            public string FrontShiny { get; set; }

            [JsonProperty("front_shiny_female")]
            public string FrontShinyFemale { get; set; }

        }



    }
}
