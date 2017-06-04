using Newtonsoft.Json;

namespace App5.Models
{
    public class Movie
    {
        [JsonProperty("release_date")]
        public int ReleaseDate { get; set; }

    }
}
