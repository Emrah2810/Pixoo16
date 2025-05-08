using Pixoo16Lib.Client;
using Pixoo16Lib.Models;

namespace Pixoo16Lib.Services
{
    public class PixooDevice
    {
        private readonly PixooHttpClient _client;

        public PixooDevice(PixooHttpClient client)
        {
            _client = client;
        }

        public async Task<DeviceInfo> GetDeviceInfoAsync()
        {
            return await _client.GetAsync<DeviceInfo>("/getDeviceInfo");
        }
    }
}
