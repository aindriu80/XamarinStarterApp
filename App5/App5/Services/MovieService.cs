using App5.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace App5.Services
{
    public class MovieService
    {
        public static readonly int minMovieLength= 5;
        private const string Url = "http://netflixroulette.net/api/api.php";
        private HttpClient _client = new HttpClient();

        public async Task<IEnumerable<Movie_Netflix>> FindMoviesByActor(string actor)
        {
            if (actor.Length < minMovieLength)
                return Enumerable.Empty<Movie_Netflix>();

            var response = await _client.GetAsync($"{Url}?actor={actor}");

            if (response.StatusCode == HttpStatusCode.NotFound)
                return Enumerable.Empty<Movie_Netflix>();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Movie_Netflix>>(content);
        }

        public async Task<Movie_Netflix> GetMovie(string title)
        {
            var response = await _client.GetAsync($"{Url}?title={title}");

            if (response.StatusCode == HttpStatusCode.NotFound)
                return null;

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Movie_Netflix>(content);
        }
    }
}
