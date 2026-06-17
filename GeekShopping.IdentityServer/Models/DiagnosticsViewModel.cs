using Microsoft.AspNetCore.Authentication;

namespace GeekShopping.IdentityServer.Models;

public class DiagnosticsViewModel
{
    public AuthenticateResult? AuthenticateResult { get; set; }

    public IEnumerable<string> Clients { get; set; } = Enumerable.Empty<string>();
}