// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace IdentityServerHost.Quickstart.UI
{
    public class DiagnosticsViewModel
    {
        public DiagnosticsViewModel(AuthenticateResult result)
        {
            AuthenticateResult = result;

            if (result.Properties.Items.ContainsKey("client_list"))
            {
                var encoded = result.Properties.Items["client_list"];

                // Base64UrlEncoder.Decode retorna a string decodificada
                var value = Base64UrlEncoder.Decode(encoded);

                Clients = JsonSerializer.Deserialize<string[]>(value)
                          ?? Array.Empty<string>();
            }
        }

        public AuthenticateResult AuthenticateResult { get; }

        public IEnumerable<string> Clients { get; private set; } = new List<string>();
    }
}