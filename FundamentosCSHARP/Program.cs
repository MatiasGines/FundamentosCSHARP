using System;
using FundamentosCSHARP.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;

namespace FundamentosCSHARP
{
    class Program
    {


        static async Task Main(string[] args) {

            //solcitud web por http, delete
            //el delete también lleva id al final de la url
            string url = "https://jsonplaceholder.typicode.com/posts/99";
            var client = new HttpClient();

            Post post = new Post()
            {
                userId = 50,
                body = "Body",
                title = "titulo"
            };

           // var data = JsonSerializer.Serialize<Post>(post);
           //HttpContent content =
           //     new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await client.DeleteAsync(url);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();


               //ya con el valor deserializado podemos manipular el objeto
               // var postResult = JsonSerializer.Deserialize<Post>(result);


            }




            /*
            //solicitud a servicio web put(update)
            //solicita id al final de la url
            string url = "https://jsonplaceholder.typicode.com/posts/99";
            var client = new HttpClient();

            Post post = new Post()
            {
                userId = 50,
                body = "Body",
                title = "titulo"
            };

            var data = JsonSerializer.Serialize<Post>(post);
            HttpContent content =
                new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await client.PutAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();


                //ya con el valor deserializado podemos manipular el objeto
                var postResult = JsonSerializer.Deserialize<Post>(result);


            }
            */



            /* solicitud post a servicio web post (create)
            string url = "https://jsonplaceholder.typicode.com/posts";
            var client = new HttpClient();

            Post post = new Post()
            {
                userId = 50,
                body = "Body",
                title = "titulo"
            };

            var data = JsonSerializer.Serialize<Post>(post);
            HttpContent content = 
                new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await client.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();


                //ya con el valor deserializado podemos manipular el objeto
                var postResult = JsonSerializer.Deserialize<Post>(result);  


            }*/





            /***********************************************/
            /* //solicitud a servicio web por http get (read)
                string url = "https://jsonplaceholder.typicode.com/posts";
                HttpClient client = new HttpClient();

                var httpResponse = await client.GetAsync(url);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var content = await httpResponse.Content.ReadAsStringAsync();
                    List<Models.Post> posts = JsonSerializer.Deserialize<List<Models.Post>>(content);
                }
            */


            /***********************************************/

            /*serializar un json a partir de un string
            Cerveza cerveza = new Cerveza(10, "Cerveza");
            string miJson = JsonSerializer.Serialize(cerveza);
            File.WriteAllText("miJson.txt", miJson);*/

            /*deserializar un json a un objeto, a partir de un archivo
            string miJson = File.ReadAllText("miJson.txt");
            Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(miJson);*/


            /***********************************************/

            //llamando a los métodos de la clase cerveza BD para traer datos
            /*CervezaBD cervezaBD = new CervezaBD();

            //insertamos nuevos datos
            {
                Cerveza cerveza = new Cerveza(15, "Red Ipa");
                cerveza.Marca = "Lupita";
                cerveza.Alcohol = 5;
                cervezaBD.Add(cerveza);

            }
            {

                cervezaBD.Delete(3);
            }
                //obtenemos las cervezas de la BD
                var cervezas = cervezaBD.Get();

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine(cerveza.Nombre);
            }*/

            /***********************************************/
        }
    }

}