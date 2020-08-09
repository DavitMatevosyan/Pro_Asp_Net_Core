using Microsoft.AspNetCore.Mvc;

namespace MvcModels.Models
{
    public class HeaderModel
    {
        [FromHeader]
        public string Accept { get; set; }

        [FromHeader(Name = "Accept-Language")]
        public string AcceeptLanguage { get; set; }

        [FromHeader(Name = "Accept-Encoding")]
        public string AcceptEncoding { get; set; }
    }
}
