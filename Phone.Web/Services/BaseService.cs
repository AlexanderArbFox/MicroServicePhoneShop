using Phone.Web.Models;
using Phone.Web.Services.IServices;

namespace Phone.Web.Services
{
    public class BaseService : IBaseService
    {
        public ResponseDto responseDto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            throw new NotImplementedException();
        }
    }
}
