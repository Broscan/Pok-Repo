namespace PokéRepo.Models
{
    public class ApiModels
    {
        public class Root
        {
            public int Count { get; set; }
            public string? Next { get; set; }
            public int Previous { get; set; }
            public List<Result> Results { get; set; }
        }

        public class Result
        {
            public string? Name { get; set; }
            public string? Url { get; set; }
        }




    }
}
