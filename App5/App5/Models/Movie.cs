using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace App5.Models
{
    public class Movie
    {
        [JsonProperty("release_date")]
        public int ReleaseDate { get; set; }

    }
}
