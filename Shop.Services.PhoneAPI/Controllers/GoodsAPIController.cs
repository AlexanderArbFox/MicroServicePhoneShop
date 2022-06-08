using Microsoft.AspNetCore.Mvc;
using Shop.Services.PhoneAPI.Models;
using Shop.Services.PhoneAPI.Models.Dto;
using Shop.Services.PhoneAPI.Repository;

namespace Shop.Services.PhoneAPI.Controllers
{
    [Route("api/goods")]
    public class GoodsAPIController : ControllerBase
    {
        protected ResponseDto _response;
        private IGoodsRepository _goodsRepository;
        public GoodsAPIController(IGoodsRepository goodsRepository)
        {
            _goodsRepository = goodsRepository;
            this._response = new ResponseDto();
        }

        [HttpGet] // извлечение всех товаров из бд
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<GoodsDto> goodsDtos = await _goodsRepository.GetGoods();
                _response.Result = goodsDtos;   
            }
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.Message };
            }
            return _response;
        }
        
        [HttpGet] // получение товара через id
        [Route("{id}")] // маршрут в котором определяем, что тут будет использоваться идентификатор
        public async Task<object> Get(int id)
        {
            try
            {
                GoodsDto goodsDtos = await _goodsRepository.GetGoodsById(id);
                _response.Result = goodsDtos;   
            }
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.Message };
            }
            return _response;
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<object> Delete(int id)
        {
            try
            {
                bool isSuccess = await _goodsRepository.DeleteGoods(id);
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.Message };
            }
            return _response;
        }
        
        [HttpPost]
        public async Task<object> Post([FromBody] GoodsDto goodsDto)
        {
            try
            {
                GoodsDto thisGood = await _goodsRepository.CreateUpdateGoods(goodsDto);
                _response.Result = thisGood;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.Message };
            }
            return _response;
        }
        
        [HttpPut]
        public async Task<object> Put([FromBody] GoodsDto goodsDto)
        {
            try
            {
                GoodsDto thisGood = await _goodsRepository.CreateUpdateGoods(goodsDto);
                _response.Result = thisGood;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.Message };
            }
            return _response;
        }
    }
}
