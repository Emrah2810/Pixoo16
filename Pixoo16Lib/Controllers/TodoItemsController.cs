using Microsoft.AspNetCore.Mvc;
using Pixoo;
using Pixoo16Lib; // juiste namespace gebruiken
using System.Threading.Tasks;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivoomController : ControllerBase
    {
        [HttpGet("devices")]
        public async Task<IActionResult> GetDevices()
        {
            var response = await DivoomApi.GetSameLANDevicesAsync();

            if (response == null)
            {
                return StatusCode(500, "Kon geen verbinding maken met Divoom API.");
            }

            return Ok(response);
        }


        [HttpGet("send-gif")]
        public async Task<IActionResult> SendGif()
        {
            var result = await DivoomApi2.SendHttpGifAsync();
            return result != null ? Ok(result) : StatusCode(500);
        }



        [HttpGet("send-gifRed")]
        public async Task<IActionResult> SendGif2()
        {
            var result = await DivoomApi3.SendHttpGifAsync();
            return result != null ? Ok(result) : StatusCode(500);
        }

    }




}
