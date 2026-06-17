using Duende.IdentityServer.Models;

namespace GeekShopping.IdentityServer.Models
{
    public class ErrorViewModel
    {
        public ErrorMessage? Error { get; set; }

        public string? RequestId => Error?.RequestId;

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}