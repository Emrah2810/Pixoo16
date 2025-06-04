using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pixoo
{
    public class DivoomApi
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetSameLANDevicesAsync()
        {
            var url = "https://app.divoom-gz.com/Device/ReturnSameLANDevice";
            var content = new StringContent("{}", Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Request error: " + e.Message);
                return null;
            }
        }

        public static async Task<string> SendHttpGifAsync(int picId, string picData)
        {
            var url = "http://192.168.1.25:80/post";

            var json = $@"
            {{
                ""Command"": ""Draw/SendHttpGif"",
                ""PicNum"": 1,
                ""PicOffset"": 0,
                ""PicID"": {picId},
                ""PicSpeed"": 1000,
                ""PicData"": ""{picData}""
            }}";

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Request error: " + e.Message);
                return null;
            }
        }
    }
}
