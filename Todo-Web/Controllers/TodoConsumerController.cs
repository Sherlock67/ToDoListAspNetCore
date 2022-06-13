using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Todo_DataAccessLayer.Models;

namespace Todo_Web.Controllers
{
    public class TodoConsumerController : Controller
    {
        private static string url = "https://localhost:7218/";
        [HttpGet]
        public IActionResult AddNewTask()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> AddNewTask(Todo todo)
        {
            string custommsg = string.Empty;
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseMsg = await client.PostAsJsonAsync("/api/v1/Todo/AddTask", todo);
                if (responseMsg != null)
                {
                    var res = responseMsg.Content.ReadAsStringAsync().Result;
                    custommsg = JsonConvert.DeserializeObject<string>(res);
                }
            }
            return View(todo);

        }
    }
}
