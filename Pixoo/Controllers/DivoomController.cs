//using Microsoft.AspNetCore.Mvc;
//using System.Threading.Tasks;

//[ApiController]
//[Route("api/[controller]")]
//public class DivoomController : ControllerBase
//{
//    [HttpGet("devices")]
//    public async Task<IActionResult> GetDevices()
//    {
//        var result = await DivoomApi.GetSameLANDevicesAsync();
//        if (result != null)
//        {
//            return Ok(result);
//        }
//        return StatusCode(500, "Error retrieving devices.");
//    }

//    [HttpPost("playbuzzer")]
//    public async Task<IActionResult> PlayBuzzer()
//    {
//        var result = await DivoomDeviceController.PlayBuzzerAsync(500, 500, 3000);
//        if (result != null)
//            return Ok(result);

//        return StatusCode(500, "Failed to play buzzer.");
//    }

//}


//[ApiController]
//[Route("api/divoom")]
//public class DivoomController : ControllerBase
//{
//    [HttpPost("sendhttpgif")]
//    public async Task<IActionResult> SendHttpGif()
//    {
//        var result = await DivoomDeviceController.SendHttpGifAsync();
//        if (result != null)
//            return Ok(result);

//        return StatusCode(500, "Failed to send HTTP GIF.");
//    }
//}