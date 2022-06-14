using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Phone.Web.Models;
using Phone.Web.Services.IServices;

namespace Phone.Web.Controllers
{
    public class GoodController : Controller
    {
        private readonly IGoodService _goodService;
        public GoodController(IGoodService goodService)
        {
            _goodService = goodService;
        }
        public async Task<IActionResult> GoodIndex()
        {
            List<GoodsDto> listGood = new();
            var response = await _goodService.GetAllGoodsAsync<ResponseDto>();
            if(response != null && response.IsSuccess)
            {
                listGood = JsonConvert.DeserializeObject<List<GoodsDto>>(Convert.ToString(response.Result));
            }
            return View(listGood);
        }
    }
}
