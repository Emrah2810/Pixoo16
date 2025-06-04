using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pixoo;
using System;
using System.Threading.Tasks;
using Pixoo16Lib.Models;
using static Pixoo16Lib.Models.GifDataRepo;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivoomController : ControllerBase
    {
        private readonly ILogger<DivoomController> _logger;

        public DivoomController(ILogger<DivoomController> logger)
        {
            _logger = logger;
        }

        [HttpGet("devices")]
        public async Task<IActionResult> GetDevices()
        {
            try
            {
                var response = await DivoomApi.GetSameLANDevicesAsync();
                if (response == null)
                    return StatusCode(500, "Kon geen verbinding maken met Divoom API.");

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij ophalen van apparaten.");
                return StatusCode(500, $"Interne fout: {ex.Message}");
            }
        }

        [HttpGet("send-default-gif")]
        public async Task<IActionResult> SendDefaultGif()
        {
            try
            {
                var result = await DivoomApi.SendHttpGifAsync(12, GifDataRepository.DefaultGif2);
                return result != null ? Ok(result) : StatusCode(500, "Verzenden van standaard-gif mislukt.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij verzenden van standaard gif.");
                return StatusCode(500, $"Interne fout: {ex.Message}");
            }
        }

        [HttpGet("send-red-gif")]
        public async Task<IActionResult> SendRedGif()
        {
            try
            {
                var result = await DivoomApi.SendHttpGifAsync(14, GifDataRepository.RedGif1);
                return result != null ? Ok(result) : StatusCode(500, "Verzenden van rode gif mislukt.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij verzenden van rode gif.");
                return StatusCode(500, $"Interne fout: {ex.Message}");
            }
        }

        [HttpPost("send-custom-gif")]
        public async Task<IActionResult> SendCustomGif([FromBody] GifRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest("Ongeldige invoer");

            try
            {
                var result = await DivoomApi.SendHttpGifAsync(request.PicId, request.PicData);
                return result != null ? Ok(result) : StatusCode(500, "Verzenden van aangepaste gif mislukt.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij verzenden van aangepaste gif.");
                return StatusCode(500, $"Interne fout: {ex.Message}");
            }
        }
    }
}
