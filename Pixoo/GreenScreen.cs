//using System;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;

//namespace Pixoo
//{

//    public class DivoomApi2
//    {
//        private static readonly HttpClient client = new HttpClient();

//        public static async Task<string> SendHttpGifAsync()
//        {
//            var url = "http://192.168.1.20:80/post";

//            var json = @"
//        {
//            ""Command"": ""Draw/SendHttpGif"",
//            ""PicNum"": 1,
//            ""PicOffset"": 0,
//            ""PicID"": 12,
//            ""PicSpeed"": 1000,
//            ""PicData"": ""AIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAAAIAA""
//        }";

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

