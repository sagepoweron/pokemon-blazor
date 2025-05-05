using PokemonBlazor.Models;
using System.Text.Json;

namespace PokemonBlazor.Tools
{
    public class PokeClient
    {
        private HttpClient _client;

        public PokeClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<Pokemon> GetPokemon(string id)
        {
            var response = await _client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Pokemon>(content);
        }
    }
}
