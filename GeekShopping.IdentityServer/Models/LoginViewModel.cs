namespace GeekShopping.IdentityServer.Models;

public class LoginViewModel : LoginInputModel
{
    public bool AllowRememberLogin { get; set; } = true;

    public bool EnableLocalLogin { get; set; } = true;

    public IEnumerable<ExternalProvider> VisibleExternalProviders { get; set; }
        = Enumerable.Empty<ExternalProvider>();
}