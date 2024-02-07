namespace PokéRepo.Models
{
    public class ApiModels
    {
        public class Root
        {
            public List<Result> Results { get; set; }
        }

        public class Result
        {
            public string Name { get; set; }
            public string Url { get; set; }
        }


        //    public List<Pokemons> Pokemon { get; set; }

        //    [JsonProperty("base_experience")]
        //    public int? BaseExperience { get; set; }

        //    [JsonProperty("forms")]
        //    public List<Form>? Forms { get; set; }

        //    [JsonProperty("height")]
        //    public int? Height { get; set; }

        //    [JsonProperty("id")]
        //    public int? Id { get; set; }

        //    [JsonProperty("location_area_encounters")]
        //    public string? LocationAreaEncounters { get; set; }

        //    [JsonProperty("name")]
        //    public string Name { get; set; }

        //    [JsonProperty("sprites")]
        //    public Sprites Sprites { get; set; }

        //    [JsonProperty("stats")]
        //    public List<Stat> Stats { get; set; }

        //    [JsonProperty("weight")]
        //    public int? Weight { get; set; }

        //}

        //public class Sprites
        //{
        //    [JsonProperty("front_default")]
        //    public string FrontDefault { get; set; }
        //}

        //public class Form
        //{
        //    [JsonProperty("name")]
        //    public string Name { get; set; }

        //    [JsonProperty("url")]
        //    public string Url { get; set; }
        //}

        //public class Stat
        //{
        //    [JsonProperty("base_stat")]
        //    public int? BaseStat { get; set; }

        //    [JsonProperty("effort")]
        //    public int? Effort { get; set; }
        //}

    }
}
