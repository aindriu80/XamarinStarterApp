using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace App5.Models
{
    public class Movie_Netflix
    {
        [JsonProperty("show_id")]
        public string Id { get; set; }

        [JsonProperty("show_title")]
        public string Title { get; set; }

        [JsonProperty("release_year")]
        public int ReleaseYear { get; set; }

        [JsonProperty("poster")]
        public string Poster { get; set; }

        [JsonProperty("rating")]
        public float Rating { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }
}
