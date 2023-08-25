using ASPNETCoreAngular_FireBase_Setup.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace ASPNETCoreAngular_FireBase_Setup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CricketersController : ControllerBase
    {

        [HttpGet]
        [Route("cricketers-list")]
        public async Task<IActionResult> GetCricketersList()
        {
            try
            {
                var Uri = "https://jayanttripathy.github.io/cricketers.json";
                using (var httpClient = new HttpClient())
                {
                    var json = await httpClient.GetStringAsync(Uri);
                    var items = JsonConvert.DeserializeObject<List<Cricketer>>(json);
                    return Ok(items);
                }
            }
            catch (Exception)
            {
                return BadRequest("Getting issues to fetch the data");
            }
        }
    }
}
