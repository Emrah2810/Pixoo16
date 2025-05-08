//using System;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;

//namespace Pixoo
//{
//    public class DivoomDeviceController
//    {
//        private static readonly HttpClient client = new HttpClient();

//        public static async Task<string> ResetGifIdAsync()
//        {
//            var url = "http://192.168.1.24:80/post";
//            var json = "{\"Command\":\"Draw/ResetHttpGifId\"}";
//            var content = new StringContent(json, Encoding.UTF8, "application/json");

//            try
//            {
//                var response = await client.PostAsync(url, content);
//                response.EnsureSuccessStatusCode();

//                var responseBody = await response.Content.ReadAsStringAsync();
//                return responseBody;
//            }
//            catch (HttpRequestException e)
//            {
//                Console.WriteLine("Request error: " + e.Message);
//                return null;
//            }
//        }
//    }

//}

