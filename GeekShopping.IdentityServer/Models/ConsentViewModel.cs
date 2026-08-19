namespace GeekShopping.IdentityServer.Models;

public class ConsentViewModel
{
    public string ReturnUrl { get; set; } = string.Empty;

    public string ClientName { get; set; } = string.Empty;

    public string ClientUrl { get; set; }

    public string ClientLogoUrl { get; set; }

    public bool AllowRememberConsent { get; set; }

    public bool RememberConsent { get; set; }

    public string Description { get; set; }

    public IEnumerable<ScopeViewModel> IdentityScopes { get; set; }
        = Enumerable.Empty<ScopeViewModel>();

    public IEnumerable<ScopeViewModel> ApiScopes { get; set; }
        = Enumerable.Empty<ScopeViewModel>();
}