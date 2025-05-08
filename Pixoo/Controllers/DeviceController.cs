//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Pixoo16Lib.Client;

//namespace Pixoo.Controllers
//{
//    public class PixooDeviceController
//    {
//        private readonly Pixoo16Lib.Client.PixooHttpClient _client;

//        public PixooDeviceController(string baseUrl)
//        {
//            _client = new Pixoo16Lib.Client.PixooHttpClient(baseUrl);
//        }

//        public Task PlaySoundAsync()
//        {
//            var payload = new { Command = "PlaySound", SoundId = 1 };
//            return _client.PostAsync("/post", payload);
//        }

//        public Task StartTimerAsync(int seconds)
//        {
//            var payload = new { Command = "StartTimer", Duration = seconds };
//            return _client.PostAsync("/post", payload);
//        }

//        public Task SetPixelAsync(int x, int y, string colorHex)
//        {
//            var payload = new
//            {
//                Command = "SetPixel",
//                X = x,
//                Y = y,
//                Color = colorHex
//            };
//            return _client.PostAsync("/post", payload);
//        }
//    }
//}
