using Phone.Web.Models;

namespace Phone.Web.Services.IServices
{
    public interface IBaseService:IDisposable
    {
        /// <summary>
        /// the response will be received when a request is made to any service
        /// </summary>
        ResponseDto responseDto { get; set; }

        /// <summary>
        /// sending a request. We transmit everything related to apirequest
        /// </summary>
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
