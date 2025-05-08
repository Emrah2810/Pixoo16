using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Pixoo
{
    public class DivoomApi
    {
        private static readonly HttpClient Client = new HttpClient();

        public static async Task<string> GetSameLANDevicesAsync()
        {
            var url = "https://app.divoom-gz.com/Device/ReturnSameLANDevice";
            var content = new StringContent("{}", Encoding.UTF8, "application/json");

            try
            {
                var response = await Client.PostAsync(url, content);
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
    }
}
