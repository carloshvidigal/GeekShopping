namespace GeekShopping.IdentityServer.Models;

public class DeviceAuthorizationViewModel
{
    public string UserCode { get; set; } = string.Empty;

    public bool ConfirmUserCode { get; set; }

    public string ClientName { get; set; } = string.Empty;

    public string ClientUrl { get; set; }

    public string ClientLogoUrl { get; set; }

    public IEnumerable<ScopeViewModel> IdentityScopes { get; set; }
        = Enumerable.Empty<ScopeViewModel>();

    public IEnumerable<ScopeViewModel> ApiScopes { get; set; }
        = Enumerable.Empty<ScopeViewModel>();

    public string Description { get; set; }

    public bool AllowRememberConsent { get; set; }

    public bool RememberConsent { get; set; }
}