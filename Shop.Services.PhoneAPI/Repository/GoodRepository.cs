using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Shop.Services.PhoneAPI.DbContexts;
using Shop.Services.PhoneAPI.Models;

namespace Shop.Services.PhoneAPI.Repository
{
    public class GoodRepository : IGoodsRepository
    {
        private readonly MainContext _db;
        private IMapper _mapper;
        
        public GoodRepository(MainContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<GoodsDto> CreateUpdateGoods(GoodsDto goodsDto)
        {
            Goods goods = _mapper.Map<GoodsDto, Goods>(goodsDto);

            // если больше 0, то товар уже имется и нужно лишь обновить детали
            if(goods.GoodId > 0) 
            {
                _db.Goods.Update(goods);
            }
            else _db.Goods.Add(goods);
            await _db.SaveChangesAsync();
            return _mapper.Map<Goods, GoodsDto>(goods);
        }

        public async Task<bool> DeleteGoods(int goodId)
        {
            try
            {
                Goods goods = await _db.Goods.FirstOrDefaultAsync(c => c.GoodId == goodId);
                if(goods == null) // товар не был найден в бд
                {
                    return false;
                }
                _db.Goods.Remove(goods);
                await _db.SaveChangesAsync();   
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<GoodsDto>> GetGoods()
        {
            List<Goods> goodsList = await _db.Goods.ToListAsync();
            return _mapper.Map<List<GoodsDto>>(goodsList);
        }

        public async Task<GoodsDto> GetGoodsById(int goodId)
        {
            Goods goods = await _db.Goods.Where(x => x.GoodId == goodId).FirstOrDefaultAsync();
            return _mapper.Map<GoodsDto>(goods);
        }
    }
}
