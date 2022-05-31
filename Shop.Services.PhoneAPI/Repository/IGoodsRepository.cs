using Shop.Services.PhoneAPI.Models;

namespace Shop.Services.PhoneAPI.Repository
{
    public interface IGoodsRepository
    {
        Task<IEnumerable<GoodsDto>> GetGoods(); //получение списка всех товаров
        Task<GoodsDto> GetGoodsById(int goodId); //Получение ссылки на один из товаров по id
        Task<GoodsDto> CreateUpdateGoods(GoodsDto goodsDto); // создание нового или обновление существующего товара
        Task<bool> DeleteGoods(int goodId); //удаление товара
    }
}
