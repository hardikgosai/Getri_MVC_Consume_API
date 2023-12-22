using Getri_MVC_Consume_API.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Getri_MVC_Consume_API.Controllers
{
    public class UserController : Controller
    {
        HttpClient _client;
        IConfiguration configuration;

        public UserController(IConfiguration _configuration)
        {
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            _client = new HttpClient
            {
                BaseAddress = baseAddress
            };
        }

        public async Task<IActionResult> Index()
        {
            List<UsersViewModel> users = new List<UsersViewModel>();
            HttpResponseMessage response = await _client.GetAsync("api/User/GetAllUsers");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                users = JsonConvert.DeserializeObject<List<UsersViewModel>>(result);
            }
            return View(users);
        }
    }
}
