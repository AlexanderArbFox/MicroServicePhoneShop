using static Phone.Web.SD;

namespace Phone.Web.Models
{
    /// <summary>
    /// Model to call API 
    /// </summary>
    public class ApiRequest
    {
        /// <summary>
        /// Type request. Default Method Get 
        /// </summary>
        public ApiType apiType { get; set; } = ApiType.GET;

        /// <summary>
        /// the url to which we want to send this api
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// data message in body 
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// user authentication
        /// </summary>
        public string AccessToken { get; set; }
    }
}
