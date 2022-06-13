using Phone.Web.Models;

namespace Phone.Web.Services.IServices
{
    /// <summary>
    /// all methods for performing CRUD operations with goods
    /// </summary>
    public interface IGoodService : IBaseService
    {
        Task<T> GetAllGoodsAsync<T>();
        Task<T> GetGoodByIdAsync<T>(int id);
        Task<T> CreateGoodAsync<T>(GoodsDto goodsDto);
        Task<T> UpdateGoodAsync<T>(GoodsDto goodsDto);
        Task<T> DeleteGoodAsync<T>(int id);
    }
}
