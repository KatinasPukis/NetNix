using NetNix.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace NetNix.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        string Baseurl = "https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/";
        public IEnumerable<Movies> Movies { get; set; }
        public async Task<ActionResult> Index()
        {


            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage Res = await client.GetAsync($"{Baseurl}soon/");


                if (Res.IsSuccessStatusCode)
                {

                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;


                    Movies = JsonConvert.DeserializeObject<IEnumerable<Movies>>(EmpResponse);

                }
                
                return View(Movies);
            }
        }
        public async Task<ActionResult> Movie(string id)
        {
            Movies movie = new Movies();
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync($"{Baseurl}movie/{id}");

                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    movie = JsonConvert.DeserializeObject<Movies>(EmpResponse);
                    movie.image = "https://m.media-amazon.com/images/M/MV5BYzE5MjY1ZDgtMTkyNC00MTMyLThhMjAtZGI5OTE1NzFlZGJjXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_FMjpg_UY720_.jpg";
                }
                

                return View(movie);
            }
        }
        public async Task<ActionResult> Director(string id)
        {
            Directors directors = new Directors();
            

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync($"{Baseurl}director/{id}");

                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    directors = JsonConvert.DeserializeObject<Directors>(EmpResponse);

                }

                return View(directors);
            }
        }
        public async Task<ActionResult> Like(string id)
        {
            Likes likes = new Likes();


            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync($"{Baseurl}like/{id}");

                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    likes = JsonConvert.DeserializeObject<Likes>(EmpResponse);

                }

                return View(likes);
            }
        }
    }
}