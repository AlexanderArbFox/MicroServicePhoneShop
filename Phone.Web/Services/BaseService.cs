using Newtonsoft.Json;
using Phone.Web.Models;
using Phone.Web.Services.IServices;
using System.Net.Http;
using System.Text;

namespace Phone.Web.Services
{
    public class BaseService : IBaseService
    {
        public ResponseDto responseDto { get; set; }
        public IHttpClientFactory httpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseDto = new ResponseDto();
            this.httpClient = httpClient;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public async Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            try
            {
                var client = httpClient.CreateClient("ShopAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);
                client.DefaultRequestHeaders.Clear(); // Clear object of client

                //serialize data in api request
                if(apiRequest.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data),
                        Encoding.UTF8, "application/json");
                }
                HttpResponseMessage apiResponse = null;

                switch (apiRequest.apiType)
                {
                    case SD.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case SD.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case SD.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }
                apiResponse = await client.SendAsync(message);
                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var apiResponseDto = JsonConvert.DeserializeObject<T>(apiContent);
                return apiResponseDto;
            }
            catch(Exception ex)
            {
                var dto = new ResponseDto
                {
                    DisplayMessage = "Ошибка",
                    ErrorMessages = new List<string> { Convert.ToString(ex.Message) },
                    IsSuccess = false
                };

                #region this step is created for generalized data types

                var res = JsonConvert.SerializeObject(dto);
                var apiResponseDto = JsonConvert.DeserializeObject<T>(res);

                #endregion

                return apiResponseDto;
            }
        }
    }
}
