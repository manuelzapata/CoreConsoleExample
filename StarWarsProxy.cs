using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

using CoreConsoleExample.Model;

namespace CoreConsoleExample {

    public class StarWarsProxy {

        private readonly HttpClient client;

        public StarWarsProxy(){
            client = new HttpClient();
        }

        public async Task<List<Film>> LoadFilms() {

            var stream = client.GetStreamAsync("https://swapi.co/api/films");
            var serializer = new DataContractJsonSerializer(typeof(Result<Film>));

            //Deserialize response data.
            var response = serializer.ReadObject(await stream) as Result<Film>;
            return response.Results;

        }

    }

}