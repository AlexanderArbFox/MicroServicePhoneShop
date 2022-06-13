using Phone.Web.Models;
using Phone.Web.Services.IServices;

namespace Phone.Web.Services
{
    public class GoodService : BaseService, IGoodService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public GoodService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<T> CreateGoodAsync<T>(GoodsDto goodsDto)
        {
            // call api
          return await this.SendAsync<T>(new ApiRequest() 
            {
                apiType = SD.ApiType.POST,
                Data = goodsDto,
                Url = SD.GoodAPIBase + "api/goods", //url from controller phoneapi
                AccessToken = ""
            });
        }

        public async Task<T> DeleteGoodAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                apiType = SD.ApiType.DELETE,
                Url = SD.GoodAPIBase + "api/goods/"+id,
                AccessToken = ""
            });
        }

        public async Task<T> GetAllGoodsAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                apiType = SD.ApiType.GET,
                Url = SD.GoodAPIBase + "api/goods", 
                AccessToken = ""
            });
        }

        public async Task<T> GetGoodByIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                apiType = SD.ApiType.GET,
                Url = SD.GoodAPIBase + "api/goods/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> UpdateGoodAsync<T>(GoodsDto goodsDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                apiType = SD.ApiType.PUT,
                Url = SD.GoodAPIBase + "api/goods",
                AccessToken = ""
            });
        }
    }
}
